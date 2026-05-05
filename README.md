# TIC_IPG203_S25 - OOP Project (C#)

## مهم جدًا لمستخدمي Visual Studio

إذا كان المشروع لا يعمل في Visual Studio:

1. افتح الملف `OopAssignmentApp.sln` (وليس ملف منفرد).
2. تأكد أن إصدار Visual Studio هو 2022 أو أحدث مع تثبيت **.NET 8 SDK**.
3. من `Build > Clean Solution` ثم `Build > Rebuild Solution`.
4. اجعل `OopAssignmentApp` هو Startup Project.

## مطابقة متطلبات الواجب

- **Abstraction**: `ITaskItem` + `WorkItem` (Abstract Class).
- **Inheritance**: `FeatureTask`, `BugTask`, `ResearchTask`.
- **Polymorphism**: `GetSummary()` مع `List<WorkItem>`.
- **Encapsulation**: حقول خاصة وخصائص وصول مضبوط.
- **Delegates & Events**: `TaskCompletedHandler` + `TaskCompleted`.
- **Static**: `DomainValidator`, `ProjectMetrics`, `TaskBoard.TotalBoardsCreated`.

## التشغيل من الطرفية

```bash
dotnet run --project src/OopAssignmentApp/OopAssignmentApp.csproj
```
