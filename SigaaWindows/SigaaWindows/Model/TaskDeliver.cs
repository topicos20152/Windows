using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Model
{
    public class TaskDeliver
    {
        #region Atributes
        private Task task;
        private DateTime deliveryDate;
        private string status;
        #endregion

        #region Properties
        public Task Task
        {
            get { return task; }
            set { task = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion
    }
}
