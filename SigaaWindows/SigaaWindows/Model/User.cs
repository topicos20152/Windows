using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Model
{
    public class User
    {
        #region Atributes
        private string username;
        private string sigaa_uuid;
        private string name;
        #endregion

        #region Properties
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public string SigaaUUID
        {
            get { return sigaa_uuid; }
            set { sigaa_uuid = value; }
        }     

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
