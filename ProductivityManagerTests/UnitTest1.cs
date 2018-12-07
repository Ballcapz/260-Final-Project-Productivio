using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductivityManager;

namespace ProductivityManagerTests
{
    [TestClass]
    public class EventsLogicTest1
    {
        [TestMethod]
        public void PopulateAndUseClasses()
        {

            // school events
            SchoolEvent s = new SchoolEvent();
            s.EventDate = DateTime.Today;
            s.EventName = "TestEvent";
            s.RoomEventIsIn = "TestRoom";

            Assert.AreEqual(DateTime.Today, s.EventDate);
            Assert.AreEqual("TestEvent", s.EventName);
            Assert.AreEqual("TestRoom", s.RoomEventIsIn);
            
            // work events
            WorkEvent w = new WorkEvent();
            w.EventDate = DateTime.Today;
            w.EventName = "TestEvent";
            w.MeetingTime = 0900;

            Assert.AreEqual(DateTime.Today, w.EventDate);
            Assert.AreEqual("TestEvent", w.EventName);
            Assert.AreEqual(0900, w.MeetingTime);


            // life events
            LifeEvent l = new LifeEvent();
            l.EventDate = DateTime.Today;
            l.EventName = "TestEvent";
            l.Location = "TestLocation";

            Assert.AreEqual(DateTime.Today, l.EventDate);
            Assert.AreEqual("TestEvent", l.EventName);
            Assert.AreEqual("TestLocation", l.Location);

        }
    }
}
