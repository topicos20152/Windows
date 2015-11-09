using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class AuthenticationProxy
    {
        public string GetAccessToken()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://topicos-api.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsync("/users/5630be8511c8bd0003000005/request_access_token", null).Result;
            var token = response.Content.ReadAsAsync<Model.API.AccessTokenResult>().Result;
            return token.value;
        }
    }
}
