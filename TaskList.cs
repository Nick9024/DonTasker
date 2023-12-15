namespace DonTasker;

public class TaskList : ITaskContainer {
    public ITask this[int index] {
        get {
            return Tasks[index];
        }
        set {
            Tasks[index] = value;
        }
    }

    public List<ITask> Tasks {
        get {
            if (Tasks == null) {
                return [];
            } else {
                return Tasks;
            }
        }
        set => Tasks = value;
    }

    public void AddTask(ITask task) => Tasks.Add(task);

    public void RemoveTask(ITask task) => Tasks.Remove(task);
}
