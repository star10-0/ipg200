namespace OopAssignmentApp.Models;

public class FeatureTask : WorkItem
{
    public int StoryPoints { get; }

    public FeatureTask(string id, string title, int storyPoints) : base(id, title)
    {
        StoryPoints = storyPoints;
    }

    public override string GetSummary()
    {
        return $"[Feature] {Title} | Points: {StoryPoints} | Done: {IsDone}";
    }
}
