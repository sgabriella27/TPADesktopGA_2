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
using TPADestop_GA20_2_.Command;

namespace TPADestop_GA20_2_
{
    /// <summary>
    /// Interaction logic for ATMWithdrawWindow.xaml
    /// </summary>
    public partial class ATMWithdrawWindow : Window
    {
        public ATMWithdrawWindow()
        {
            InitializeComponent();
        }

        private void WithdrawBtn_Click(object sender, RoutedEventArgs e)
        {
            new WithdrawATMCommand(accTxt, moneyTxt, this).Execute();
        }
    }
}
