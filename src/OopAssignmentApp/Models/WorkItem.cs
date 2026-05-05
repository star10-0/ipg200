using OopAssignmentApp.Infrastructure;

namespace OopAssignmentApp.Models;

public abstract class WorkItem : ITaskItem
{
    private string _title;
    private bool _isDone;

    public string Id { get; }

    public string Title
    {
        get => _title;
        private set => _title = DomainValidator.RequireNonEmpty(value, nameof(Title));
    }

    public bool IsDone => _isDone;

    protected WorkItem(string id, string title)
    {
        Id = DomainValidator.RequireNonEmpty(id, nameof(id));
        Title = title;
        ProjectMetrics.TotalCreatedItems++;
    }

    public void Rename(string title)
    {
        Title = title;
    }

    public virtual void MarkDone()
    {
        if (_isDone)
        {
            return;
        }

        _isDone = true;
        ProjectMetrics.TotalCompletedItems++;
    }

    public abstract string GetSummary();
}
