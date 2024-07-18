using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Model
{
    public class Reservation
    {
        public string UserName { get; }
        public RoomID RoomId { get;  } 
        public DateTime StartTime { get; }
        public DateTime EndDate { get;  }
        public TimeSpan Length => EndDate.Subtract(StartTime);

        public Reservation(RoomID roomId,string userName, DateTime startDate, DateTime endTime)
        {
            RoomId = roomId;
            StartTime = startDate;
            EndDate = endTime;
            UserName = userName;
        }

        public bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomId != RoomId)
            {
                return false;
            }

            return reservation.StartTime < EndDate || reservation.EndDate > reservation.StartTime;
        }

        
    }
}
