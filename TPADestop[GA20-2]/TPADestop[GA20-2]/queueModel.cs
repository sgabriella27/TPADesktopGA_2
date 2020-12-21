using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPADestop_GA20_2_
{
    class queueModel
    {
        public String queueID { get; set; }
        public String customerName { get; set; }

        public queueModel()
        {
            
        }

        public DataTable getQueue()
        {
            return ConnectDB.getInstance().executeQuery("SELECT queueID, customerName FROM queue");
        }
    }

    class queueController
    {
        List<queueModel> queueList = new List<queueModel>();
        queueModel queueModel = new queueModel();

        public queueController()
        {
            DataTable queueData = queueModel.getQueue();
            for (int i = 0; i < queueData.Rows.Count; ++i)
            {
                queueList.Add(new queueModel()
                {
                    queueID = queueData.Rows[i][0].ToString(),
                    customerName = queueData.Rows[i][1].ToString(),
                });
            }
        }

        public List<queueModel> getQueue()
        {
            return queueList;
        }
    }
}
