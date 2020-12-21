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
    /// Interaction logic for ATMWindow.xaml
    /// </summary>
    public partial class ATMWindow : Window
    {
        Employee employee;
        public ATMWindow(Employee employee)
        {
            InitializeComponent();
        }

        private void DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ATMDepositWindow();
            nextWindow.Show();
            this.Close();
        }

        private void TransferBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ATMTransferWindow(employee);
            nextWindow.Show();
            this.Close();
        }

        private void WithdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ATMWithdrawWindow();
            nextWindow.Show();
            this.Close();
        }

        private void PaymentsBtn_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ATMPaymentWindow();
            nextWindow.Show();
            this.Close();
        }
    }
}
