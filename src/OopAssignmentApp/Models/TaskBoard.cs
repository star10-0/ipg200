namespace OopAssignmentApp.Models;

public delegate void TaskCompletedHandler(WorkItem workItem);

public class TaskBoard
{
    private readonly List<WorkItem> _items = new();

    public static int TotalBoardsCreated { get; private set; }

    public event TaskCompletedHandler? TaskCompleted;

    public IReadOnlyList<WorkItem> Items => _items;

    public TaskBoard()
    {
        TotalBoardsCreated++;
    }

    public void AddItem(WorkItem item)
    {
        _items.Add(item);
    }

    public void CompleteItem(string id)
    {
        WorkItem? item = _items.FirstOrDefault(x => x.Id == id);
        if (item is null)
        {
            return;
        }

        item.MarkDone();
        TaskCompleted?.Invoke(item);
    }
}
