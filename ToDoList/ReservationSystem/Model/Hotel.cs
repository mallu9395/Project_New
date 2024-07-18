using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Model
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get;  }
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservation for a user
        /// </summary>
        /// <param name="username">the user of the user.</param>
        /// <returns>The reservation for the user.</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetReservations(username); ;
        }

        /// <summary>
        /// Make Reservations
        /// </summary>
        /// <param name="reservation"> the incoming reservation</param>
        /// <exception cref ="ReservationConflictException"></exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

    }
}
