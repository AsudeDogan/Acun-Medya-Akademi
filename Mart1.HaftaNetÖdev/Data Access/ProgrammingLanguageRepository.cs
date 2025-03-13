using System;
using System.Collections.Generic;
using System.Linq;
using Mart1.HaftaNetOdev.Core;
using Mart1.HaftaNetOdev.Entities;

namespace Mart1.HaftaNetOdev.DataAccess
{
    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        private List<ProgrammingLanguage> _programmingLanguages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage entity)
        {
            _programmingLanguages.Add(entity);
            Console.WriteLine($"Programlama dili eklendi: {entity.Name}");
        }

        public List<ProgrammingLanguage> GetAll()
        {
            return _programmingLanguages;
        }

        public ProgrammingLanguage? GetById(int id)
        {
            return _programmingLanguages.FirstOrDefault(pl => pl.Id == id);
        }

        public void Update(ProgrammingLanguage entity)
        {
            var language = GetById(entity.Id);
            if (language != null)
            {
                language.Name = entity.Name;
                Console.WriteLine($"Programlama dili güncellendi: {entity.Name}");
            }
        }

        public void Delete(int id)  
        {
            var language = GetById(id);
            if (language != null)
            {
                _programmingLanguages.Remove(language);
                Console.WriteLine($"Programlama dili silindi: {language.Name}");
            }
        }
    }
}