using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class SortedBindingList<T> : BindingList<T>
{
    private readonly PropertyDescriptor sortProperty;
    private readonly ListSortDirection defaultSortDirection;
    private bool isSortingEnabled = true;

    public SortedBindingList(IEnumerable<T> collection, PropertyDescriptor sortProperty, ListSortDirection defaultSortDirection)
        : base(collection.ToList())
    {
        this.sortProperty = sortProperty ?? throw new ArgumentNullException(nameof(sortProperty));
        this.defaultSortDirection = defaultSortDirection;
        ApplySortCore(sortProperty, defaultSortDirection);
    }

    public SortedBindingList(PropertyDescriptor sortProperty, ListSortDirection defaultSortDirection)
    {
        this.sortProperty = sortProperty ?? throw new ArgumentNullException(nameof(sortProperty));
        this.defaultSortDirection = defaultSortDirection;
    }

    protected override bool SupportsSortingCore => true;

    protected override ListSortDirection SortDirectionCore => defaultSortDirection;

    protected override PropertyDescriptor SortPropertyCore => sortProperty;

    protected override bool IsSortedCore => isSortingEnabled;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
        if (isSortingEnabled)
        {
            var items = Items as List<T>;
            if (items != null)
            {
                var comparer = new PropertyComparer<T>(prop, direction);
                items.Sort(comparer);
            }
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }

    public void resort()
    {
        ApplySortCore(sortProperty, defaultSortDirection);
    }

    public void setSorting(Boolean setTo)
    {
        isSortingEnabled = setTo;
        if (isSortingEnabled)
        {
            ApplySortCore(sortProperty, defaultSortDirection);
        }
        else
        {
            ResetBindings();
        }
    }

    private class PropertyComparer<TItem> : IComparer<TItem>
    {
        private readonly PropertyDescriptor property;
        private readonly int direction;

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            this.property = property;
            this.direction = direction == ListSortDirection.Ascending ? 1 : -1;
        }

        public int Compare(TItem x, TItem y)
        {
            var valueX = property.GetValue(x) as IComparable;
            var valueY = property.GetValue(y) as IComparable;

            if (valueX == null && valueY == null)
                return 0;
            if (valueX == null)
                return -1 * direction;
            if (valueY == null)
                return direction;

            return direction * valueX.CompareTo(valueY);
        }
    }
    public new void Add(T item)
    {
        base.Add(item);

        if (isSortingEnabled)
        {
            ApplySortCore(sortProperty, defaultSortDirection);
        }
        else
        {
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }

}