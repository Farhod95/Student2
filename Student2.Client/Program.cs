using Student2.Application.Service;
using static System.Net.Mime.MediaTypeNames;

namespace Student2.Client
{
    internal class Program
    {
        public Student2Services myNewStudent {  get; set; }
        public Program()
        {
            this.myNewStudent = new Student2Services();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Xush kelibsiz !");

            var program = new Program();
            program.Run();
        }

        public void Run()
        {
            bool savol = false;
            while (!savol) 
            {
                savol = true;
                Console.WriteLine("\n Qaysi amalni bajarmoqchisiz? \n");
                Console.WriteLine(" 1. Student qo'shish");
                Console.WriteLine(" 2. Studentlar ro'yxatini chiqarish");
                Console.WriteLine(" 3. Studentlarni Id boyicha o'chirish");
                Console.WriteLine(" 4. Studentlarni Id bo'yicha qidirish");
                Console.WriteLine(" 5. Studentlarni Ism bo'yicha qidirish");
                Console.WriteLine(" 6. Studentlarni Familiya bo'yicha qidirish");
                Console.WriteLine(" 7. Studentlarni ma'lum bir qiymatini o'zgartrish");
                Console.WriteLine(" 8. Studentlarni faqat ismilarini alifno tartibida chiqarish");
                Console.WriteLine();
                Console.Write(" Kerakli amalni kiriting:");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            StudentQosh();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }                              
                        }
                    case "2":
                        {
                            myNewStudent.GetAllStudents();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "3":
                        {
                            StudentOchirish();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "4":
                        {
                            StudentIdQidir();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "5":
                        {
                            StudentIsmQidir();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "6":
                        {
                            StudentFamiliyaQidir();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "7":
                        {
                            MalumBirQiymatOzgartr();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "8":
                        {
                            myNewStudent.FaqatIsmChiqadi();
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    default:
                        {
                            Console.WriteLine(" Noto'g'ri amalni kiritdingiz !");
                            if (QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                }
            }            
        }
        public void StudentQosh()
        {
            Console.Write(" Student ism: "); 
            var ism = Console.ReadLine();
            Console.Write(" Student familiya: "); 
            var familiya = Console.ReadLine();
            Console.Write(" Student code: "); 
            var code = Console.ReadLine();
            Console.Write(" Student email "); 
            var email = Console.ReadLine();
            myNewStudent.AddStudent(ism, familiya, code, email);
            Console.WriteLine("\n Student muvfaqiyatli qo'shildi ! \n");
        }
        public void StudentOchirish()
        {
            Console.Write(" Ochirish kerak bolgan student Id kiriting: ");
            var id = Console.ReadLine();

            myNewStudent.RemoveId(id);
        }

        public void StudentIdQidir()
        {
            Console.Write(" Qidirayotgan student Id kiriting: ");
            var id = Console.ReadLine();

            myNewStudent.QidirId(id);
        }
        public void StudentIsmQidir()
        {
            Console.Write(" Qidirayotgan student ismini kiriting: ");
            var text = Console.ReadLine();

            myNewStudent.IsmBoyichaQidir(text);
        }
        public void StudentFamiliyaQidir()
        {
            Console.Write(" Qidirayotgan student familiyasini kiriting: ");
            var text = Console.ReadLine();

            myNewStudent.FamiliyaBoyichaQidir(text);
        }
        public bool QaytaIshgaTushir()
        {
            Console.Write("\n Dasturni qayta ishga tushirishni istaysimi ? (yes/no) :");
            return Console.ReadLine().ToLower() == "yes";
        }

        public void MalumBirQiymatOzgartr()
        {
            Console.WriteLine("\n 1. Student ismmini o'zgartrish");
            Console.WriteLine(" 2. Student familiyasini o'zgartrish");
            Console.WriteLine(" 3. Student codini o'zgartrish");
            Console.WriteLine(" 4. Student emailini o'zgartrish");
            Console.WriteLine();
            Console.Write(" Studentning qaysi ma'lumotini o'zgartrmoqchi ekanizni kiriting:");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        QiymatOzgartrMalumotlarIsm();
                        break;
                    }
                case "2":
                    {
                        QiymatOzgartrMalumotlarFamiliya();
                        break;
                    }
                case "3":
                    {
                        QiymatOzgartrMalumotlarCode();
                        break;
                    }
                case "4":
                    {
                        QiymatOzgartrMalumotlarEmail();
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" Noto'g'ri amal kiritdingiz !");
                        break;
                    }
            }
        }
        public void QiymatOzgartrMalumotlarIsm()
        {
            Console.Write($" Qiymatini o'zgartrmoqchi bolgan student id sini kiriting: ");
            var id = Console.ReadLine();
            Console.Write($" O'zgarishi kerak ismni kiriting: ");
            var text = Console.ReadLine();
            myNewStudent.UpdeteIsm(id, text);
        }
        public void QiymatOzgartrMalumotlarFamiliya()
        {
            Console.Write($" Qiymatini o'zgartrmoqchi bolgan student id sini kiriting: ");
            var id = Console.ReadLine();
            Console.Write($" O'zgarishi kerak familiyani kiriting: ");
            var text = Console.ReadLine();
            myNewStudent.UpdeteFamiliya(id, text);
        }
        public void QiymatOzgartrMalumotlarCode()
        {
            Console.Write($" Qiymatini o'zgartrmoqchi bolgan student id sini kiriting: ");
            var id = Console.ReadLine();
            Console.Write($" O'zgarishi kerak code ni kiriting: ");
            var text = Console.ReadLine();
            myNewStudent.UpdeteCode(id, text);
        }
        public void QiymatOzgartrMalumotlarEmail()
        {
            Console.Write($" Qiymatini o'zgartrmoqchi bolgan student id sini kiriting: ");
            var id = Console.ReadLine();
            Console.Write($" O'zgarishi kerak Email ni kiriting: ");
            var text = Console.ReadLine();
            myNewStudent.UpdeteEmail(id, text);
        }
    }
}
