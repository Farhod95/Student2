using Student2.Domain.Models;
using Student2.Infrastructure.Data;
using System.Collections.Immutable;

namespace Student2.Application.Service
{
    public class Student2Services
    {
        public DbContext _DbContext {  get; set; }
        public Student2Services()
        {
            this._DbContext = new DbContext();
        }

        public void AddStudent(string firstName, string lastName, string code, string email)
        {
            var myStudent = new Student 
            { 
                Id = RandomNumber(),
                FirstName = firstName,
                LastName = lastName,
                Code = code,
                Email = email
            };
            this._DbContext.Students.Add(myStudent);            
        }
        public string RandomNumber()
        {
            var birinchi = (char)new Random().Next('A', 'Z' + 1);
            var ikkinchi = (char)new Random().Next('A', 'Z' + 1);
            var uchinchi = new Random().Next(1000, 10000);
            return $"{birinchi}{ikkinchi}{uchinchi}";
        }

        public void GetAllStudents()
        {
            foreach(var student in this._DbContext.Students)
            {
                Console.WriteLine($" Id: {student.Id}, Ism: {student.FirstName}, Familiya: {student.LastName}, Code: {student.Code}, Email: {student.Email}");
            }
        }

        public void RemoveId(string id)
        {
            var ochirilganMiqdor = this._DbContext.Students.RemoveAll(x => x.Id == id);
            if (ochirilganMiqdor == 0)
            {
                Console.WriteLine($" {id} dagi student topilmadi !");
            }
            else
            {
                Console.WriteLine($"Siz kiritgan {id} bo'yicha: {ochirilganMiqdor} ta student o'chirildi");
            }

            foreach( var student in this._DbContext.Students)
            {
                Console.WriteLine($" Id: {student.Id}, Ism: {student.FirstName}, Familiya: {student.LastName}, Code: {student.Code}, Email: {student.Email}");
            }
        }

        public void QidirId(string id)
        {
            var myStudent = this._DbContext.Students.Where(x => x.Id == id).ToList();
            if (myStudent.Count == 0)
            {
                Console.WriteLine($" {id} dagi student topilmadi !");
            }
            else
            {
                Console.WriteLine($"Siz kiritgan {id} bo'yicha: {myStudent.Count} ta student topildi ! \n");
                foreach(var student in myStudent)
                {
                    Console.WriteLine($" Id: {student.Id}, Ism: {student.FirstName}, Familiya: {student.LastName}, Code: {student.Code}, Email: {student.Email}");
                }
            }
        }

        public void IsmBoyichaQidir(string text)
        {
            var myStudents = this._DbContext.Students.Where(x=>x.FirstName.ToLower().Contains(text.ToLower())).ToList();
            if (myStudents.Count == 0)
            {
                Console.WriteLine($" {text} dagi student topilmadi !");
            }
            else
            {
                Console.WriteLine($"Siz kiritgan {text} bo'yicha: {myStudents.Count} ta student topildi ! \n");
                foreach (var student in myStudents)
                {
                    Console.WriteLine($" Id: {student.Id}, Ism: {student.FirstName}, Familiya: {student.LastName}, Code: {student.Code}, Email: {student.Email}");
                }
            }
        }

        public void FamiliyaBoyichaQidir(string text)
        {
            var myStudents = this._DbContext.Students.Where(x => x.LastName.ToLower().Contains(text.ToLower())).ToList();
            if (myStudents.Count == 0)
            {
                Console.WriteLine($" {text} dagi student topilmadi !");
            }
            else
            {
                Console.WriteLine($"Siz kiritgan {text} bo'yicha: {myStudents.Count} ta student topildi ! \n");
                foreach (var student in myStudents)
                {
                    Console.WriteLine($" Id: {student.Id}, Ism: {student.FirstName}, Familiya: {student.LastName}, Code: {student.Code}, Email: {student.Email}");
                }
            }
        }

        public void UpdeteIsm(string id, string text)
        {
            this._DbContext.Students.Where(x=>x.Id==id).Select(x=>x.FirstName=text).ToList();
        }
        public void UpdeteFamiliya(string id, string text)
        {
            this._DbContext.Students.Where(x => x.Id == id).Select(x => x.LastName = text).ToList();
        }
        public void UpdeteCode(string id, string text)
        {
            this._DbContext.Students.Where(x => x.Id == id).Select(x => x.Code = text).ToList();
        }
        public void UpdeteEmail(string id, string text)
        {
            this._DbContext.Students.Where(x => x.Id == id).Select(x => x.Email = text).ToList();
        }

        public void FaqatIsmChiqadi()
        {
            var myStudentsNameSort = this._DbContext.Students.Select(x=>x.FirstName).ToList();
            myStudentsNameSort.Sort();
            foreach (var student in myStudentsNameSort)
            {
                Console.WriteLine($"Ism: {student}");
            }
        }
    }
}
