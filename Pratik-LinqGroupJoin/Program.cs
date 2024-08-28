// Örnek öğrenci listesi oluşturma
using Pratik_LinqGroupJoin;

List<Student> students = new List<Student>()
            {
                new Student(1, "Ali", 1),
                new Student(2, "Ayşe", 2),
                new Student(3, "Mehmet", 1),
                new Student(4, "Fatma", 3),
                new Student(5, "Ahmet", 2)
            };

// Örnek sınıf listesi oluşturma
List<Class> classes = new List<Class>()
            {
                new Class(1, "Matematik"),
                new Class(2, "Türkçe"),
                new Class(3, "Kimya")
            };

// LINQ Group Join sorgusu
var result = classes.GroupJoin(
    students,
    c => c.ClassId,
    s => s.ClassId,
    (c, studentGroup) => new
    {
        Class = c,
        Students = studentGroup.ToList()
    }
);

// Sonuçları yazdırma
foreach (var item in result)
{
    Console.WriteLine($"Sınıf: {item.Class.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  Öğrenci: {student.StudentName}");
    }
    Console.WriteLine(); // Sınıflar arasında boş satır
}