namespace soru2;

using System;

public interface IReadable
{
    void Read();  
}

public class Book : IReadable
{
    public void Read() 
    
    {
        Console.WriteLine("Reading a book.");
    }
}

public class Newspaper : IReadable
{
    public void Read()  
    {
        Console.WriteLine("Reading a newspaper.");
    }
}

class Program
{
    static void Main()
    {
        IReadable book = new Book();
        book.Read();

        IReadable newspaper = new Newspaper();
        newspaper.Read();
    }
}
