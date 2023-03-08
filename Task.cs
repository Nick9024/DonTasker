using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonTasker.Interfaces;
using DonTasker.Enums;

namespace DonTasker
{   
    public class Task: ITask{
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
    void AddSubTask(ITask task) => SubTasks.Add(task);
    void RemoveSubTask(ITask task) => SubTasks.Remove(task);
    void AddTag(ITag tag) => Tags.Add(tag);
    void RemoveTag(ITag tag) => Tags.Remove(tag);
    void AddAttachment(IAttachment attachment) => Attachments.Add(attachment);
    void RemoveAttachment(IAttachment attachment) => Attachments.Remove(attachment);
    void AddComment(Comment comment) => Comments.Add(comment);
    void RemoveComment(Comment comment) => Comments.Remove(comment);
    void AddRelation(IRelation relation) => Relations.Add(relation);
    void RemoveRelation(IRelation relation) => Relations.Remove(relation);
    void AddAttribute(IAttribute attribute); //What is this? 
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
    
    
}