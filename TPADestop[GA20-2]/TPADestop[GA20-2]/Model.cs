using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TPADestop_GA20_2_
{
    class Model
    {
        public String billID { get; set; }
        public String billName { get; set; }
        public String billAmount { get; set; }

        public Model()
        {

        }

        public DataTable getBills()
        {
            return ConnectDB.getInstance().executeQuery("SELECT billID, billName, billAmount FROM bills");
        }

        public void update(String billID, String billAmount)
        {
            ConnectDB.getInstance().executeUpdate("UPDATE bills SET billAmount = billAmount - " + Int32.Parse(billAmount) + " WHERE billID = '" + billID + "'");
        }

        public void deleteBills()
        {
            ConnectDB.getInstance().executeUpdate("DELETE FROM bills WHERE billAmount <= 0");
        }

    }

    class controllerBills
    {
        List<Model> billsList = new List<Model>();
        Model model = new Model();

        public controllerBills()
        {
            DataTable billsData = model.getBills();
            for (int i = 0; i < billsData.Rows.Count; ++i)
            {
                billsList.Add(new Model()
                {
                    billID = billsData.Rows[i][0].ToString(),
                    billName = billsData.Rows[i][1].ToString(),
                    billAmount = billsData.Rows[i][2].ToString()
                });
            }
        }

        public List<Model> getBills()
        {
            return billsList;
        }

        public void update(String billID, String billAmount)
        {
            model.update(billID, billAmount);
        }

        public void deleteBills()
        {
            model.deleteBills();
        }

    }
}
