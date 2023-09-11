﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Core
{
    internal class Controller : IController
    {
        public Controller()
        {
            this.subjects = new SubjectRepository();
            this.students = new StudentRepository();
            this.universities = new UniversityRepository();
        }

        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;

        public string AddStudent(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            throw new NotImplementedException();
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            throw new NotImplementedException();
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            throw new NotImplementedException();
        }

        public string TakeExam(int studentId, int subjectId)
        {
            throw new NotImplementedException();
        }

        public string UniversityReport(int universityId)
        {
            throw new NotImplementedException();
        }
    }
}
