# TIC_IPG203_S25 - OOP Project (C#)

هذا الحل مطابق لمتطلبات التكليف ويغطي المبادئ التالية بشكل عملي:

- **Abstraction**: `ITaskItem` + `WorkItem` (Abstract Class).
- **Inheritance**: ثلاث فئات مشتقة (`FeatureTask`, `BugTask`, `ResearchTask`).
- **Polymorphism**: إعادة تعريف `GetSummary()` وتشغيلها من `List<WorkItem>`.
- **Encapsulation**: حقول خاصة + خصائص بتحكم وصول + حماية القيم من التعديل غير المسموح.
- **Delegates & Events**: التفويض `TaskCompletedHandler` والحدث `TaskCompleted`.
- **Static Classes & Members**:
  - `DomainValidator` (Static Class للتحقق من صحة البيانات).
  - `ProjectMetrics` (Static Members لعدّ العناصر).
  - `TaskBoard.TotalBoardsCreated` (Static Property في فئة غير ساكنة).

## مطابقة نص المتطلبات (Checklist)

- [x] Interface أساسية بعمليات مجردة.
- [x] Abstract Class تطبق الواجهة وتحتوي دالة مجردة.
- [x] 3 فئات فرعية على الأقل ترث من الفئة المجردة.
- [x] Override في كل فئة فرعية.
- [x] فئة تحتوي `List` وتُظهر تعدد الأشكال.
- [x] الحقول خاصة `private`.
- [x] خصائص مع تحكم بالوصول + قيم لا تُعدّل بعد الإنشاء (مثل `Id`).
- [x] Delegate + Event لإشعار حالة محددة (إكمال المهمة).
- [x] Static Class للتحقق من البيانات.
- [x] Static Property لحساب قيمة إجمالية/عددية.

## تشغيل المشروع

```bash
dotnet run --project src/OopAssignmentApp/OopAssignmentApp.csproj
```

## هيكل المشروع

- `src/OopAssignmentApp/Models` الكيانات الأساسية.
- `src/OopAssignmentApp/Infrastructure` أدوات مساندة (Validation & Metrics).
- `src/OopAssignmentApp/Program.cs` سيناريو تشغيل يثبت كل مبدأ.
- `docs/report-template.md` قالب التقرير النهائي.
