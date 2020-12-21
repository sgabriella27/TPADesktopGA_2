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

namespace TPADestop_GA20_2_
{
    /// <summary>
    /// Interaction logic for TellerWindow.xaml
    /// </summary>
    public partial class TellerWindow : Window
    {

        Employee employee;
        public TellerWindow(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new DepositMoney();
            nextWindow.Show();
            this.Close();
        }

        private void TransferBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new TransferMoney(employee);
            nextWindow.Show();
            this.Close();
        }

        private void WithdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new WithdrawMoney();
            nextWindow.Show();
            this.Close();
        }

        private void PaymentsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
