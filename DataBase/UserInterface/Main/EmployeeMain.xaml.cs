using Logic_Layer.DataAccess.Access;
using System;
using System.Linq;
using System.Windows;
using DataBase.Models;
using UserInterface.EmployeeAbilitys;
using UserInterface.EmployeeAbilitys.Employee;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for EmployeeMain.xaml
    /// </summary>
    public partial class EmployeeMain : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Employees ME;

        public EmployeeMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            ME = employee;
        }
        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {

            HelloBox.Text = $"Hello {ME.First_Name}";
            await Unit_Employee.shifts.NewShiftAsync(ME.ID);
            await Unit_Employee.CompleteAsync();
        }

        private  void GetShifts_Click(object sender, RoutedEventArgs e)
        {
            Shiftdata.ItemsSource = ME.Shifts.ToList().Where(i=>i.Shift_Start.Month==DateTime.Today.Month);
        }

        

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            await Unit_Employee.shifts.UpdateLastShiftAsync(ME.ID);
            await Unit_Employee.CompleteAsync();
            Close();
        }

        private void EditInfo_Click(object sender, RoutedEventArgs e)
        {
            PersonalInfoEdit_Employee personalInfo = new(Unit_Employee, ME);
            personalInfo.ShowDialog();
        }

        private  void NextOrder_Click(object sender, RoutedEventArgs e)
        {
            EDIAccept eDIAccept = new(Unit_Employee,ME);
            eDIAccept.ShowDialog();
        }
    }
}
