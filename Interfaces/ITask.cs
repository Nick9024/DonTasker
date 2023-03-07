namespace DonTasker.Interfaces;
//Create interface ITask describes the behavior of a task
public interface ITask
{
    
    //properties
    string Name { get; set; }
    string Description { get; set; }
    TaskStatus Status { get; set; }
    DateTime DueDate { get; set; }
    DateTime CreatedDate { get; set; }
    DateTime CompletedDate { get; set; }
    DateTime LastModified { get; set; }
    List<IReminder> Reminders { get; set; }
    List<ITask> SubTasks { get; set; }
    ITask ParentTask { get; set; }
    List<ITag> Tags { get; set; }
    List<IAttachment> Attachments { get; set; }
    List<Comment> Comments { get; set; }
    List<IRelation> Relations { get; set; }
    List<IAttribute> Attributes { get; set; }
    List<INote> Notes { get; set; }
    List<IContext> Contexts { get; set; }
    List<IProject> Projects { get; set; }
    List<IGoal> Goals { get; set; }
    List<IContact> Contacts { get; set; }
    List<ILocation> Locations { get; set; }
    List<IEvent> Events { get; set; }

    //methods
    void AddSubTask(ITask task);
    void RemoveSubTask(ITask task);
    void AddTag(ITag tag);
    void RemoveTag(ITag tag);
    void AddAttachment(IAttachment attachment);
    void RemoveAttachment(IAttachment attachment);
    void AddComment(Comment comment);
    void RemoveComment(Comment comment);
    void AddRelation(IRelation relation);
    void RemoveRelation(IRelation relation);
    void AddAttribute(IAttribute attribute);
    void RemoveAttribute(IAttribute attribute);
    void AddNote(INote note);
    void RemoveNote(INote note);
    void AddContext(IContext context);
    void RemoveContext(IContext context);
    void AddProject(IProject project);
    void RemoveProject(IProject project);
    void AddGoal(IGoal goal);
    void RemoveGoal(IGoal goal);
    void AddContact(IContact contact);
    void RemoveContact(IContact contact);
    void AddLocation(ILocation location);
    void RemoveLocation(ILocation location);
    void AddEvent(IEvent eventItem);
    void RemoveEvent(IEvent eventItem);
    void AddReminder(IReminder reminder);
    void RemoveReminder(IReminder reminder);
    void CompleteTask();
    bool DeleteTask(bool force);
    void UpdateTask();
    
    void AddTask(string name, string description, DateTime dueDate);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts);   
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations, List<IEvent> events);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations, List<IEvent> events, List<IAttribute> attributes);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations, List<IEvent> events, List<IAttribute> attributes, List<INote> notes);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations, List<IEvent> events, List<IAttribute> attributes, List<INote> notes, List<IRelation> relations);
    void AddTask(string name, string description, DateTime dueDate, ITask parentTask, List<ITag> tags, List<IAttachment> attachments, List<IReminder> reminders, List<ITask> subTasks, List<IContext> contexts, List<IProject> projects, List<IGoal> goals, List<IContact> contacts, List<ILocation> locations, List<IEvent> events, List<IAttribute> attributes, List<INote> notes, List<IRelation> relations, List<Comment> comments);
    bool IsSubTask();
    int HasSubTasks();
    list<ITask> GetSubTasks();
    list<ITag> GetTags(); 
    list<IAttachment> GetAttachments();
    list<IReminder> GetReminders();
    list<IContext> GetContexts();
    list<IProject> GetProjects();
    list<IGoal> GetGoals();
    list<IContact> GetContacts();
    list<ILocation> GetLocations();
    list<IEvent> GetEvents();
    list<IAttribute> GetAttributes();
    list<INote> GetNotes();
    list<IRelation> GetRelations();
    list<Comment> GetComments();
    ITask GetParentTask();

}

