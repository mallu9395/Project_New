using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReservationSystem.ViewModel
{
    /// <summary>
    /// Everything MakeReservationView Needs to bind
    /// </summary>
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username 
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value; //whatever you type in textbox it set the value here 
                OnPropertyChanged(nameof(Username));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value; //whatever you type in textbox it set the value here 
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value; //whatever you type in textbox it set the value here 
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value; //whatever you type in textbox it set the value here 
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value; //whatever you type in textbox it set the value here 
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel()
        {
            //init all commands
        }
    }
}
