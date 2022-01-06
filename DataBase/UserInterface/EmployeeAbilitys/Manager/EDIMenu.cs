using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using System;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager
{

    public partial class EDIMenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        public EDIMenu(UnitOfWork_Employee UoWemployee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.Today : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? EndDate.SelectedDate = DateTime.Today : EndDate.SelectedDate.Value;
               

                if (EDIid.Text != string.Empty)
                {
                    EDIShow.ItemsSource = await Unit_Employee.EDI.GetByCondition(i=>i.EDI_Id==int.Parse(EDIid.Text));
                }
                else
                {
                    EDIShow.ItemsSource = await Unit_Employee.EDI.GetbyDateAsync(dateTimestart.Value, dateTimeend.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void NotApprovedEDI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EDIShow.ItemsSource = await Unit_Employee.EDI.GetAllNotapprovedAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void ShowEDIDetails_Click(object sender, RoutedEventArgs e)
        {
            EDIShow_manager EDIShow_Manager = new(Unit_Employee,EDIShow.SelectedItem as EDI);
            EDIShow_Manager.ShowDialog();
        }

    }
}
