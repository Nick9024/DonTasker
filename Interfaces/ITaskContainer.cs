namespace DonTasker.Interfaces
{
    public interface ITaskContainer
    {
        List<ITask> Tasks { get; set; }

        void AddTask(ITask task);
        void RemoveTask(ITask task);

        //indexer
        ITask this[int index] { get; set; }
    }
}