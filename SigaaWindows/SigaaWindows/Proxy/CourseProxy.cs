using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Proxy
{
    public class CourseProxy:AbstractProxy
    {
        public List<Model.API.CourseResult> GetUserCourses(string userId, string accessToken)
        {
            HttpResponseMessage response = RequestClient.GetAsync($"/api/v1/users/{userId}/courses?access_token={accessToken}").Result;
            var courses = response.Content.ReadAsAsync<List<Model.API.CourseResult>>().Result;
            return courses;
        }
    }
}
