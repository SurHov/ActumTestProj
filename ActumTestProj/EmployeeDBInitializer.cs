using System.Data.Entity;

namespace ActumTestProj
{
    class EmployeeDBInitializer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            base.Seed(context);
        }
    }
}
