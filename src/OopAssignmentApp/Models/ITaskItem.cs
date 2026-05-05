namespace OopAssignmentApp.Models;

public interface ITaskItem
{
    string Id { get; }
    string Title { get; }
    string GetSummary();
    void MarkDone();
}
