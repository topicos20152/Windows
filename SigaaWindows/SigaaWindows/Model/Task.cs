using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Model
{
    public class Task
    {
        #region Atributes
        private string status;
        private DateTime deliveryDate;
        private string title;
        private string description;
        private int score;
        private string attachment;
        private Course course;
        #endregion

        #region Properties
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
        #endregion
    }
}
