using System.ComponentModel;

public class DataGridViewDragDropHandler<T>
{
    private int rowIndexFromMouseDown;
    private Rectangle dragBoxFromMouseDown;
    private DataGridViewRow draggedRow;
    private T draggedData;
    private bool isDragging;

    public void DataGridView_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            rowIndexFromMouseDown = ((DataGridView)sender).HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)), dragSize);

                draggedRow = ((DataGridView)sender).Rows[rowIndexFromMouseDown];
                // Store the data
                draggedData = (T)draggedRow.DataBoundItem;
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }
    }

    public void DataGridView_MouseMove(object sender, MouseEventArgs e)
    {
        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
        {
            if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
            {
                isDragging = true;

                if (draggedData != null)
                {
                    // Start the drag-and-drop operation
                    DragDropEffects allowedEffects = DragDropEffects.Move | DragDropEffects.Copy;
                    DragDropEffects dropEffect = ((DataGridView)sender).DoDragDrop(draggedData, allowedEffects);
                }
            }
        }
    }

    public void DataGridView_DragDrop(object sender, DragEventArgs e)
    {
        Point clientPoint = ((DataGridView)sender).PointToClient(new Point(e.X, e.Y));
        int dropIndex = ((DataGridView)sender).HitTest(clientPoint.X, clientPoint.Y).RowIndex;

        if (dropIndex == -1)
        {
            dropIndex = ((DataGridView)sender).Rows.Count - 1;
        }

        if (e.Effect == DragDropEffects.Move)
        {
            // Ensure that the data source is a BindingList
            if (((DataGridView)sender).DataSource is BindingList<T> dataSource)
            {
                if (dropIndex >= dataSource.Count - 1)
                {
                    dropIndex = dataSource.Count - 1;
                }

                // Remove the row from the old position in the BindingList
                dataSource.RemoveAt(rowIndexFromMouseDown);

                // Insert the row at the new position in the BindingList
                dataSource.Insert(dropIndex, draggedData);
            }

            ((DataGridView)sender).Rows[dropIndex].Selected = true;
            isDragging = false;
        }
    }

    public void DataGridView_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    public void DataGridView_DragOver(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }
}