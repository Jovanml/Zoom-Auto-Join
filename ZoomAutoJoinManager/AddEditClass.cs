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

namespace ZoomAutoJoinManager
{
    public partial class AddEditClass : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=mclejova372;database=zoomdb;");
        public bool add = true;

        public AddEditClass()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(add == true)
            {
                addClass();
            }
            else
            {
                updateClass();
            }   

            Hide();
        }

        public void addClass()
        {
            try
            {
                con.Open();

                String query = "INSERT INTO classes (classname,meetingid,meetingpasscode,studentname,starttime,endtime,dayofweek,duration)" +
                " values('" + txtClassName.Text + "','" + txtMeetingId.Text + "','" + txtMeetingPasscode.Text + "','" + txtStudentName.Text + "','"
                + txtStartTime.Text + "','" + txtEndTime.Text + "','" + txtDayOfWeek.Text + "','" + txtDuration.Text + "')";

                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateClass()
        {
            try
            {
                con.Open();

                String query = "UPDATE classes SET " + "meetingid='" + txtMeetingId.Text + "',meetingpasscode='" + txtMeetingPasscode.Text + "',studentname='" + txtStudentName.Text 
                + "',starttime='" + txtStartTime.Text + "',endtime='" + txtEndTime.Text + "',dayofweek='" + txtDayOfWeek.Text + "',duration='" + txtDuration.Text + 
                "' WHERE classname='" + txtClassName.Text + "'";

                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void populateFields(DataGridViewRow row)
        {
            txtClassName.Text = row.Cells["classname"].Value.ToString();
            txtMeetingId.Text = row.Cells["meetingid"].Value.ToString();
            txtMeetingPasscode.Text = row.Cells["meetingpasscode"].Value.ToString();
            txtStudentName.Text = row.Cells["studentname"].Value.ToString();
            txtStartTime.Text = row.Cells["starttime"].Value.ToString();
            txtEndTime.Text = row.Cells["endtime"].Value.ToString();
            txtDayOfWeek.Text = row.Cells["dayofweek"].Value.ToString();
            txtDuration.Text = row.Cells["duration"].Value.ToString();
            add = false;
            txtClassName.ReadOnly = true;
        }

    }
}
