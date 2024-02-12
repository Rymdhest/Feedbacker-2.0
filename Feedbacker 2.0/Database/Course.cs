using Feedbacker_2._0.Database;
using System.ComponentModel;

internal class Course : INotifyPropertyChanged
{
    private int id;
    private string name;
    private string description;
    public BindingList<Assignment> assignments { get; set; }

    public int Id
    {
        get { return id; }
        set
        {
            if (id != value)
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (description != value)
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }

    public BindingList<Assignment> Assignments
    {
        get { return assignments; }
        set
        {
            if (assignments != value)
            {
                assignments = value;
                OnPropertyChanged(nameof(Assignments));
            }
        }
    }

    public Course()
    {
        Assignments = new BindingList<Assignment>();
        Name = "New Course";
    }

    public Course(int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        Assignments = new BindingList<Assignment>();
    }

    // Implement INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}