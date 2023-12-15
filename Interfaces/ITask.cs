namespace DonTasker.Interfaces;

public interface ITask{
    string Title { get; set; }
    string Description { get; set; }
    TaskProgress Status { get; set; }
    DateTime? DueDate { get; set; }
    DateTime? CompletedDate { get; set; }
    ITaskContainer? TaskContainer { get; set; }
    /* IReminders Reminders { get; set; }
    IRelations Relations { get; set; } */
    ITask? ParentTask { get; set; }

    ITask Clone();

    void AddReminder(IReminder reminder);
    void RemoveReminder(IReminder reminder);
    void CompleteTask();
    void SetDueDate(DateTime? dueDate);
}
