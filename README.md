# 📝 Student Names Console Project

## 🌟 Loyihaning maqsadi
Ushbu loyiha **C# va LINQ** yordamida studentlar ro‘yxatidan faqat **ism** maydonini chiqarish va natijani **console** orqali ko‘rsatishga mo‘ljallangan.

---

## ⚡ Texnologiyalar
- C# 10 / .NET 6+
- LINQ
- Console Application

---

## 🧩 Asosiy Kod

```csharp
public void FaqatIsmChiqadi()
{
    // 1️⃣ Faqat studentlar ismlarini olish
    var myStudentsName  = this._DbContext.Students
        .Select(x => x.FirstName) // Select orqali faqat FirstName olinadi
        .ToList();                // Natija List<string> ga aylanadi

    // 2️⃣ Console ga chiqarish
    foreach (var student in myStudentsName)
    {
        Console.WriteLine($"Ism: {student}");
    }
}
