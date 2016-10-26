using ActumTestProj.Repositories;

namespace ActumTestProj
{
    class UnitOfWork
    {
        private EmployeeContext context = new EmployeeContext();
        
        private EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get { return _employeeRepository ?? (_employeeRepository = new EmployeeRepository(context)); }
        }

        private TrainingRepository _trainingRepository;
        public TrainingRepository TrainingRepository
        {
            get { return _trainingRepository ?? (_trainingRepository = new TrainingRepository(context)); }
        }

        private AttendanceRepository _attendanceRepository;
        public AttendanceRepository AttendanceRepository
        {
            get { return _attendanceRepository ?? (_attendanceRepository = new AttendanceRepository(context)); }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
