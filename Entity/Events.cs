using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Events//olay özellikleri
    {
        int id,eventId;string userName,eventName, eventContent;DateTime creatingTime, startTime;

        public int Id { get => id; set => id = value; }
        public int EventId { get => eventId; set => eventId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string EventContent { get => eventContent; set => eventContent = value; }
        public DateTime CreatingTime { get => creatingTime; set => creatingTime = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }

        public Events(string eventName, string eventContent, DateTime creatingTime, DateTime startTime)
        {
            this.eventName = eventName;
            this.eventContent = eventContent;
            this.creatingTime = creatingTime;
            this.startTime = startTime;
        }
        //programda kullandığımız constructorlarımız
        public Events(int id, int eventId, string userName, string eventName, string eventContent, DateTime creatingTime, DateTime startTime)
        {
            this.id = id;
            this.eventId = eventId;
            this.userName = userName;
            this.eventName = eventName;
            this.eventContent = eventContent;
            this.creatingTime = creatingTime;
            this.startTime = startTime;
        }

        public Events(string eventName,string userName,string eventContent,DateTime startTime)
        {
            this.eventName = eventName;
            this.userName = userName;
            this.eventContent = eventContent;
            this.startTime = startTime;
        }
    }
}
