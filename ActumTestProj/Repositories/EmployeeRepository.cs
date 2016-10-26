using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ActumTestProj.Models;

namespace ActumTestProj
{
    class EmployeeRepository
    {
        private EmployeeContext context;

        public EmployeeRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return context.Employees.Find(id);
        }
        public Employee GetByName(string name)
        {
            return context.Employees.FirstOrDefault(x => x.Name == name);
        }

        public void Insert(Employee employee)
        {
            context.Employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
        }

        public void Update(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
