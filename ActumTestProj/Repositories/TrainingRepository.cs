using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ActumTestProj.Models;

namespace ActumTestProj.Repositories
{
    class TrainingRepository
    {
        private EmployeeContext context;

        public TrainingRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Training> GetAll()
        {
            return context.Trainings.ToList();
        }

        public Training GetById(int id)
        {
            return context.Trainings.Find(id);
        }

        public Training GetByName(string name)
        {
            return context.Trainings.FirstOrDefault(t => t.Name == name);
        }

        public void Insert(Training training)
        {
            context.Trainings.Add(training);
        }

        public void Delete(int id)
        {
            Training training = context.Trainings.Find(id);
            context.Trainings.Remove(training);
        }

        public void Update(Training training)
        {
            context.Entry(training).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
