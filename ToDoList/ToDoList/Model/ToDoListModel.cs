using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class ToDoListModel : BaseModel
    {
        #region ToDoList Properties
        public string NewTasks { get; set; }
        public string NewSubTasks { get; set; }
        public string NewStatus { get; set; }
        public DateTime NewStartDate { get; set; }
        public DateTime NewEndDate { get; set; }
        #endregion ToDoList Properties
    }
}
