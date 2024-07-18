using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.ViewModel
{
    /// <summary>
    /// provide binding for main window responsible for displaying current viewmodel of the application 
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        //Readonly
        public ViewModelBase CurrentViewModel { get; }

        //Here Current viewmodel will be passed and this is connected to App.xaml.cs
        public MainViewModel()
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
