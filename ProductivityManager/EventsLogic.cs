using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    #region Abstractions
    // All events will need a Date and name of event
    public interface IEvent
    {
        DateTime EventDate { get; set; }
        string  EventName { get; set; }
    }
    // Determines the type of event that is being inserted
    public abstract class AllEvents : IEvent
    {
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string GetTypeOfEvent(int i)
        {
            string EventType = "";
            if (i == 0) 
            {
                EventType ="School";
            }
            else if (i == 1)
            {
                EventType = "Work";
            }
            else if (i == 2)
            {
                EventType = "Life";
            }

            return EventType;
        }
    }

    #endregion

    #region Event Types
    // class for school events
    class SchoolEvent : AllEvents
    {
      //  public DateTime EventDate { get; set; }
      //  public string EventName { get; set; }

        public string RoomEventIsIn { get; set; }
        
    }

    public class WorkEvent : AllEvents
    {
      //  public DateTime EventDate { get; set; }
      //  public string EventName { get; set; }

        public double MeetingTime { get; set; }
    }

    public class LifeEvent : AllEvents
    {
      //  public DateTime EventDate { get; set; }
       // public string EventName { get; set; }

        public string Location { get; set; }
        // ex: "family" / "other"
      /*  public string WhoIsAttending { get; set; }
        // only able to set if the event is of type life with "family attending"
        public List<string> MembersAttending { get; set; }
        // sets if it is family or other attending
        public void SetTypeOfAttending(string who)
        {
            if (who == "family" || who == "Family")
            {
                WhoIsAttending = "family";
            }
            else
            {
                WhoIsAttending = "other";
            }
        }
        */

    }

    #endregion
}











