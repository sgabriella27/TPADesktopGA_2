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
    /// Interaction logic for QueuingMachine.xaml
    /// </summary>
    public partial class QueuingMachine : Window
    {

        queueController queueController = new queueController();
        public QueuingMachine(Employee employee)
        {
            InitializeComponent();
            DataGridQueue.ItemsSource = queueController.getQueue();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB.getInstance().executeQuery("INSERT INTO queue (customerName) VALUES ('" + cusName.Text.ToString() + "')");
            queueController = new queueController();
            DataGridQueue.ItemsSource = queueController.getQueue();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(queueController.getQueue().Count().ToString(), QRCodeGenerator.ECCLevel.Q);
            XamlQRCode code = new XamlQRCode(data);

            DrawingImage qrCodeAsXaml = code.GetGraphic(20);
            qrCode.Source = qrCodeAsXaml;
            MessageBox.Show("Queue Generated!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window backWindow = new MainWindow();
            backWindow.Show();
            this.Close();
        }
    }
}
