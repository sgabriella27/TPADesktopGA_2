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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        controllerBills bills = new controllerBills();
        public Payment()
        {
            InitializeComponent();
            DataGridBills.ItemsSource = bills.getBills();
        }

        private void PaymentBtn_Click(object sender, RoutedEventArgs e)
        {
            bills.update(txtBillsID.Text, txtAmountMoney.Text);
            bills.deleteBills();
            bills = new controllerBills();
            DataGridBills.ItemsSource = bills.getBills();
            MessageBox.Show("Payment Success!");
        }
    }
}
