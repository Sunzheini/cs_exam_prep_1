using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    internal class UniversityRepository : IRepository<IUniversity>
    {
        public UniversityRepository()
        {
            this.models = new List<IUniversity>();
        }

        private List<IUniversity> models;
        public IReadOnlyCollection<IUniversity> Models
        {
            get { return this.models.AsReadOnly(); }
        }

        public void AddModel(IUniversity model)
        {
            this.models.Add(model);
        }

        public IUniversity FindById(int id)
        {
            return models.FirstOrDefault(s => s.Id == id);
        }

        public IUniversity FindByName(string name)
        {
            return models.FirstOrDefault(s => s.Name == name);
        }
    }
}
