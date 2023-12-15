namespace DonTasker.Interfaces;

public interface IReminderAction {
    // reminder action is a method that is called when a reminder is triggered but it is customizable
    // so that the user can define what happens when a reminder is triggered
    //anonymous method
    public delegate void ReminderAction();

}
