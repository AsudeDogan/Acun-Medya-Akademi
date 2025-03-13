using System;
using System.Collections.Generic;
using System.Linq;
using Mart1.HaftaNetOdev.Core;
using Mart1.HaftaNetOdev.Entities;

namespace Mart1.HaftaNetOdev.DataAccess
{
    public class TechnologyRepository : IRepository<Technology>
    {
        private List<Technology> _technologies = new List<Technology>();

        public void Add(Technology entity)
        {
            _technologies.Add(entity);
            Console.WriteLine($"Teknoloji eklendi: {entity.Name}");
        }

        public List<Technology> GetAll()
        {
            return _technologies;
        }

        public Technology? GetById(int id)
        {
            return _technologies.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Technology entity)
        {
            var tech = GetById(entity.Id);
            if (tech != null)
            {
                tech.Name = entity.Name;
                Console.WriteLine($"Teknoloji güncellendi: {entity.Name}");
            }
        }

        public void Delete(int id)  
        {
            var tech = GetById(id);
            if (tech != null)
            {
                _technologies.Remove(tech);
                Console.WriteLine($"Teknoloji silindi: {tech.Name}");
            }
        }
    }
}