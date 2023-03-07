using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonTasker.Interfaces
{
    //Create interface IReminderCondition that describes a condition for a reminder
    public interface IReminderCondition
    {
        //method to check if condition is met
        bool ConditionMet();        
    }
    
}