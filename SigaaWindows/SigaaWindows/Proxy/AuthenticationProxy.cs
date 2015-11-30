using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class AuthenticationProxy:AbstractProxy
    {
        public string GetAccessToken()
        {
            HttpResponseMessage response = RequestClient.PostAsync("/api/v1/users/564ce3525e5ca90003000005/request_access_token", null).Result;
            var token = response.Content.ReadAsAsync<Model.API.AccessTokenResult>().Result;
            return token.value;
        }
    }
}
