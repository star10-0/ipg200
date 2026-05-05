# تقرير مشروع OOP - TIC_IPG203_S25

## 1) مقدمة
- المجال المختار: نظام إدارة مهام فريق تطوير برمجيات.
- الهدف: تطبيق مبادئ OOP المطلوبة بشكل عملي وقابل للتشغيل.

## 2) تطبيق مبادئ OOP (مطابق للنص)

### 2.1 Abstraction
- **Interface:** `ITaskItem` يحوي العمليات الأساسية (`GetSummary`, `MarkDone`).
- **Abstract Class:** `WorkItem` يطبق الواجهة ويحتوي دالة مجردة `GetSummary` + خصائص وسلوك مشترك.

### 2.2 Inheritance & Polymorphism
- الفئات الفرعية:
  - `FeatureTask`
  - `BugTask`
  - `ResearchTask`
- كل فئة تعيد تعريف `GetSummary()`.
- التعدد يظهر في `TaskBoard` عبر `List<WorkItem>` وحلقة طباعة واحدة تتعامل مع كل الأنواع.

### 2.3 Encapsulation
- جميع الحقول الحساسة خاصة (`private`) داخل `WorkItem`.
- التحكم في الوصول عبر Properties.
- المعرف `Id` للقراءة فقط ولا يتغير بعد الإنشاء.
- التحقق من صحة البيانات يتم عبر `DomainValidator`.

### 2.4 Delegates & Events
- **Delegate:** `TaskCompletedHandler`
- **Event:** `TaskCompleted` داخل `TaskBoard`.
- عند إكمال أي مهمة يتم إطلاق الحدث لإشعار النظام.

### 2.5 Static Classes & Members
- `DomainValidator`: فئة ساكنة للتحقق من المدخلات.
- `ProjectMetrics`: أعضاء ساكنة لحساب عدد العناصر المُنشأة والمكتملة.
- `TaskBoard.TotalBoardsCreated`: خاصية ساكنة لحساب عدد اللوحات.

## 3) UML مبسط (نصي)
- `ITaskItem` <|.. `WorkItem`
- `WorkItem` <|-- `FeatureTask`
- `WorkItem` <|-- `BugTask`
- `WorkItem` <|-- `ResearchTask`
- `TaskBoard` o-- `WorkItem` (List)

## 4) شرح سيناريو التشغيل
1. إنشاء `TaskBoard` والاشتراك في الحدث `TaskCompleted`.
2. إضافة كائنات من الأنواع الثلاثة المشتقة.
3. طباعة الملخصات عبر قائمة موحدة (Polymorphism).
4. إكمال مهمة وإطلاق الحدث.
5. طباعة المؤشرات الساكنة.

## 5) رابط GitHub
- أضف رابط المستودع هنا.
