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
    /// Interaction logic for ATMDepositWindow.xaml
    /// </summary>
    public partial class ATMDepositWindow : Window
    {
        public ATMDepositWindow()
        {
            InitializeComponent();
        }

        private void DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            new DepositATMCommand(accTxt, moneyTxt, periodTxt, datePick, senderTxt, this).Execute();
        }
    }
}
