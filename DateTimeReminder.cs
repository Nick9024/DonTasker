namespace DonTasker {
    public class DateTimeReminder : IReminder, IReminderCondition, IReminderAction {
        private DateTime reminderDate;
        IReminderAction.ReminderAction? _action;

        public bool ConditionMet() {
            if (DateTime.Now >= reminderDate) {
                return true;
            }
            return false;
        }

        public ReminderType GetReminderType() => ReminderType.Time;

        public void TriggerReminder() {
            if (ConditionMet()&&_action!=null) {
                _action();
            }
        }

        public bool UpdateReminder(dynamic data) {
            if (data is DateTime) {
                reminderDate = data;
                return true;
            }
            return false;
        }

    }
}
