using SigaaWindows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigaaWindows.Adapter
{
    public class TaskAdapter
    {
        public Model.Task GetTask(Model.API.TaskResult taskResult)
        {
            return new Model.Task()
            {
                Course = new Course() { Title = taskResult.course_title },
                DeliveryDate = DateTime.Parse(taskResult.delivery_date),
                ID = taskResult.id,
                Title = taskResult.title
            };
        }

        public Model.Task GetTask(Model.API.TaskDetailsResult taskDetails)
        {
            return new Model.Task()
            {
                Course = new Course() { Title = taskDetails.course_title },
                DeliveryDate = DateTime.Parse(taskDetails.delivery_date),
                ID = taskDetails.id,
                Title = taskDetails.title,
                Attachment = taskDetails.attachment,
                Description = taskDetails.description,
                Status = taskDetails.answers
            };
        }

        public IEnumerable<Model.Task> GetTasks(IEnumerable<Model.API.TaskResult> taskResults)
        {
            List<Model.Task> tasks = new List<Task>();
            foreach(Model.API.TaskResult taskResult in taskResults)
            {
                tasks.Add(
                    new Model.Task()
                    {
                        Course = new Course() { Title = taskResult.course_title },
                        DeliveryDate = DateTime.Parse(taskResult.delivery_date),
                        ID = taskResult.id,
                        Title = taskResult.title
                    });
            }
            return tasks;
        }
    }
}
