using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActumTestProj.Models;

namespace ActumTestProj
{
    public partial class Form1 : Form
    {
        private UnitOfWork _unitOfWork;

        public Form1()
        {
            var dbInitContext = new EmployeeContext();
            dbInitContext.Database.Initialize(true);
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void BtnSaveTraining_Click(object sender, EventArgs e)
        {
            var training = new Training
            {
                Name = trainName.Text,
                Description = trainDesc.Text
            };

            _unitOfWork.TrainingRepository.Insert(training);
            _unitOfWork.Save();

            trainName.Clear();
            trainDesc.Clear();
        }

        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Name = empName.Text,
                Surname = empSurname.Text,
                BirthDate = empBrtDate.Value
            };

            _unitOfWork.EmployeeRepository.Insert(employee);
            _unitOfWork.Save();

            empName.Clear();
            empSurname.Clear();
        }

        private void trainingsCmb_DropDown(object sender, EventArgs e)
        {
            trainingsCmb.Items.Clear();
            var allTrainings = _unitOfWork.TrainingRepository.GetAll();
            foreach (var training in allTrainings)
                trainingsCmb.Items.Add(training.Name);
        }

        private void employeeCmb_DropDown(object sender, EventArgs e)
        {
            employeeCmb.Items.Clear();
            var allEmployees = _unitOfWork.EmployeeRepository.GetAll();
            foreach (var employee in allEmployees)
                employeeCmb.Items.Add(employee.Name);
        }

        private void btnSaveAttend_Click(object sender, EventArgs e)
        {
            var training = _unitOfWork.TrainingRepository.GetByName(trainingsCmb.Text);
            var employee = _unitOfWork.EmployeeRepository.GetByName(employeeCmb.Text);

            var attendance = new Аttendance
            {
                Employee = employee,
                Training = training,
                VisitDate = visitDate.Value
            };

            _unitOfWork.AttendanceRepository.Insert(attendance);
            _unitOfWork.Save();
        }

        private void employeeCmb2_DropDown(object sender, EventArgs e)
        {
            employeeCmb2.Items.Clear();
            var allEmployees = _unitOfWork.EmployeeRepository.GetAll();
            foreach (var employee in allEmployees)
                employeeCmb2.Items.Add(employee.Name);
        }

        private void btnGetTrainings_Click(object sender, EventArgs e)
        {
            var employee = _unitOfWork.EmployeeRepository.GetByName(employeeCmb2.Text);

            var аttendances = _unitOfWork.AttendanceRepository.GetLatestTrainings(employee);

            string message = String.Empty;

            foreach (var att in аttendances)
            {
                message += att.Training.Name + "       " + att.VisitDate.ToShortDateString() + "\n";
            }

            MessageBox.Show(message);
        }


        #region Buttons Enable/Disable

        private void trainName_TextChanged(object sender, EventArgs e)
        {
            EnableTrainingSave();
        }

        private void trainDesc_TextChanged(object sender, EventArgs e)
        {
            EnableTrainingSave();
        }

        private void EnableTrainingSave()
        {
            if (trainName.Text != String.Empty && trainDesc.Text != String.Empty)
                btnSaveTraining.Enabled = true;
            else
                btnSaveTraining.Enabled = false;
        }

        private void empName_TextChanged(object sender, EventArgs e)
        {
            EnableEmployeeSave();
        }

        private void empSurname_TextChanged(object sender, EventArgs e)
        {
            EnableEmployeeSave();
        }

        private void EnableEmployeeSave()
        {
            if (empName.Text != String.Empty && empSurname.Text != String.Empty)
                btnSaveEmployee.Enabled = true;
            else
                btnSaveEmployee.Enabled = false;
        }

        private void employeeCmb_TextChanged(object sender, EventArgs e)
        {
            EnableAttendanceSave();
        }

        private void trainingsCmb_TextChanged(object sender, EventArgs e)
        {
            EnableAttendanceSave();
        }

        private void EnableAttendanceSave()
        {
            if (trainingsCmb.Text != String.Empty && employeeCmb.Text != String.Empty)
                btnSaveAttend.Enabled = true;
            else
                btnSaveAttend.Enabled = false;
        }

        private void employeeCmb2_TextChanged(object sender, EventArgs e)
        {
            btnGetTrainings.Enabled = employeeCmb2.Text != String.Empty;
        }

        #endregion
    }
}
