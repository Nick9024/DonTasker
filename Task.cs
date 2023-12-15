namespace DonTasker {
    public class Task(string title, string description = "", TaskProgress status = TaskProgress.NotStarted, ITask? parentTask = null) : ITask {

        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
        public TaskProgress Status { get; set; } = status;
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public ITask? ParentTask { get; set; } = parentTask;
        public ITaskContainer? TaskContainer { get; set; }
        public List<IReminder> Reminders { get; set; } = [];

        public void AddReminder(IReminder reminder) => Reminders.Add(reminder);

        public ITask Clone() => new Task(title: Title, Description);

        public void CompleteTask() {
            Status = TaskProgress.Completed;
            CompletedDate = DateTime.Now;
        }

        public void RemoveReminder(IReminder reminder) => Reminders.Remove(reminder);

        public void SetDueDate(DateTime? dueDate) => DueDate = dueDate;

        public void SetParentTask(ITask parentTask) => ParentTask = parentTask;

        public ITask CreateSubTask(ITask subTask) => new Task(title: subTask.Title, description: subTask.Description, status: subTask.Status, parentTask: this);

    }
}
