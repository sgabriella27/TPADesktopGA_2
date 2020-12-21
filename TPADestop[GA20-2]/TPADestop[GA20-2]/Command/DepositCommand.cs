using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TPADestop_GA20_2_.Interfaces;

namespace TPADestop_GA20_2_.Command
{
    class DepositCommand : ICommand
    {
        private TextBox accTxt;
        private TextBox moneyTxt;
        private TextBox periodTxt;
        private DatePicker datePick;
        private TextBox senderTxt;
        private Window depositWindow;
        private Window tellerWindow;
        private Employee employee;

        public DepositCommand(TextBox accTxt, TextBox moneyTxt, TextBox periodTxt, DatePicker datePick, TextBox senderTxt, Window depositWindow)
        {
            this.accTxt = accTxt;
            this.moneyTxt = moneyTxt;
            this.periodTxt = periodTxt;
            this.datePick = datePick;
            this.senderTxt = senderTxt;
            this.depositWindow = depositWindow;
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
            if (periodTxt.Text == "")
            {
                MessageBox.Show("Period Must Be Filled!");
                return;
            }
            if (datePick.Text == "")
            {
                MessageBox.Show("Deposit Date Must Be Filled");
                return;
            }
            if (senderTxt.Text == "")
            {
                MessageBox.Show("Sender Account Number Must Be Filled!");
                return;
            }
            DataTable sender = ConnectDB.getInstance().executeQuery("SELECT * FROM customer WHERE accountnumber = '" + senderTxt.Text + "' LIMIT 1");
            DataRow dt = sender.Rows[0];
            DataTable receive = ConnectDB.getInstance().executeQuery("SELECT * FROM customer WHERE accountnumber = '" + accTxt.Text + "' AND familyCard = '" + dt["familyCard"] + "' LIMIT 1");

            if(receive.Rows.Count == 0)
            {
                MessageBox.Show("Not Family Cannot Deposit!");
                return;
            }

            ConnectDB.getInstance().executeQuery("INSERT INTO deposit (accountNumber, moneyAmount, depositPeriod, depositDate) VALUES ('" + accTxt.Text.ToString() + "', '" + moneyTxt.Text.ToString() + "', '" + periodTxt.Text.ToString() + "', '" + datePick.DisplayDate.ToString("yyyy-MM-dd") + "')");

            MessageBox.Show("Deposit Success!");

            tellerWindow = new TellerWindow(employee);
            tellerWindow.Show();
            depositWindow.Close();
        }
    }
}
