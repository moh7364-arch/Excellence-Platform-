using AcademicPlatform.Models;

namespace AcademicPlatform.Data;

public class DemoRepository
{
    public IReadOnlyList<ServiceItem> Services { get; } = new List<ServiceItem>
    {
        new() { Icon="🎓", Category="الدراسات العليا", Title="إرشاد رسائل الماجستير والدكتوراه", Description="صياغة العنوان، الإشكالية، خطة البحث، الإطار النظري، المنهجية، والمراجعة العلمية وفق معايير النزاهة الأكاديمية." },
        new() { Icon="📄", Category="النشر العلمي", Title="إعداد المقالات البحثية للنشر", Description="تحسين المخطوط، اختيار المجلة المناسبة، تنسيق القالب، خطاب التقديم، ومتابعة التحكيم والردود." },
        new() { Icon="🔍", Category="الجودة", Title="فحص الاقتباس والتدقيق المنهجي", Description="مراجعة التشابه، تحسين الصياغة، ضبط المراجع APA/Vancouver، وفحص الاتساق العلمي." },
        new() { Icon="🌐", Category="اللغة", Title="الترجمة والتحرير الأكاديمي", Description="ترجمة عربية/إنجليزية وتحرير أكاديمي متقدم للنصوص الطبية والهندسية والإنسانية." },
        new() { Icon="📊", Category="التحليل", Title="التحليل الإحصائي والنوعي", Description="SPSS، R، Python، AMOS، SmartPLS، NVivo وتحويل النتائج إلى جداول ومناقشة علمية." },
        new() { Icon="💻", Category="مشاريع التخرج", Title="دعم مشاريع التخرج التطبيقية", Description="اختيار الفكرة، بناء النموذج الأولي، كتابة التقرير، العرض التقديمي، والتوثيق الفني." }
    };

    public IReadOnlyList<string> Specialties { get; } = new List<string>
    {
        "الطب البشري", "طب الأسنان", "الصيدلة", "التمريض", "الصحة العامة", "المختبرات الطبية", "العلاج الطبيعي",
        "الهندسة المدنية", "الهندسة المعمارية", "الهندسة الكهربائية", "الهندسة الميكانيكية", "هندسة البرمجيات", "الذكاء الاصطناعي", "الأمن السيبراني",
        "القانون العام", "القانون الخاص", "القانون الدولي", "القانون التجاري", "القانون الجنائي",
        "إدارة الأعمال", "المحاسبة", "التمويل", "الاقتصاد", "التسويق",
        "علم الاجتماع", "علم النفس", "الإعلام والاتصال", "العلوم السياسية", "العلاقات الدولية",
        "التاريخ", "الفلسفة", "اللغة العربية", "اللغة الإنجليزية", "الدراسات الإسلامية",
        "الكيمياء", "الفيزياء", "الأحياء", "علوم البيئة", "الجيولوجيا"
    };

    public IReadOnlyList<Expert> Experts { get; } = new List<Expert>
    {
        new() { Id=1, FullName="د. ليلى منصور", Title="خبيرة منهجية ونشر علمي", Specialty="الصحة العامة والعلوم الطبية", Bio="تدقيق منهجي وتحسين مخطوطات طبية للنشر في مجلات محكمة.", Rating=4.9, ReviewsCount=128, CompletedProjects=214 },
        new() { Id=2, FullName="د. سامر العلي", Title="محلل إحصائي وباحث كمي", Specialty="الإدارة والعلوم الاجتماعية", Bio="تحليل SPSS وAMOS وSmartPLS وبناء نماذج قياس واختبار فرضيات.", Rating=4.8, ReviewsCount=96, CompletedProjects=173 },
        new() { Id=3, FullName="د. هبة قاسم", Title="محررة أكاديمية ومترجمة", Specialty="العلوم الإنسانية والقانون", Bio="تحرير أكاديمي عربي/إنجليزي وتوثيق APA وVancouver وOSCOLA.", Rating=4.7, ReviewsCount=84, CompletedProjects=151 },
        new() { Id=4, FullName="م. كريم ناصر", Title="مستشار مشاريع هندسية وتقنية", Specialty="الهندسة وعلوم الحاسوب", Bio="إرشاد مشاريع التخرج، النمذجة، التقارير الفنية، والواجهات البرمجية.", Rating=4.9, ReviewsCount=112, CompletedProjects=189 }
    };

    public IReadOnlyList<StudentOrder> Orders { get; } = new List<StudentOrder>
    {
        new() { Id=1001, StudentName="طالب تجريبي", ServiceName="خطة رسالة ماجستير", Specialty="القانون التجاري", Status="قيد المراجعة العلمية", Progress=65, DueDate=DateTime.Today.AddDays(6), ExpertName="د. هبة قاسم" },
        new() { Id=1002, StudentName="طالب تجريبي", ServiceName="تحليل إحصائي", Specialty="إدارة الأعمال", Status="مرحلة التحليل", Progress=40, DueDate=DateTime.Today.AddDays(10), ExpertName="د. سامر العلي" },
        new() { Id=1003, StudentName="طالب تجريبي", ServiceName="اختيار مجلة وتنسيق", Specialty="الصحة العامة", Status="جاهز للتسليم", Progress=95, DueDate=DateTime.Today.AddDays(2), ExpertName="د. ليلى منصور" }
    };

    public IReadOnlyList<TemplateItem> Templates { get; } = new List<TemplateItem>
    {
        new() { Id=1, Title="قالب خطة بحث ماجستير", Type="Proposal", CitationStyle="APA 7", Description="هيكل عربي منظم يشمل الإشكالية، الأسئلة، الأهداف، الأهمية، والمنهجية." },
        new() { Id=2, Title="قالب مقالة طبية", Type="Manuscript", CitationStyle="Vancouver", Description="IMRaD مع جداول نتائج ومراجع مرقمة." },
        new() { Id=3, Title="نموذج رد على المحكمين", Type="Peer Review", CitationStyle="عام", Description="جدول تعليقات المحكمين والردود والتعديلات." },
        new() { Id=4, Title="قالب مشروع تخرج هندسي", Type="Graduation Project", CitationStyle="IEEE", Description="مقدمة، متطلبات، تصميم، تنفيذ، اختبار، وخاتمة." }
    };

    public IReadOnlyList<ForumPost> Posts { get; } = new List<ForumPost>
    {
        new() { Id=1, Title="كيف أختار مجلة مناسبة لمقالتي؟", Author="باحث دكتوراه", Category="النشر العلمي", Replies=12, CreatedAt=DateTime.Today.AddDays(-1) },
        new() { Id=2, Title="الفرق بين المنهج الوصفي والتحليلي", Author="طالبة ماجستير", Category="المنهجية", Replies=8, CreatedAt=DateTime.Today.AddDays(-3) },
        new() { Id=3, Title="أفضل طريقة لعرض نتائج SPSS", Author="باحث اجتماعي", Category="التحليل الإحصائي", Replies=15, CreatedAt=DateTime.Today.AddDays(-5) }
    };
}
