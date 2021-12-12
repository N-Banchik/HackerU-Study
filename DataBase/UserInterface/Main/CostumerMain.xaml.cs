using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using UserInterface.UserAbilitys;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for customersMain.xaml
    /// </summary>
    public partial class customersMain : Window
    {
        private customerss ME;
        private UnitOfWork_customers unitOfWork_;
        public customersMain(UnitOfWork_customers unit, customerss customerss)
        {
            InitializeComponent();
            ME = customerss;
            unitOfWork_ = unit;
        }

        private void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {
            HelloBox.Text = $"Hello {ME.First_Name + " " + ME.last_Name}";
        }

        private void Neworder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry :( not implemented ");

        }

        private void Showorders_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MessageBox.Show("Sorry :( not implemented ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private  void Editpersonaldata_Click(object sender, RoutedEventArgs e)
        {

            PersonalInfoUpdate_customers personalInfoUpdate_ = new(unitOfWork_,ME);
            personalInfoUpdate_.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you come again");
            Close();
        }
    }
}
