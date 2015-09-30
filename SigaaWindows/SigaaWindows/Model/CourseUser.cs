using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigaaWindows.Model
{
    public class CourseUser
    {
        #region Atributes
        private User user;
        private Course course;
        #endregion

        #region Properties
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
        #endregion
    }
}
