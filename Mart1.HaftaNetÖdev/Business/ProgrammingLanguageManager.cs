using System.Collections.Generic;
using Mart1.HaftaNetOdev.Core;
using Mart1.HaftaNetOdev.Entities;

namespace Mart1.HaftaNetOdev.Business
{
    public class ProgrammingLanguageManager : IProgrammingLanguageService
    {
        private readonly IRepository<ProgrammingLanguage> _repository;

        public ProgrammingLanguageManager(IRepository<ProgrammingLanguage> repository)
        {
            _repository = repository;
        }

        public void Add(ProgrammingLanguage language)
        {
            _repository.Add(language);
        }

        public List<ProgrammingLanguage> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(int id)  
        {
            _repository.Delete(id);
        }
    }
}