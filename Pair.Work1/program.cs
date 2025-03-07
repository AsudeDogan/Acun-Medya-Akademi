using System;
using System.Collections.Generic;
using System.Linq;

public class BaseClass
{
    public int Id { get; set; }
}

public class User : BaseClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(int id, string firstName, string lastName, string email, string password)
        : base()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
}

public class Student : User
{
    public Student(int id, string firstName, string lastName, string email, string password)
        : base(id, firstName, lastName, email, password)
    {
    }
}

public class StudentManager
{
    private List<Student> students = new List<Student>();

    // Add students
    public void Add(Student student)
    {
        if (student == null || string.IsNullOrEmpty(student.FirstName) || string.IsNullOrEmpty(student.LastName))
        {
            Console.WriteLine("Hata: Öğrenci bulunamadı.");
            return;
        }

        students.Add(student);
        Console.WriteLine($"{student.FirstName} {student.LastName} isimli öğrenci listeye başarıyla eklendi. ");
    }

    // List students
    public List<Student> GetList()
    {
        return students;
    }

    // Get student by ID
    public Student GetById(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            Console.WriteLine($"Hata: {id} numaralı öğrenci bulunamadı.");
            return null;
        }
        
        return student;
    }

    // Delete student
    public void Delete(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"{student.FirstName} {student.LastName} isimli öğrenci listeden başarıyla silindi. ");
        }
        else
        {
            Console.WriteLine($"Hata: {id} numaralı öğrenci bulunamadı.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        // Add new students
        studentManager.Add(new Student(1, "Asude", "Yılmaz", "asude@example.com", "password123"));
        studentManager.Add(new Student(2, "Ahmet", "Demir", "ahmet@example.com", "password456"));

        // List students
        var students = studentManager.GetList();
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, İsim: {student.FirstName} {student.LastName}, Email: {student.Email}");
        }

        // Search with student ID
        var studentById = studentManager.GetById(1);
        if (studentById != null)
        {
            Console.WriteLine($"Bulunan öğrenci: {studentById.FirstName} {studentById.LastName}");
        }

        // Delete student
        studentManager.Delete(1);
        Console.WriteLine("Güncel liste:");
        var studentsAfterDelete = studentManager.GetList();
        foreach (var student in studentsAfterDelete)
        {
            Console.WriteLine($"Id: {student.Id}, İsim: {student.FirstName} {student.LastName}, Email: {student.Email}");
        }
    }
}
