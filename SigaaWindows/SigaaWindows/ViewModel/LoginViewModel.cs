using SigaaWindows.Model;
using SigaaWindows.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.ViewModel
{
    public class LoginViewModel
    {
        public void Login()
        {
            AuthenticationProxy proxy = new AuthenticationProxy();
            string token = proxy.GetAccessToken();
            AuthenticationControl.AccessToken = token;
        }
    }
}
