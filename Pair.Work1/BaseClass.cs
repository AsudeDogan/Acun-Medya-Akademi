﻿public class BaseClass
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Constructor 
    public BaseClass(int id, string firstName, string lastName, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
}
