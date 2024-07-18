using ReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.ViewModel
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string UserName => _reservation.UserName.ToString();
        public string RoomId => _reservation.RoomId.ToString();
        /// <summary>
        /// Here it will display the time and date so to get only date you can use StringFormat ="" in xaml or you can handle this in viewmodel like below
        /// </summary>
        public string StartTime => _reservation.StartTime.ToString("d");
        public string EndDate => _reservation.EndDate.ToString("d");

        //getting all reservations here 
        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
