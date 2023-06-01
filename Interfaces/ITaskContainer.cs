namespace DonTasker.Interfaces
{
    public interface ITaskContainer
    {
        IEnumerable<ITask> Tasks { get; set; }

        void AddTask(ITask task);
        void RemoveTask(ITask task);
    }
}