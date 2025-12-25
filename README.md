# 🎓 Student Management Console Application

## 🌟 Loyihaning maqsadi
Ushbu loyiha **C# va LINQ** yordamida studentlar bilan ishlashni osonlashtiradi.  
Dastur quyidagi imkoniyatlarni taqdim etadi:

- Student qo‘shish  
- Studentlar ro‘yxatini chiqarish  
- Studentlarni **ID** bo‘yicha o‘chirish  
- Studentlarni **ID, Ism yoki Familiya** bo‘yicha qidirish  
- Studentlarning ma’lum bir qiymatini yangilash (**Ism, Familiya, Code, Email**)  
- Studentlarni faqat **ismlarini alifbo tartibida** chiqarish  

---

## ⚡ Texnologiyalar
- C# 10 / .NET 6+  
- LINQ  
- Console Application  
- Object-Oriented Programming (OOP)

---

## 🧩 Loyihaning strukturası

### 1️⃣ Domain Layer (`Student2.Domain.Models`)
```csharp
public class Student
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Code { get; set; }
    public string Email { get; set; }
}
