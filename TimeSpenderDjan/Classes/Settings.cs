using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpenderDjan.Classes
{
    public class Settings
    {
        public string TimeBetweenReports { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public bool CanSave { get; set; }
        public bool CanDelete { get; set; }
        public string FileName { get; set; }
        public int tmrPopup { get; set; }
        public int tmrColor { get; set; }
        public string ExcelFileName { get; set; }
        public bool Status { get; set; }
        public ObservableCollection<What> Whats = new ObservableCollection<What>();
        public ObservableCollection<Task> Tasks = new ObservableCollection<Task>();
        
    }
}

