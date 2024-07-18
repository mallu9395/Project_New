using ReservationSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReservationSystem.ViewModel
{
    public class ReservationListingViewModel :ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        //Encapsulating ObservableCollection
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        //all the Reservation Collection
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(12, 13), "Maike", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(12, 14), "Maie", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(12, 15), "Make", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(12, 16), "Mike", DateTime.Now, DateTime.Now)));
        }
    }
}
