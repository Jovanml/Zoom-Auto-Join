
namespace ZoomAutoJoinManager
{
    partial class FormClassList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newbtn = new System.Windows.Forms.Button();
            this.ClassListDataGridView = new System.Windows.Forms.DataGridView();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingpasscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ClassListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.newbtn.FlatAppearance.BorderSize = 0;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.Color.White;
            this.newbtn.Location = new System.Drawing.Point(36, 18);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(120, 38);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New Class";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassListDataGridView
            // 
            this.ClassListDataGridView.AllowUserToAddRows = false;
            this.ClassListDataGridView.AllowUserToDeleteRows = false;
            this.ClassListDataGridView.AllowUserToResizeColumns = false;
            this.ClassListDataGridView.AllowUserToResizeRows = false;
            this.ClassListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClassListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classname,
            this.meetingid,
            this.meetingpasscode,
            this.studentname,
            this.starttime,
            this.endtime,
            this.dayofweek,
            this.edit,
            this.delete});
            this.ClassListDataGridView.GridColor = System.Drawing.Color.White;
            this.ClassListDataGridView.Location = new System.Drawing.Point(36, 74);
            this.ClassListDataGridView.MultiSelect = false;
            this.ClassListDataGridView.Name = "ClassListDataGridView";
            this.ClassListDataGridView.ReadOnly = true;
            this.ClassListDataGridView.RowHeadersVisible = false;
            this.ClassListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClassListDataGridView.ShowEditingIcon = false;
            this.ClassListDataGridView.Size = new System.Drawing.Size(1082, 406);
            this.ClassListDataGridView.TabIndex = 0;
            this.ClassListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassListDataGridView_CellContentClick);
            // 
            // classname
            // 
            this.classname.HeaderText = "Class Name";
            this.classname.Name = "classname";
            this.classname.ReadOnly = true;
            // 
            // meetingid
            // 
            this.meetingid.HeaderText = "Meeting ID";
            this.meetingid.Name = "meetingid";
            this.meetingid.ReadOnly = true;
            // 
            // meetingpasscode
            // 
            this.meetingpasscode.HeaderText = "Meeting Passcode";
            this.meetingpasscode.Name = "meetingpasscode";
            this.meetingpasscode.ReadOnly = true;
            // 
            // studentname
            // 
            this.studentname.HeaderText = "Student Name";
            this.studentname.Name = "studentname";
            this.studentname.ReadOnly = true;
            // 
            // starttime
            // 
            this.starttime.HeaderText = "Start Time";
            this.starttime.Name = "starttime";
            this.starttime.ReadOnly = true;
            // 
            // endtime
            // 
            this.endtime.HeaderText = "End Time";
            this.endtime.Name = "endtime";
            this.endtime.ReadOnly = true;
            // 
            // dayofweek
            // 
            this.dayofweek.HeaderText = "Day of Week";
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.ReadOnly = true;
            // 
            // edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 132);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Manager";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ClassListDataGridView);
            this.panel2.Controls.Add(this.newbtn);
            this.panel2.Location = new System.Drawing.Point(41, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 495);
            this.panel2.TabIndex = 0;
            // 
            // FormClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClassList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Manager";
            this.Load += new System.EventHandler(this.FormClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.DataGridView ClassListDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingid;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingpasscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweek;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

