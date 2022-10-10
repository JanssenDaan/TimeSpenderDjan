namespace TimeSpenderDjan
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxCanSave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltextfile = new System.Windows.Forms.Label();
            this.tbxTextFileName = new System.Windows.Forms.TextBox();
            this.cbxCanDelete = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPickColor2 = new System.Windows.Forms.Button();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cdlColor = new System.Windows.Forms.ColorDialog();
            this.lbxTasksSettings = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxSelectedTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.pcbColorOne = new System.Windows.Forms.PictureBox();
            this.pcbColorTwo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCanSave
            // 
            this.cbxCanSave.AutoSize = true;
            this.cbxCanSave.Location = new System.Drawing.Point(6, 19);
            this.cbxCanSave.Name = "cbxCanSave";
            this.cbxCanSave.Size = new System.Drawing.Size(73, 17);
            this.cbxCanSave.TabIndex = 1;
            this.cbxCanSave.Text = "Can Save";
            this.cbxCanSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltextfile);
            this.groupBox1.Controls.Add(this.tbxTextFileName);
            this.groupBox1.Controls.Add(this.cbxCanDelete);
            this.groupBox1.Controls.Add(this.cbxCanSave);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SaveAndDelete";
            // 
            // lbltextfile
            // 
            this.lbltextfile.AutoSize = true;
            this.lbltextfile.Location = new System.Drawing.Point(28, 94);
            this.lbltextfile.Name = "lbltextfile";
            this.lbltextfile.Size = new System.Drawing.Size(70, 13);
            this.lbltextfile.TabIndex = 4;
            this.lbltextfile.Text = "Textfile name";
            // 
            // tbxTextFileName
            // 
            this.tbxTextFileName.Location = new System.Drawing.Point(7, 110);
            this.tbxTextFileName.Name = "tbxTextFileName";
            this.tbxTextFileName.Size = new System.Drawing.Size(112, 20);
            this.tbxTextFileName.TabIndex = 3;
            // 
            // cbxCanDelete
            // 
            this.cbxCanDelete.AutoSize = true;
            this.cbxCanDelete.Location = new System.Drawing.Point(6, 51);
            this.cbxCanDelete.Name = "cbxCanDelete";
            this.cbxCanDelete.Size = new System.Drawing.Size(79, 17);
            this.cbxCanDelete.TabIndex = 2;
            this.cbxCanDelete.Text = "Can Delete";
            this.cbxCanDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pcbColorTwo);
            this.groupBox2.Controls.Add(this.pcbColorOne);
            this.groupBox2.Controls.Add(this.btnPickColor2);
            this.groupBox2.Controls.Add(this.btnPickColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(144, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // btnPickColor2
            // 
            this.btnPickColor2.Location = new System.Drawing.Point(104, 47);
            this.btnPickColor2.Name = "btnPickColor2";
            this.btnPickColor2.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor2.TabIndex = 3;
            this.btnPickColor2.Text = "Set Color";
            this.btnPickColor2.UseVisualStyleBackColor = true;
            this.btnPickColor2.Click += new System.EventHandler(this.btnPickColor2_Click);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(104, 13);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor.TabIndex = 2;
            this.btnPickColor.Text = "Set Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color 1";
            // 
            // lbxTasksSettings
            // 
            this.lbxTasksSettings.DisplayMember = "TaskName";
            this.lbxTasksSettings.FormattingEnabled = true;
            this.lbxTasksSettings.Location = new System.Drawing.Point(6, 93);
            this.lbxTasksSettings.Name = "lbxTasksSettings";
            this.lbxTasksSettings.Size = new System.Drawing.Size(188, 147);
            this.lbxTasksSettings.TabIndex = 4;
            this.lbxTasksSettings.SelectedIndexChanged += new System.EventHandler(this.lbxTasksSettings_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSelectedTask);
            this.groupBox3.Controls.Add(this.btnAddTask);
            this.groupBox3.Controls.Add(this.btnDeleteTask);
            this.groupBox3.Controls.Add(this.lbxTasksSettings);
            this.groupBox3.Location = new System.Drawing.Point(349, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 249);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tasks";
            // 
            // tbxSelectedTask
            // 
            this.tbxSelectedTask.Location = new System.Drawing.Point(7, 33);
            this.tbxSelectedTask.Name = "tbxSelectedTask";
            this.tbxSelectedTask.Size = new System.Drawing.Size(187, 20);
            this.tbxSelectedTask.TabIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(119, 59);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(7, 59);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 5;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaveSettings);
            this.groupBox4.Location = new System.Drawing.Point(556, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(50, 33);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(104, 42);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // pcbColorOne
            // 
            this.pcbColorOne.Location = new System.Drawing.Point(54, 13);
            this.pcbColorOne.Name = "pcbColorOne";
            this.pcbColorOne.Size = new System.Drawing.Size(44, 23);
            this.pcbColorOne.TabIndex = 4;
            this.pcbColorOne.TabStop = false;
            // 
            // pcbColorTwo
            // 
            this.pcbColorTwo.Location = new System.Drawing.Point(54, 45);
            this.pcbColorTwo.Name = "pcbColorTwo";
            this.pcbColorTwo.Size = new System.Drawing.Size(44, 23);
            this.pcbColorTwo.TabIndex = 5;
            this.pcbColorTwo.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxCanSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxCanDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPickColor2;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdlColor;
        private System.Windows.Forms.Label lbltextfile;
        private System.Windows.Forms.TextBox tbxTextFileName;
        private System.Windows.Forms.ListBox lbxTasksSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxSelectedTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.PictureBox pcbColorTwo;
        private System.Windows.Forms.PictureBox pcbColorOne;
    }
}