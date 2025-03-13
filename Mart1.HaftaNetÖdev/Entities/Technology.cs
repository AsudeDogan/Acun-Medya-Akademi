using Mart1.HaftaNetOdev.Core;

namespace Mart1.HaftaNetOdev.Entities
{
    public class Technology : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage? ProgrammingLanguage { get; set; }  
    }
}