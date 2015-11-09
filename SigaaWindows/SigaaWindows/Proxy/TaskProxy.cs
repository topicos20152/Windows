using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class TaskProxy
    {
        public List<Model.API.TaskResult> GetAllTasks()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://topicos-api.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/tasks").Result;
            var tasks = response.Content.ReadAsAsync<List<Model.API.TaskResult>>().Result;            
            return tasks;
        }

        public List<Model.API.TaskResult> GetUserTasks(string userId, string accessToken)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://topicos-api.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"/users/{userId}/tasks?access_token={accessToken}").Result;
            var tasks = response.Content.ReadAsAsync<List<Model.API.TaskResult>>().Result;
            return tasks;
        }
    }
}
