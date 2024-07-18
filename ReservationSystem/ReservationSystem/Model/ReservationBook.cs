using ReservationSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Model
{
    public class ReservationBook
    {
        private readonly List<Reservation> _roomReservations;

        public ReservationBook()
        {
            //Created the List of Reservations
            _roomReservations = new List<Reservation>();
        }

        /// <summary>
        ///  Get All Reservations
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _roomReservations;
        }

        /// <summary>
        /// Make Reservations
        /// </summary>
        /// <param name="reservation"></param>
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _roomReservations)
            {
                //if the reservation already exists
                if(existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictExceptions(existingReservation, reservation);
                }
            }
            _roomReservations.Add(reservation);
        }

    }
}
