using System.Data.Entity;
using ActumTestProj.Models;

namespace ActumTestProj
{
    class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Аttendance> Attendances { get; set; }
    }
}
