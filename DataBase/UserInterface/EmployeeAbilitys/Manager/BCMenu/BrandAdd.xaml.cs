using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using System;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager.BCMenu
{
    /// <summary>
    /// Interaction logic for BrandAdd.xaml
    /// </summary>
    public partial class BrandAdd : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Brands _Brand;
        public BrandAdd(UnitOfWork_Employee _Unit_Employee, Brands Category)
        {
            Unit_Employee = _Unit_Employee;
            _Brand = Category;

            InitializeComponent();
        }



        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Brand.Brand_Name = Name.Text;
                _Brand.Manufacturing_Country = Manufacturingcountry.Text;

                await Unit_Employee.brands.Add(_Brand);
                await Unit_Employee.CompleteAsync();
                MessageBox.Show("Brand added!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
