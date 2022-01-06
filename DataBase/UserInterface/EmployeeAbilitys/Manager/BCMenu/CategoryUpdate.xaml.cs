using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using System;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager.BCMenu
{
    /// <summary>
    /// Interaction logic for CategoryUpdate.xaml
    /// </summary>
    public partial class CategoryUpdate : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Categories _Category;
        public CategoryUpdate(UnitOfWork_Employee _Unit_Employee, Categories Category)
        {
            Unit_Employee = _Unit_Employee;
            _Category = Category;

            InitializeComponent();
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Category.Category_Name = Name.Text;
                _Category.Description = Description.Text;
                await Unit_Employee.category.Upsert(_Category);
                await Unit_Employee.CompleteAsync();
                MessageBox.Show("Category updated");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Description.Text = _Category.Description;
            Name.Text = _Category.Category_Name;
        }
    }
}
