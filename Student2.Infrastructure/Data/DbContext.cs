using Student2.Domain.Models;

namespace Student2.Infrastructure.Data
{
    public class DbContext
    {
        public List<Student> Students { get; set; }
        public DbContext()
        {
            this.Students = new List<Student>();

            Students.Add(new Student { Id = "AA1000", FirstName = "Mohinur", LastName = "Muhammadjonova", Code = "2965", Email = "mohinur29650@gmail.com" });
            Students.Add(new Student { Id = "AA1001", FirstName = "Eldor", LastName = "Ro'ziyev", Code = "1244", Email = "eldor1244@gmail.com" });
            Students.Add(new Student { Id = "AA1002", FirstName = "Jamshidbek", LastName = "Aliyev", Code = "1471", Email = "jamshidbek1471@gmail.com" });
            Students.Add(new Student { Id = "AA1003", FirstName = "Durbek", LastName = "Kanalbeov", Code = "5945", Email = "durbek5945@gmail.com" });
            Students.Add(new Student { Id = "AA1004", FirstName = "Asrorbek", LastName = "Abdurashidov", Code = "9235", Email = "asrorbek9235@gmail.com" });
            Students.Add(new Student { Id = "AA1005", FirstName = "Siddiqjon", LastName = "No'monjonov", Code = "1648", Email = "siddiqjon1648@gmail.com" });
            Students.Add(new Student { Id = "AA1006", FirstName = "Dostonbek", LastName = "Yakubov", Code = "4395", Email = "dostonbek4395@gmail.com" });
            Students.Add(new Student { Id = "AA1007", FirstName = "Farhod", LastName = "Isomiddinov", Code = "1110", Email = "farhod1110@gmail.com" });
            Students.Add(new Student { Id = "AA1008", FirstName = "Muhammad Bilol", LastName = "Umarov", Code = "5674", Email = "bilol5674@gmail.com" });
            Students.Add(new Student { Id = "AA1009", FirstName = "Nazarbek", LastName = "Jabborov", Code = "7035", Email = "nazarbek7035@gmail.com" });
            Students.Add(new Student { Id = "AA1010", FirstName = "Azimjon", LastName = "Ergashev", Code = "8747", Email = "azimjon8747@gmail.com" });
            Students.Add(new Student { Id = "AA1011", FirstName = "Sevinch", LastName = "Umirzoqova", Code = "8200", Email = "sevinch8200@gmail.com" });
        }
    }
}