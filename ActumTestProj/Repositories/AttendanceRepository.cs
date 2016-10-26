using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ActumTestProj.Models;

namespace ActumTestProj.Repositories
{
    class AttendanceRepository
    {
        private EmployeeContext context;

        public AttendanceRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Аttendance> GetAll()
        {
            return context.Attendances.ToList();
        }

        public Аttendance GetById(int id)
        {
            return context.Attendances.Find(id);
        }

        public void Insert(Аttendance аttendance)
        {
            context.Attendances.Add(аttendance);
        }

        public void Update(Аttendance аttendance)
        {
            context.Entry(аttendance).State = EntityState.Modified;
        }

        public IQueryable<Аttendance> GetLatestTrainings(Employee epmloyee)
        {
            return context.Attendances.Include(x => x.Training).AsQueryable().Where(x => x.Employee.EmployeeId == epmloyee.EmployeeId).OrderBy(x => x.VisitDate);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
