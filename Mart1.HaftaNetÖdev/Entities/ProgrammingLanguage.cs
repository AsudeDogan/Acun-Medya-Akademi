using System.Collections.Generic;
using Mart1.HaftaNetOdev.Core;

namespace Mart1.HaftaNetOdev.Entities
{
    public class ProgrammingLanguage : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<Technology> Technologies { get; set; } = new List<Technology>();
    }
}