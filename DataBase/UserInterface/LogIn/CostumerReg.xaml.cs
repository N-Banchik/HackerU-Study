using Logic_Layer.Log_in;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace UserInterface.LogIn
{
    /// <summary>
    /// Interaction logic for costumersReg.xaml
    /// </summary>
    public partial class costumersReg : Window
    {
        private LogIn_costumers log = new LogIn_costumers();
        public costumersReg()
        {
            InitializeComponent();

        }


        private async void submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (await log.ChackIfExsistsAsync(Email.Text))
                {
                    MessageBox.Show("costumers already exists with this Email");

                }
                else
                {
                    if (Password.Password.Length < 8 || Password.Password.Length > 12)
                    {
                        MessageBox.Show("Password Must be between 8-12 characters! ");
                        Password.Clear();
                        return;
                    }
                    foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
                    {
                        if (Tbox.Text == string.Empty)
                        {
                            MessageBox.Show("Cannot leave empty fields!");
                            return;
                        }
                        if (Tbox.Name.ToString() == "APT" || Tbox.Name.ToString() == "Housenumber" || Tbox.Name.ToString() == "Zip")
                        {
                            if (!int.TryParse(Tbox.Text, out int num))
                            {
                                switch (Tbox.Name)
                                {
                                    case "APT":
                                        MessageBox.Show("Apartment Must be a number!");
                                        return;
                                    case "Housenumber":
                                        MessageBox.Show("House number Must be a number!");
                                        return;
                                    case "Zip":
                                        MessageBox.Show("Zipcode Must be a number!");
                                        return;

                                }
                            }
                        }
                    }
                    await log.RegistarAsync(Streetname.Text, int.Parse(Housenumber.Text), int.Parse(APT.Text), int.Parse(Zip.Text), City.Text, Firstname.Text, Lastname.Text, Bdate.SelectedDate.Value.Date, Password.Password, Phonenumber.Text, false, Email.Text);
                    MessageBox.Show($"User Created! Please log in now", "Congratulation", MessageBoxButton.OK);
                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
