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
using System.Windows.Forms.DataVisualization.Charting;
using TimeSpenderDjan.Classes;

namespace TimeSpenderDjan
{
    public partial class ChartsForm : Form
    {
        public ObservableCollection<What> w;
        public ObservableCollection<Classes.Task> t;
        Random r = new Random();
        public int i = 1;
        public static ObservableCollection<Classes.TotalTasks> TotalTasks = new ObservableCollection<Classes.TotalTasks>();
        public ChartsForm(ObservableCollection<What> x, ObservableCollection<Classes.Task> y)
        {
            InitializeComponent();
            w = x;
            t = y;
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            CalculateTotal();

        }
        public void CalculateTotal()
        {
            TotalTasks.Clear();

            //foreach (Classes.Task task in t)
            //{
            //    y.Series.Add(task.TaskName);
            //}

            foreach (Classes.Task task in t)
            {
                TotalTasks.Add(new Classes.TotalTasks
                {
                    TaskName = task.TaskName
                });
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

            //foreach (TotalTasks tt in TotalTasks)
            //{
            //    y.Series[tt.TaskName.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //    y.Series[tt.TaskName.ToString()].Points.Add(tt.Total);

            //}

            int i = 0;
            foreach (TotalTasks tt in TotalTasks)
            {
              
                Color c = new Color();
                c = Color.FromArgb(Convert.ToInt32(r.Next(1,255)), Convert.ToInt32(r.Next(1, 255)), Convert.ToInt32(r.Next(1, 255)));


                ViewChart.Series["WhatDoing"].Points.Add(tt.Total);
                ViewChart.Series["WhatDoing"].Points[i].AxisLabel = tt.TaskName;
                ViewChart.Series["WhatDoing"].Points[i].Color = c;
                i++;

            }
            //ViewChart = y;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                ViewChart.Series["WhatDoing"].ChartType = SeriesChartType.Column;
            }
            if (i == 2)
            {
                ViewChart.Series["WhatDoing"].ChartType = SeriesChartType.Pie;
            }
            if (i == 3)
            {
                ViewChart.Series["WhatDoing"].ChartType = SeriesChartType.Bar;
            }
            if (i == 4)
            {
                i = 1;
                return;
            }
            i++;
        }
    }
}
