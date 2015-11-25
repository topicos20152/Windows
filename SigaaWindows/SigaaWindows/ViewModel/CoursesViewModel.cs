using SigaaWindows.Adapter;
using SigaaWindows.Model;
using SigaaWindows.Proxy;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.ViewModel
{
    public class CoursesViewModel
    {
        public ObservableCollection<Model.Course> Courses { get; set; }

        public void GetUserCourses()
        {
            CourseAdapter courseAdapter = new CourseAdapter();
            CourseProxy courseProxy = new CourseProxy();
            Courses = new ObservableCollection<Model.Course>(courseAdapter.GetCourses(courseProxy.GetUserCourses("564ce3525e5ca90003000005", AuthenticationControl.AccessToken)));
        }
    }
}
