using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Model
{
    public class RoomID
    {
       public int FloorNumber { get; }
       public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        /// <summary>
        /// Cusom Implemenation for ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        /// <summary>
        /// Overriding Equals Method and giving Custom implementation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is RoomID roomId && FloorNumber == roomId.FloorNumber && RoomNumber == roomId.RoomNumber;
        }

        /// <summary>
        /// generates HashCode 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        /// <summary>
        /// Operator Overloading
        /// </summary>
        /// <param name="roomID1"></param>
        /// <param name="roomID2"></param>
        /// <returns></returns>
        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        /// <summary>
        /// Operator Overloading
        /// </summary>
        /// <param name="roomID1"></param>
        /// <param name="roomID2"></param>
        /// <returns></returns>
        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}
