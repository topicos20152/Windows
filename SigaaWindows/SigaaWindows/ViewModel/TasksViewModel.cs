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
        public ObservableCollection<Model.Task> Tasks { get; set; }

        public void GetUserTasks()
        {
            TaskProxy taskProxy = new TaskProxy();
            TaskAdapter taskAdapter = new TaskAdapter();
            Tasks = new ObservableCollection<Model.Task>(taskAdapter.GetTasks(taskProxy.GetUserTasks("5630be8511c8bd0003000005", AuthenticationControl.AccessToken)));
        }
    }
}
