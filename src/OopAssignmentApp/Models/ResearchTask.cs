namespace OopAssignmentApp.Models;

public class ResearchTask : WorkItem
{
    public string Topic { get; }

    public ResearchTask(string id, string title, string topic) : base(id, title)
    {
        Topic = topic;
    }

    public override string GetSummary()
    {
        return $"[Research] {Title} | Topic: {Topic} | Done: {IsDone}";
    }
}
