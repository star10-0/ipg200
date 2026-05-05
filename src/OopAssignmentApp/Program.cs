using OopAssignmentApp.Infrastructure;
using OopAssignmentApp.Models;

TaskBoard board = new();

board.TaskCompleted += item =>
{
    Console.WriteLine($"Event => Completed: {item.Title}");
};

board.AddItem(new FeatureTask("F-101", "Build login module", 8));
board.AddItem(new BugTask("B-220", "Fix null exception", "High"));
board.AddItem(new ResearchTask("R-300", "Study SignalR", "Real-time updates"));

Console.WriteLine("=== Task List (Polymorphism) ===");
foreach (WorkItem item in board.Items)
{
    Console.WriteLine(item.GetSummary());
}

board.CompleteItem("B-220");

Console.WriteLine();
Console.WriteLine("=== Static Metrics ===");
Console.WriteLine($"Created Items: {ProjectMetrics.TotalCreatedItems}");
Console.WriteLine($"Completed Items: {ProjectMetrics.TotalCompletedItems}");
Console.WriteLine($"Total Boards: {TaskBoard.TotalBoardsCreated}");
