using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpenderDjan.Classes
{
    public class What
    {
        public string Time = DateTime.Now.ToString("HH:mm:ss");
        public string WhatDoing { get; set; }

        public string text { get; set; }

        
    }
}
