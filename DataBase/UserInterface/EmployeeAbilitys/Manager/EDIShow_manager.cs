using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Access;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for EDIShow_manager.xaml
    /// </summary>
    public partial class EDIShow_manager : Window
    {
        private UnitOfWork_Employee unit;
        private EDI _EDI;

        public EDIShow_manager(UnitOfWork_Employee _unit, EDI edi)
        {
            unit = _unit;
            _EDI = edi;
            InitializeComponent();
            ContentRendered += Showitems;

        }

        private void Showitems(object sender, EventArgs e)
        {
            ObservableCollection<EDIItems> itm = new ObservableCollection<EDIItems>(_EDI.Items.ToList());
            ItemsShow.ItemsSource =itm;

        }
    }
}
