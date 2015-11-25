using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class CourseProxy
    {
        public List<Model.API.CourseResult> GetUserCourses(string userId, string accessToken)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://topicos-api.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"/api/v1/users/{userId}/courses?access_token={accessToken}").Result;
            var courses = response.Content.ReadAsAsync<List<Model.API.CourseResult>>().Result;
            return courses;
        }
    }
}
