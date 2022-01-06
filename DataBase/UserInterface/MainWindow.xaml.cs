using System.Windows;
using Logic_Layer.DataAccess.Access;
using UserInterface.EmployeeAbilitys.Manager.Employeemenu;
using UserInterface.LogIn;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void EmployeeLogInButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeLogin employeeLogin = new();
            employeeLogin.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void costumersLogInButton_Click(object sender, RoutedEventArgs e)
        {
            costumersLogin costumersLogin = new();
            costumersLogin.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmpMenu empMenu = new EmpMenu(new UnitOfWork_Employee());
            empMenu.ShowDialog();
        }
    }
}
