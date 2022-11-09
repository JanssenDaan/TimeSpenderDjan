using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSpenderDjan.Classes;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using CsvHelper;
using System.Globalization;
using TimeSpenderDjan.Classes;

namespace TimeSpenderDjan
{
    public partial class Settings : Form
    {
        public ObservableCollection<Classes.Task> t = new ObservableCollection<Classes.Task>();
        public ObservableCollection<Classes.Task> exTasks = new ObservableCollection<Classes.Task>();

        public ObservableCollection<What> ExcelRead = new ObservableCollection<What>();
        public SortableForm sortForm = new SortableForm();
        string value1;
        string value2;
        bool value3;
        string value4;
        // excel
        public string ExcelFileName;
        Workbook xlwb;
        Worksheet xlws;
        object MisValue = System.Reflection.Missing.Value;
        Range xlrng = null;
        Excel.Application xlApp = null;
        FileInfo fileinfo = null;

        public Settings()
        {
            InitializeComponent();
            this.ControlBox = false;
            ExcelFileName = Form1.form.settings.ExcelFileName;
            ExcelFileName = "C:\\Users\\daanm\\Downloads\\test.xlsx";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            t.Clear();
            foreach (Classes.Task x in lbxTasksSettings.Items)
            {
                t.Add(new Classes.Task { TaskName = x.TaskName }) ;
            }

            Form1.form.settings = new Classes.Settings {
                CanDelete = cbxCanDelete.Checked,
                CanSave = cbxCanSave.Checked,
                Color1 = pcbColorOne.BackColor,
                Color2 = pcbColorTwo.BackColor,
                FileName = tbxTextFileName.Text.ToLower(),
                Whats = Form1.form.DoingList,
                tmrColor = Convert.ToInt32(nudColors.Value),
                tmrPopup = Convert.ToInt32(nudPopup.Value),
                Tasks = t,
                Status = Form1.form.settings.Status
                };
            

            string Json = Newtonsoft.Json.JsonConvert.SerializeObject(Form1.form.settings);
            File.WriteAllText("config.txt", Json);

            if (Form1.form.settings.Status == true)
            {
                Form1.form.StartTimers();
            }  
            else
            {
                Form1.form.StopTimers();
            }
            Form1.form.CloseForm();
            Form1.form.ReloadSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Form1.form.settings.Status == true)
            {
                pcbStatus.BackColor = Color.Lime;
            }
            else
            {
                pcbStatus.BackColor = Color.Red;
            }
            cbxCanDelete.Checked = Form1.form.settings.CanDelete;
            cbxCanSave.Checked = Form1.form.settings.CanSave;
            pcbColorOne.BackColor = Form1.form.settings.Color1;
            pcbColorTwo.BackColor = Form1.form.settings.Color2;
            tbxTextFileName.Text = Form1.form.settings.FileName;
            if (Form1.form.settings.tmrColor == 0)
            {
                Form1.form.settings.tmrColor = 500;
            }
            if (Form1.form.settings.tmrPopup == 0)
            {
                Form1.form.settings.tmrPopup = 3;
            }
            nudColors.Value = Form1.form.settings.tmrColor;
            nudPopup.Value = Form1.form.settings.tmrPopup;
            foreach (var x in Form1.form.settings.Tasks)
            {
                lbxTasksSettings.Items.Add(x);
            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            cdlColor.ShowDialog();
            pcbColorOne.BackColor = cdlColor.Color;
        }

        private void btnPickColor2_Click(object sender, EventArgs e)
        {
            cdlColor.ShowDialog();
            pcbColorTwo.BackColor = cdlColor.Color;
        }

        private void lbxTasksSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTasksSettings.SelectedItem is Classes.Task x)
            {
                tbxSelectedTask.Text = x.TaskName;
            }            
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            foreach (Classes.Task x in lbxTasksSettings.Items)
            {
                if (x.TaskName == tbxSelectedTask.Text)
                {
                    lbxTasksSettings.Items.Remove(x);
                    return;
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            lbxTasksSettings.Items.Add(new Classes.Task
            {
                TaskName = tbxSelectedTask.Text
            });
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            pcbStatus.BackColor = Color.Red;
            Form1.form.settings.Status = false;
        }

        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            pcbStatus.BackColor = Color.Lime;
            Form1.form.settings.Status = true;
        }

        private void btnShowCharts_Click(object sender, EventArgs e)
        {
            var x = Form1.form.DoingList;

            

            var y = Form1.form.settings.Tasks;
            var a = Form1.form.settings.Tasks;

            
            foreach (What what in x)
            {
                if (what.StandardTask == false)
                {
                    a.Add(new Classes.Task { TaskName = what.WhatDoing });
                }
            }
            ChartsForm c = new ChartsForm(x, a);
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.form.DoingList.Clear();
            string Json = Newtonsoft.Json.JsonConvert.SerializeObject(Form1.form.DoingList);
            Form1.form.ClearItems();
            File.WriteAllText(Form1.form.settings.FileName + ".txt", Json);

        }

        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            ExcelReadClass excelFile = new ExcelReadClass();
            string preview = "";

            var dialogResult = ofdRead.ShowDialog();

            if (dialogResult != DialogResult.OK || ofdRead.FileName == null)
            {
                return;
            }
            var data = excelFile.readFileData(ofdRead.FileName);

            for (int i = 0; i < data.Count; i += 4)
            {
                preview += string.Format("{0}\n{1}\n{2}\n{3}\n", data[i], data[i + 1], data[i + 2], data[i + 3]);

                // Convert the strings back into their intended datatype
                bool isDefault = data[i + 2] == "WAAR";
                DateTime date = DateTime.FromOADate(double.Parse(data[i + 3]));
            }

            rtbExcel.Text = preview;

            excelFile.Close();
        }

        private void btnToObj_Click(object sender, EventArgs e)
        {
            int i = 1; ;
            foreach (string r in rtbExcel.Lines)
            {
                switch (i)
                {
                    case 1:
                        value1 = r;
                        break;
                    case 2:
                        value2 = r;
                        break;
                    case 3:
                        value3 = Convert.ToBoolean(r);
                        break;
                    case 4:
                        value4 = r;
                        ExcelRead.Add(new What { WhatDoing = value1, SecondsPassed = Convert.ToInt32(value2), StandardTask = value3, Time = Convert.ToInt32(value4) });

                        break;
                    case 5:

                        
                        break;
                    
                        
                }
                if (i == 4)
                {
                    i = 1;
                }
                else
                {
                    i++;
                }
            }
        }

        private void toSortChart_Click(object sender, EventArgs e)
        {
            //CreateTaskListFromExcelTasks
            foreach (What w in ExcelRead)
            {
                Classes.Task t = new Classes.Task { TaskName = w.WhatDoing };
                if (exTasks.Contains(t))
                {

                }
                else
                {
                    exTasks.Add(new Classes.Task
                    {
                        TaskName = w.WhatDoing
                    });
                }
            }
            sortForm = new SortableForm(whats: ExcelRead, tasks: exTasks);
            sortForm.Show();
        }
    }
}

