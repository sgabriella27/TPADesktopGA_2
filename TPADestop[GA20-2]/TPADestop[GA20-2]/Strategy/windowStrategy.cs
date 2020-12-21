using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TPADestop_GA20_2_.Strategy
{
    public class windowStrategy //Strategy
    {
        Window newWindow;
        public windowStrategy()
        {

        }

        public void setStrategy(Window newWindow)
        {
            this.newWindow = newWindow;
            this.newWindow.Show();
        }
    }
}
