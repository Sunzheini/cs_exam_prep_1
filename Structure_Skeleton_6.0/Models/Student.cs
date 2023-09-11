using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public abstract class Student : IStudent
    {
        public Student(int studentId, string firstName, string lastName)
        {
            this.Id = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;

            this.coveredExams = new List<int>();
        }

        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                firstName = value; 
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set 
            { 
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                lastName = value;
            }
        }

        private List<int> coveredExams;

        public IReadOnlyCollection<int> CoveredExams
        {
              get { return coveredExams.AsReadOnly(); }
        }

        private IUniversity university;

        public IUniversity University
        {
            get { return university; }
        }

        public void CoverExam(ISubject subject)
        {
            coveredExams.Add(subject.Id);
        }

        public void JoinUniversity(IUniversity university)
        {
            this.university = university;
        }
    }
}
