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
    /// Interaction logic for CustomerServiceWindow.xaml
    /// </summary>
    public partial class CustomerServiceWindow : Window
    {
        public CustomerServiceWindow(Employee employee)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window createWindow = new CreateAccountWindow();
            createWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window blockWindow = new BlockAccountWindow();
            blockWindow.Show();
            this.Close();
        }
    }
}
