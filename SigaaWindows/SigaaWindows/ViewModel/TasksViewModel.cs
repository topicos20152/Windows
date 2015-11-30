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
    public class TasksViewModel
    {
        private List<Model.Task> tasks;

        public ObservableCollection<Model.Task> Tasks { get; set; }

        public Model.Task SelectedTask { get; set; }

        public void GetUserTasks()
        {
            TaskProxy taskProxy = new TaskProxy();
            TaskAdapter taskAdapter = new TaskAdapter();
            tasks = taskAdapter.GetTasks(taskProxy.GetUserTasks("564ce3525e5ca90003000005", AuthenticationControl.AccessToken)).OrderBy(t => t.DeliveryDate).ToList();
            Tasks = new ObservableCollection<Model.Task>(tasks);
        }

        public void GetTaskDetails(Model.Task task)
        {
            TaskProxy taskProxy = new TaskProxy();
            TaskAdapter taskAdapter = new TaskAdapter();
            SelectedTask = taskAdapter.GetTask(taskProxy.GetTaskDetails(task.ID));
        }

        public void FilterTasksByCourse(Course course)
        {
            Tasks = new ObservableCollection<Model.Task>(tasks.Where(t => t.Course.Title == course.Title));
        }

        public void ClearFilter()
        {
            Tasks = new ObservableCollection<Model.Task>(tasks);
        }
    }
}
