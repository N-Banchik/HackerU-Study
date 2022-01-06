using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        List<Address_costumers> _Address_costumers;
        List<costumers> _costumers;
        public UserMenu(UnitOfWork_Employee Employee)
        {
            Unit_Employee = Employee;
            InitializeComponent();
        }


        private void UserOrders_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private async void ShowUers_Click(object sender, RoutedEventArgs e)
        {
            _Address_costumers = (List<Address_costumers>)await Unit_Employee.addresscostumers.GetAllAsync();
            _costumers = (List<costumers>)await Unit_Employee.costumers.GetAllAsync();
            if (IDBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.costumers_ID == int.Parse(IDBox.Text));
                IDBox.Clear();
            }
            else if (NameBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.First_Name.Contains(NameBox.Text) || i.last_Name.Contains(NameBox.Text));
                NameBox.Clear();
            }
            else if (Phonebox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.Phone_Number == Phonebox.Text);
                Phonebox.Clear();
            }
            else if (EmailBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.Email == EmailBox.Text);
                EmailBox.Clear();
            }
            else
            {
                UserShow.ItemsSource = _costumers;

            }


        }
    }
}
