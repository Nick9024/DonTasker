namespace DonTasker.Interfaces;

//Create interface IReminder
public interface IReminder
{
    //method to send reminder
    void TriggerReminder();

    //method to get reminder rule type
    static ReminderType GetReminderType();    

    //static method to create reminder of type T inheritded from IReminder
    static T CreateReminder<T>() where T : IReminder;


    //method to delete reminder
    void DeleteReminder();

    //method to update reminder
    void UpdateReminder();   
    
}