using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    internal class SubjectRepository : IRepository<ISubject>
    {
        public SubjectRepository()
        {
            this.models = new List<ISubject>();
        }

        private List<ISubject> models;
        public IReadOnlyCollection<ISubject> Models
        {
            get { return this.models.AsReadOnly(); }
        }

        public void AddModel(ISubject model)
        {
            this.models.Add(model);
        }

        public ISubject FindById(int id)
        {
            return models.FirstOrDefault(s => s.Id == id);
        }

        public ISubject FindByName(string name)
        {
            return models.FirstOrDefault(s => s.Name == name);
        }
    }
}
