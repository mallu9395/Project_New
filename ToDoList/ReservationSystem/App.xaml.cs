using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReservationSystem.Model;

namespace ReservationSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Reservation");
            hotel.MakeReservation(new Reservation(new RoomID(1, 3), "REs", new DateTime(2000, 01, 01), new DateTime(2000, 01, 02)));
            hotel.MakeReservation(new Reservation(new RoomID(1, 2), "REs", new DateTime(2000, 01, 03), new DateTime(2000, 01, 04)));

            IEnumerable<Reservation> reservation = hotel.GetReservationsForUser("REs");
            base.OnStartup(e);
        }

    }
}
