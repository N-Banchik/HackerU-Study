using System;
using System.Windows;
using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using UserInterface.UserAbilitys;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for costumersMain.xaml
    /// </summary>
    public partial class costumersMain : Window
    {
        private costumers ME;
        private UnitOfWork_costumers unitOfWork_;
        public costumersMain(UnitOfWork_costumers unit, costumers costumers)
        {
            InitializeComponent();
            ME = costumers;
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

            PersonalInfoUpdate_costumers personalInfoUpdate_ = new(unitOfWork_,ME);
            personalInfoUpdate_.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you come again");
            Close();
        }
    }
}
