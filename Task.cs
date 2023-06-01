using DonTasker.Enums;
using DonTasker.Interfaces;

namespace DonTasker
{
    public class Task : ITask
    {
        public Task(string name, string description = "", TaskProgress status = TaskProgress.NotStarted, ITask? parentTask = null)
        {
            this.Name = name;
            this.Status = status;
            this.ParentTask = parentTask;
            this.Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public TaskProgress Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public ITask? ParentTask { get; set; }
        public ITaskContainer? TaskContainer { get; set; }

        public ITask Clone()
        {
            return new Task(this.Name ,this.Description);
        }

        public void CompleteTask()
        {
            this.Status = TaskProgress.Completed;
            this.CompletedDate = DateTime.Now;
        }

        public void SetDueDate(DateTime? dueDate)
        {
            this.DueDate = dueDate;
        }
    }
}