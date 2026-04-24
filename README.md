# AcademicPlatform - أكاديميا برو

منصة أكاديمية عربية أولية مبنية باستخدام ASP.NET Core MVC مع HTML وCSS وJavaScript وC#.

## المزايا الموجودة

- صفحة رئيسية عربية RTL
- عرض الخدمات الأكاديمية
- نظام تقييم خبراء تجريبي
- لوحة تحكم الطالب
- تتبع تقدم الطلبات
- مكتبة نماذج جاهزة
- مجتمع أكاديمي / Forum تجريبي
- تصميم Responsive مناسب للجوال

## التشغيل محلياً

تحتاج إلى .NET SDK 8.0 أو أحدث.

```bash
dotnet restore
dotnet run
```

ثم افتح الرابط الذي يظهر في الطرفية، غالباً:

```text
https://localhost:5001
```

## النشر على GitHub

```bash
git init
git add .
git commit -m "Initial academic platform"
git branch -M main
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPOSITORY.git
git push -u origin main
```

## ملاحظات إنتاجية مهمة

هذه نسخة أولية ببيانات تجريبية داخل `DemoRepository`. للإنتاج الحقيقي أضف:

- قاعدة بيانات SQL Server أو PostgreSQL
- نظام تسجيل دخول للطلاب والخبراء والإدارة
- رفع ملفات آمن
- بوابة دفع إلكتروني
- لوحة إدارة للطلبات والمستخدمين
- نظام إشعارات بريدية
- سياسات نزاهة أكاديمية واضحة
