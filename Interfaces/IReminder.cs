namespace DonTasker.Interfaces; 
//Create interface IReminder
public interface IReminder
{
    //method to send reminder
    void TriggerReminder();

    //method to get reminder rule type
    ReminderType GetReminderType();

    bool UpdateReminder(dynamic data);

    //static method to create reminder of type T inheritded from IReminder
    //T CreateReminder<T>() where T : IReminder;
}
