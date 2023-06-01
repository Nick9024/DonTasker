using DonTasker.Enums;

namespace DonTasker.Interfaces
{
    //Create interface IReminder
    public interface IReminder
    {
        //method to send reminder
        void TriggerReminder();

        //method to get reminder rule type
        ReminderType GetReminderType();

        //static method to create reminder of type T inheritded from IReminder
        T CreateReminder<T>() where T : IReminder;

        //method to delete reminder
        void DeleteReminder();

        //method to update reminder
        void UpdateReminder(IReminder reminder);
    }
}