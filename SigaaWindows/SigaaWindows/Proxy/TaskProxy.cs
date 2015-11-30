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
    public class TaskProxy:AbstractProxy
    {
        public List<Model.API.TaskResult> GetAllTasks()
        {
            HttpResponseMessage response = RequestClient.GetAsync("/api/v1/tasks").Result;
            var tasks = response.Content.ReadAsAsync<List<Model.API.TaskResult>>().Result;            
            return tasks;
        }

        public List<Model.API.TaskResult> GetUserTasks(string userId, string accessToken)
        {
            HttpResponseMessage response = RequestClient.GetAsync($"/api/v1/users/{userId}/tasks?access_token={accessToken}").Result;
            var tasks = response.Content.ReadAsAsync<List<Model.API.TaskResult>>().Result;
            return tasks;
        }

        public Model.API.TaskDetailsResult GetTaskDetails(string taskId)
        {
            HttpResponseMessage response = RequestClient.GetAsync($"/api/v1/tasks/{taskId}").Result;
            var task = response.Content.ReadAsAsync<Model.API.TaskDetailsResult>().Result;
            return task;
        }
    }
}
