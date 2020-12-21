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
using QRCoder;

namespace TPADestop_GA20_2_
{
    /// <summary>
    /// Interaction logic for QRCode.xaml
    /// </summary>
    public partial class QRCode : Window
    {
        Employee employee;
        public QRCode(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            QRCodeGenerator generateQR = new QRCodeGenerator();
            QRCodeData codeDataQR = generateQR.CreateQrCode(employee.employeeEmail, QRCodeGenerator.ECCLevel.H);
            XamlQRCode codeQR = new XamlQRCode(codeDataQR);
            DrawingImage QRxaml = codeQR.GetGraphic(20);
            qrcode.Source = QRxaml;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Window teller = new TellerWindow(employee);
            teller.Show();
            this.Close();
        }
    }
}
