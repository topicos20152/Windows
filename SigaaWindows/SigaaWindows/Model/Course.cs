using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Model
{
    public class Course
    {
        #region Atributes
        private string title;
        private string id;
        #endregion

        #region Properties
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion
    }
}
