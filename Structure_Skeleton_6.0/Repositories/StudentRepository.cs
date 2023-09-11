using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    internal class StudentRepository : IRepository<IStudent>
    {
        public StudentRepository()
        {
            this.models = new List<IStudent>();
        }

        private List<IStudent> models;
        public IReadOnlyCollection<IStudent> Models
        {
            get { return this.models.AsReadOnly(); }
        }

        public void AddModel(IStudent model)
        {
            this.models.Add(model);
        }

        public IStudent FindById(int id)
        {
            return models.FirstOrDefault(s => s.Id == id);
        }

        public IStudent FindByName(string name)
        {
            string firstName = name.Split()[0];
            string lastName = name.Split()[1];

            return models.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
