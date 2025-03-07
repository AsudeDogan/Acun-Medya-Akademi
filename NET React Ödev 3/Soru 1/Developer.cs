namespace Question1;

public class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.1; // %10 prim 
    }
}
