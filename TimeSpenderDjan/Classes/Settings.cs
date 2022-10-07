using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpenderDjan.Classes
{
    public class Settings
    {
        public string TimeBetweenReports { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public int CanSave { get; set; }
        public bool CanDelete { get; set; }
        public string FileName { get; set; }
        public List<string> Tasks = new List<string>();
        
    }
}

