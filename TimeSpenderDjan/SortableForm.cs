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
    public partial class SortableForm : Form
    {
        public ObservableCollection<What> w = new ObservableCollection<What>();
        public ObservableCollection<Classes.Task> t = new ObservableCollection<Classes.Task>();
        public static ObservableCollection<Classes.TotalTasks> TotalTasks = new ObservableCollection<Classes.TotalTasks>();
        Classes.TotalTasks LastTask;
        List<TotalTasks> tempTotal = new List<TotalTasks>();

        int i;

        Random r = new Random();

        public SortableForm(ObservableCollection<What> whats = null, ObservableCollection<Classes.Task> tasks = null)
        {
            InitializeComponent();

            
            if (whats != null && tasks != null)
            {
                w = whats;
                t = tasks;
            }

            if (tasks == null)
            {
                return;
            }

            foreach (Classes.Task t in tasks)
            {

                TotalTasks x = new TotalTasks
                {
                    TaskName = t.TaskName,
                    Total = 0
                };
                if (LastTask != null)
                {
                    if (LastTask.TaskName == x.TaskName)
                    {

                    }
                    else
                    {
                        TotalTasks.Add(new Classes.TotalTasks { TaskName = t.TaskName, Total = 0 });
                    }

                }
                else
                {
                    TotalTasks.Add(new Classes.TotalTasks { TaskName = t.TaskName, Total = 0 });
                }
                LastTask = x;
            }



            foreach (Classes.What what in w)
            {
                foreach (TotalTasks totalTasks in TotalTasks)
                {
                    if (what.WhatDoing == totalTasks.TaskName)
                    {
                        totalTasks.Total = totalTasks.Total + what.SecondsPassed;
                    }
                }
            }

            int i = 0;
            foreach (TotalTasks tt in TotalTasks)
            {

                Color c = new Color();
                c = Color.FromArgb(Convert.ToInt32(r.Next(1, 255)), Convert.ToInt32(r.Next(1, 255)), Convert.ToInt32(r.Next(1, 255)));


                ViewChart.Series["WhatDoing"].Points.Add(tt.Total);
                ViewChart.Series["WhatDoing"].Points[i].AxisLabel = tt.TaskName;
                ViewChart.Series["WhatDoing"].Points[i].Color = c;
                i++;

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tempTotal.Clear();
            if (cbxSort.Text == "Ascending")
            {
                tempTotal = new List<TotalTasks>(TotalTasks.OrderBy(x => x.Total).ToList());
            }
            else if (cbxSort.Text == "Descending")
            {
                tempTotal = new List<TotalTasks>(TotalTasks.OrderByDescending(x => x.Total).ToList());
            }

            int d = Convert.ToInt32(cbxDate.Text);


            ViewChart.Series["WhatDoing"].Points.Clear();
            foreach (TotalTasks tt in tempTotal)
            {

                Color c = new Color();
                c = Color.FromArgb(Convert.ToInt32(r.Next(1, 255)), Convert.ToInt32(r.Next(1, 255)), Convert.ToInt32(r.Next(1, 255)));


                ViewChart.Series["WhatDoing"].Points.Add(tt.Total);
                ViewChart.Series["WhatDoing"].Points[i].AxisLabel = tt.TaskName;
                ViewChart.Series["WhatDoing"].Points[i].Color = c;
                i++;

            }
            i = 0;
        }
    }
}
