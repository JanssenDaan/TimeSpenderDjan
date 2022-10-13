using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSpenderDjan.Classes;

namespace TimeSpenderDjan
{
    public partial class ChartsForm : Form
    {
        public ObservableCollection<What> w;
        public ObservableCollection<Classes.Task> t;
        public ChartsForm(ObservableCollection<What> x, ObservableCollection<Classes.Task> y)
        {
            InitializeComponent();
            w = x;
            t = y;
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            ViewChart.Series.Clear();
            foreach (Classes.Task task in t)
            {
                ViewChart.Series.Add(task.TaskName);
            }
            foreach (Classes.What what in w)
            {
                ViewChart.Series[what.WhatDoing.ToString()].Points.Add(what.SecondsPassed);
            }
        }
    }
}
