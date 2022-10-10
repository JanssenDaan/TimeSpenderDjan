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

namespace TimeSpenderDjan
{
    public partial class Settings : Form
    {
        public ObservableCollection<Classes.Task> t = new ObservableCollection<Classes.Task>();
        public Settings()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
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
                Tasks = t
                };

            string Json = Newtonsoft.Json.JsonConvert.SerializeObject(Form1.form.settings);
            File.WriteAllText("config.txt", Json);
            Form1.form.CloseForm();
            Form1.form.ReloadSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cbxCanDelete.Checked = Form1.form.settings.CanDelete;
            cbxCanSave.Checked = Form1.form.settings.CanSave;
            pcbColorOne.BackColor = Form1.form.settings.Color1;
            pcbColorTwo.BackColor = Form1.form.settings.Color2;
            tbxTextFileName.Text = Form1.form.settings.FileName;
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
    }
}
