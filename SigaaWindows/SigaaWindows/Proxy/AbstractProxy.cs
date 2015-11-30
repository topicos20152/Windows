using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class AbstractProxy
    {
        protected readonly string BaseAdress = "http://topicos-api.herokuapp.com/";

        protected readonly HttpClient RequestClient = new HttpClient();

        public AbstractProxy()
        {
            RequestClient = new HttpClient();
            RequestClient.BaseAddress = new Uri("http://topicos-api.herokuapp.com/");
            RequestClient.DefaultRequestHeaders.Accept.Clear();
            RequestClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
