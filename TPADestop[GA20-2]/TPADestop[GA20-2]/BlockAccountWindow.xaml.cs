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
    /// Interaction logic for BlockAccountWindow.xaml
    /// </summary>
    public partial class BlockAccountWindow : Window
    {
        Employee employee;
        public BlockAccountWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (accTxt.Text == "")
            {
                MessageBox.Show("Customer Account Number Must Be Filled!");
                return;
            }

            ConnectDB.getInstance().executeUpdate("UPDATE customer SET status = 'Blocked' WHERE accountNumber = '" + accTxt.Text.ToString() +"'");

            MessageBox.Show("Account Has Been Blocked");
            Window nextWindow = new CustomerServiceWindow(employee);
            nextWindow.Show();
            this.Close();
        }
    }
}
