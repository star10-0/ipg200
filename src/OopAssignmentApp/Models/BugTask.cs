namespace OopAssignmentApp.Models;

public class BugTask : WorkItem
{
    public string Severity { get; }

    public BugTask(string id, string title, string severity) : base(id, title)
    {
        Severity = severity;
    }

    public override string GetSummary()
    {
        return $"[Bug] {Title} | Severity: {Severity} | Done: {IsDone}";
    }
}
