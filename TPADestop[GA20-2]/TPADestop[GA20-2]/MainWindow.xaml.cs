using MySql;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace TPADestop_GA20_2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string employeeEmail;
        string employeePassword;

        public MainWindow()
        {
            InitializeComponent();
        }

        public string EmployeeEmail { get => employeeEmail; set => employeeEmail = value; }
        public string EmployeePassword { get => employeePassword; set => employeePassword = value; }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            string databaseConnection = "SERVER=localhost;DATABASE=kongbubank;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(databaseConnection);
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM employee WHERE EmployeeEmail = @employeeEmail AND EmployeePassword = @employeePassword LIMIT 1", conn);
            command.Parameters.AddWithValue("@employeeEmail", EmailTxt.Text);
            command.Parameters.AddWithValue("@employeePassword", PasswordTxt.Password);

            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Employee not found!");
                return;
            }

            DataRow dataRow = dataTable.Rows[0];

            if (dataRow["EmployeeRole"].ToString().Equals("teller"))
            {
                Window tellerWindow = new TellerWindow(new Employee(dataRow["EmployeeID"].ToString(), dataRow["EmployeeEmail"].ToString(), dataRow["EmployeePassword"].ToString(), dataRow["EmployeeRole"].ToString()));
                tellerWindow.Show();
                this.Close();
            }

            conn.Close();
        }
    }
}
