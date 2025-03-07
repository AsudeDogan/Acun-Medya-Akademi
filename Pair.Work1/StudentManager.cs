public class StudentManager
{
    private List<Student> students = new List<Student>();

    // Öğrenci ekleme
    public void Add(Student student)
    {
        if (student == null || string.IsNullOrEmpty(student.FirstName) || string.IsNullOrEmpty(student.LastName))
        {
            Console.WriteLine("Hata: Öğrenci bulunamadı.");
            return;
        }

        students.Add(student);
        Console.WriteLine($"{student.FirstName} {student.LastName} isimli öğrenci listeye başarıyla eklendi.");
    }

    // Öğrencileri listeleme
    public List<Student> GetList()
    {
        return students; // Öğrencilerin listesini döndürme
    }

    // ID ile öğrenci arama
    public Student GetById(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            Console.WriteLine($"Hata: {id} numaralı öğrenci bulunamadı.");
            return null; // Öğrenci bulunamazsa null döndür
        }

        return student; // Öğrenciyi döndür
    }

    // Öğrenci silme
    public void Delete(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"{student.FirstName} {student.LastName} isimli öğrenci listeden başarıyla silindi.");
        }
        else
        {
            Console.WriteLine($"Hata: {id} numaralı öğrenci bulunamadı.");
        }
    }
}