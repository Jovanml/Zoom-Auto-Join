using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace ZoomAutoJoinManager
{   

    public partial class FormClassList : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=mclejova372;database=zoomdb;");
        public bool isrunning = false;
        public FormClassList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditClass addclass = new AddEditClass();
            addclass.ShowDialog();
        }


        private void FormClassList_Load(object sender, EventArgs e)
        {
           showClassView();        
        }

        private void ClassListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 7 )
                {
                    AddEditClass editclass = new AddEditClass();
                    DataGridViewRow row = ClassListDataGridView.Rows[e.RowIndex];
                    editclass.populateFields(row);
                    editclass.ShowDialog();
                }

                if (e.ColumnIndex == 8)
                {
                    deleteClass(e.RowIndex);
                }
            }
        }

        public void showClassView()
        {
            ClassListDataGridView.Rows.Clear();
            
            MySqlCommand cmd = new MySqlCommand("SELECT * from classes", con);
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rowId = ClassListDataGridView.Rows.Add();
                    DataGridViewRow row = ClassListDataGridView.Rows[rowId];

                    // Add the data
                    row.Cells["classname"].Value = reader["classname"].ToString(); row.Cells["meetingid"].Value = reader["meetingid"].ToString();
                    row.Cells["meetingpasscode"].Value = reader["meetingpasscode"].ToString(); row.Cells["studentname"].Value = reader["studentname"].ToString();
                    row.Cells["starttime"].Value = reader["starttime"].ToString(); row.Cells["endtime"].Value = reader["endtime"].ToString();
                    row.Cells["dayofweek"].Value = reader["dayofweek"].ToString();

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void deleteClass(int rowI)
        {
            try
            {
                con.Open();

                DataGridViewRow row = ClassListDataGridView.Rows[rowI];
                String query = "DELETE FROM classes where classname = \"" + row.Cells["classname"].Value.ToString() + "\"";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showClassView();

        }

        private void automatebtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            int pid = 0;

            if (!isrunning)
            {
                string fileName = "join.exe";
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"dist\join\", fileName);
                psi.FileName = path;
                psi.UseShellExecute = false;
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;
                psi.Arguments = "";
                psi.CreateNoWindow = true;
                Process proc = new Process();
                proc.StartInfo = psi;
                proc.Start();
                pid = proc.Id;

                automatebtn.BackColor = Color.FromArgb(219, 88, 96);
                automatebtn.Text = "Stop Automation";
                isrunning = true;

            }
            else
            {
                automatebtn.BackColor = Color.FromArgb(48, 209, 184);
                automatebtn.Text = "Start Automation";
                isrunning = false;

                if (pid == 0)
                {
                    return;
                }
                else
                {
                    Process proc = Process.GetProcessById(pid);
                    proc.Kill();
                }
                
                
            }
        }
    }

    
}

