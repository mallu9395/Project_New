using ReservationSystem.Exceptions;
using ReservationSystem.Model;
using ReservationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReservationSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // means remove the Startupuri which automatically mainwindow displayed now we are setting the window so no need
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();


            //Hotel hotel = new Hotel("Reservation");
              
            //try
            //{
            //    hotel.MakeReservation(new Reservation(new RoomID(1, 3), "REs", new DateTime(2000, 01, 01), new DateTime(2000, 01, 02)));
            //    hotel.MakeReservation(new Reservation(new RoomID(1, 3), "REs", new DateTime(2000, 01, 03), new DateTime(2000, 01, 04)));
            //}
            //catch (ReservationConflictExceptions r)
            //{

            //}
            //IEnumerable<Reservation> reservation = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}
