public class Instructor : User
{
    public string Department { get; set; }

    // Constructor
    public Instructor(int id, string firstName, string lastName, string email, string password, string department)
        : base(id, firstName, lastName, email, password) // User constructor'ı çağrıldı
    {
        Department = department;
    }
}