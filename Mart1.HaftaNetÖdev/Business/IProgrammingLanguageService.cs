using System.Collections.Generic;
using Mart1.HaftaNetOdev.Entities;

namespace Mart1.HaftaNetOdev.Business
{
    public interface IProgrammingLanguageService
    {
        void Add(ProgrammingLanguage language);
        List<ProgrammingLanguage> GetAll();
        void Delete(int id);
    }
}