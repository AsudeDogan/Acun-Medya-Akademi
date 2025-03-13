using System;
using Mart1.HaftaNetOdev.Business;
using Mart1.HaftaNetOdev.DataAccess;
using Mart1.HaftaNetOdev.Entities;

namespace Mart1.HaftaNetOdev.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var languageRepo = new ProgrammingLanguageRepository();
            var languageManager = new ProgrammingLanguageManager(languageRepo);

            while (true)
            {
                Console.WriteLine("\n1- Programlama Dili Ekle");
                Console.WriteLine("2- Programlama Dillerini Listele");
                Console.WriteLine("3- Programlama Dili Sil");
                Console.WriteLine("0- Çıkış");
                Console.Write("Seçiminiz: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Programlama Dili Adı: ");
                        string name = Console.ReadLine();
                        ProgrammingLanguage language = new ProgrammingLanguage 
                        { 
                            Id = languageRepo.GetAll().Count + 1, 
                            Name = name 
                        };
                        languageManager.Add(language);
                        break;

                    case 2:
                        Console.WriteLine("\nProgramlama Dilleri:");
                        foreach (var lang in languageManager.GetAll())
                        {
                            Console.WriteLine($"ID: {lang.Id}, Ad: {lang.Name}");
                        }
                        break;

                    case 3:
                        Console.Write("Silmek istediğiniz ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        languageManager.Delete(id);
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }
    }
}
