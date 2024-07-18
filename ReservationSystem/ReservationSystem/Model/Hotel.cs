using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Model
{
    public class Hotel
    {
        /// <summary>
        /// Why it is read only?
        /// Once initialized, this instance remains unchanged (in terms of its reference) throughout the lifespan of the Hotel object.
        /// Since _reservationBook is readonly, these methods can safely access _reservationBook without 
        /// concern that its reference might change unexpectedly elsewhere in the class.
        /// </summary>
        private readonly ReservationBook _reservationBook;
        public string Name { get;  }
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Why return type is IEnumerable?
        /// [ IEnumerable<T> is preferred as a return type when you only need to iterate over the collection
        /// without requiring capabilities like random access (indexing), insertion, or deletion of elements, 
        /// provides a clear and flexible way to work with sequences of items.]
        /// When Not to Use IEnumerable<T>?
        /// [If your method needs to support collection modification operations (addition, removal, etc.),then IEnumerable<T>
        /// would not be suitable. In such cases, you might consider returning a more specific interface like ICollection<T> or IReadOnlyCollection<T>]
        /// Get All Reservations
        /// </summary>
        /// <param name="username">the user of the user.</param>
        /// <returns>The reservation for the user.</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations(); ;
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
