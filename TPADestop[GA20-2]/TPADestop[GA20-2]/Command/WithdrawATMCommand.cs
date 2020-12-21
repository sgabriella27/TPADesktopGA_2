using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using TPADestop_GA20_2_.Interfaces;

namespace TPADestop_GA20_2_.Command
{
    class WithdrawATMCommand : ICommand
    {
        private TextBox accTxt;
        private TextBox moneyTxt;
        private Window withdrawWindow;
        private Employee employee;

        public WithdrawATMCommand(TextBox accTxt, TextBox moneyTxt, Window withdrawWindow)
        {
            this.accTxt = accTxt;
            this.moneyTxt = moneyTxt;
            this.withdrawWindow = withdrawWindow;
        }
        public void Execute()
        {
            if (accTxt.Text == "")
            {
                MessageBox.Show("Account Number Must Be Filled!");
                return;
            }
            if (moneyTxt.Text == "")
            {
                MessageBox.Show("Amount Must Be Filled!");
                return;
            }

            string databaseConnection = "SERVER=localhost;DATABASE=kongbubank;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(databaseConnection);
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM customer WHERE accountnumber = @accnum LIMIT 1", conn);
            command.Parameters.AddWithValue("@accnum", accTxt.Text.ToString());

            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            conn.Close();

            ConnectDB.getInstance().executeUpdate("UPDATE customer SET customerbalance = customerbalance - " + Int32.Parse(moneyTxt.Text.ToString()) + " WHERE accountnumber = " + accTxt.Text.ToString());

            MessageBox.Show("Withdraw Success!");

            ATMWindow window = new ATMWindow(employee);
            window.Show();
            withdrawWindow.Close();
        }
    }
}

