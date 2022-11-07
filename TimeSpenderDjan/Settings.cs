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

namespace TimeSpenderDjan
{
    public partial class Settings : Form
    {
        public ObservableCollection<Classes.Task> t = new ObservableCollection<Classes.Task>();

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

            //foreach (What w in x)
            //{
            //    foreach (Classes.Task t in y)
            //    {
            //        if (t.TaskName == w.WhatDoing)
            //        {

            //        }
            //        else
            //        {
            //            a.Add(new Classes.Task { TaskName = w.WhatDoing });
            //        }
            //    }
            //}
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

            fileinfo = new FileInfo(ExcelFileName);
            xlApp = new Excel.Application();
            if (fileinfo.Extension == ".xlsx")
            {
                ExcelFileName = ExcelFileName.Remove(ExcelFileName.Length - 1);
            }

            ExcelFileName = "C:\\Users\\daanm\\Downloads\\test2.xls";

            if (File.Exists(ExcelFileName))
            {
                xlwb = xlApp.Workbooks.Open(ExcelFileName);
                xlws = xlwb.Sheets[1];
                xlrng = xlws.UsedRange;
            }
            else
            {
                //xlwb = xlApp.Workbooks.Add(MisValue);
                //xlws = (Worksheet)xlwb.Worksheets.get_Item(1);
                //xlwb.SaveAs(ExcelFileName, XlFileFormat.xlWorkbookNormal, MisValue, MisValue, MisValue, MisValue, XlSaveAsAccessMode.xlExclusive, MisValue, MisValue, MisValue, MisValue, MisValue);
                //xlrng = xlws.UsedRange;
            }

            if (xlrng.Cells[1,1] != null && xlrng[1,1].Value2 != null)
            {
                MessageBox.Show(xlrng.Cells[1,1].Value);
            }
            
        }
    }
}
