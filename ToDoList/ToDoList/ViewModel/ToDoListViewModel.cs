using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Model;

namespace ToDoList.ViewModel
{
    public class ToDoListViewModel : BaseModel
    {
        #region ToDoList Properties
        private string _task;
        public string Tasks
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }
        private string _subTasks;
        public string SubTasks
        {
            get
            {
                return _subTasks;
            }
            set
            {
                _subTasks = value;
                OnPropertyChanged(nameof(SubTasks));
            }
        }

        private string _taskStatus;
        public string TaskStatus
        {
            get
            {
                return _taskStatus;
            }
            set
            {
                _taskStatus = value;
                OnPropertyChanged(nameof(TaskStatus));
            }
        }

        private DateTime _startDate = DateTime.Today;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate = DateTime.Today;

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
        #endregion ToDoList Properties

        public List<string> strings { get; set; }
        


    public ObservableCollection<ToDoListModel> _listModels;
        public ObservableCollection<ToDoListModel> ToDoListModels
        {
            get
            {
                return _listModels;
            }
            set 
            {
                _listModels = value;
                OnPropertyChanged(nameof(ToDoListModels));
            }
        }

        public ToDoListModel AddPersonList { get; set; }
        public ICommand AddPersonCommand { get; }
        public ICommand ClearPersonCommand { get; }

        public ToDoListViewModel() 
        {
            ToDoListModels = new ObservableCollection<ToDoListModel>();
            AddPersonCommand = new RelayCommand(AddTask);
            ClearPersonCommand = new RelayCommand(Clear);
        }

        public void AddTask()
        {
            var newList = new ToDoListModel
            {
                NewTasks = Tasks,
                NewSubTasks = SubTasks,
                NewStatus = TaskStatus,
                NewStartDate = StartDate.Date,
                NewEndDate = EndDate.Date
            };

            ToDoListModels.Add(newList);
            Clear();
        }

        public void Clear()
        {
            Tasks = string.Empty; 
            SubTasks = string.Empty;
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }

    public static class EnumStatus
    {
        enum StatusEnum
        {
            NotStarted,
            InProgress,
            Completed
        }
    }
}
