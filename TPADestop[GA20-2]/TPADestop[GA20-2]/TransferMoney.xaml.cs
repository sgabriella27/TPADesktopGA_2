using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace TPADestop_GA20_2_
{
    /// <summary>
    /// Interaction logic for TransferMoney.xaml
    /// </summary>
    public partial class TransferMoney : Window
    {
        Employee employee;
        public TransferMoney(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void TransferBtn_Click(object sender, RoutedEventArgs e)
        {
            if (acctxt.Text == "")
            {
                MessageBox.Show("Account Number Must Be Filled!");
                return;
            }
            if (moneytxt.Text == "")
            {
                MessageBox.Show("Amount Must Be Filled!");
                return;
            }
            
            string databaseConnection = "SERVER=localhost;DATABASE=kongbubank;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(databaseConnection);
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM customer WHERE accountnumber = @accnum LIMIT 1", conn);
            command.Parameters.AddWithValue("@accnum", acctxt.Text.ToString());

            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            conn.Close();

            ConnectDB.getInstance().executeUpdate("UPDATE customer SET customerbalance = customerbalance + " + moneytxt.Text.ToString() + " WHERE accountnumber = " + Int32.Parse(acctxt.Text.ToString()));

            ConnectDB.getInstance().executeUpdate("UPDATE customer SET customerbalance = customerbalance - " + moneytxt.Text.ToString() +  " WHERE accountnumber = " + Int32.Parse(sendtxt.Text.ToString()));

            MessageBox.Show("Transfer Success!");

            Window qr = new QRCode(employee);
            qr.Show();
            this.Close();
        }
    }
}
