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
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        Employee employee;
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (accTxt.Text == "")
            {
                MessageBox.Show("Account Number Must Be Filled!");
                return;
            }
            if (custTxt.Text == "")
            {
                MessageBox.Show("Customer Name Must Be Filled!");
                return;
            }
            if (moneyTxt.Text == "")
            {
                MessageBox.Show("Amount Must Be Filled!");
                return;
            }
            if (typeTxt.Text == "")
            {
                MessageBox.Show("Account Type Must Be Filled!");
                return;
            }
            ConnectDB.getInstance().executeQuery("INSERT INTO customer (accountNumber, customerName, customerBalance, accountType) VALUES ('" + accTxt.Text.ToString() + "', '" + custTxt.Text.ToString() + "', '" + moneyTxt.Text.ToString() + "', '" + typeTxt.Text.ToString() + "')");
            MessageBox.Show("Create Account Success!");

            Window nextWindow = new CustomerServiceWindow(employee);
            nextWindow.Show();
            this.Close();
        }
    }
}
