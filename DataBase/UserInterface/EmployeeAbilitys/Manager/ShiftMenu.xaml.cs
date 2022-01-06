using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using System;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for ShiftMenu.xaml
    /// </summary>
    public partial class ShiftMenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Employees _employee;
        public ShiftMenu(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            _employee = employee;

        }



        private async void ShowToday_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date == DateTime.Today && i.Shift_End==null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.Today : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? dateTimestart : EndDate.SelectedDate.Value;
                if (ById.Text != string.Empty)
                {

                    ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date >= dateTimestart && i.Shift_End <= dateTimeend && i.Employee_ID == int.Parse(ById.Text));

                }
                else
                {
                    ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date >= dateTimestart && i.Shift_End <= dateTimeend);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Employeeinfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                PersonalInfoEdit_Employee PE = new(Unit_Employee, await Unit_Employee.employee.GetById((ShiftShow.SelectedItem as Shifts).Employee_ID));
                PE.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
