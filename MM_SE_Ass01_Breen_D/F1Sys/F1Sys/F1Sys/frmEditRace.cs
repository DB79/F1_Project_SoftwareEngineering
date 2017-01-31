using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace F1Sys
{
    public partial class frmEditRace : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        DateTime dt = DateTime.Now;

        public frmEditRace()
        {
            InitializeComponent();
        }


        private void registerTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegTeam nextForm = new frmRegTeam();
            this.Hide();
            nextForm.Show();
        }

        private void editTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTeam nextForm = new frmEditTeam();
            this.Hide();
            nextForm.Show();
        }

        private void removeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveTeam nextForm = new frmRemoveTeam();
            this.Hide();
            nextForm.Show();
        }

        private void registerDriverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegDriver nextForm = new frmRegDriver();
            this.Hide();
            nextForm.Show();
        }

        private void editDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditDriver nextForm = new frmEditDriver();
            this.Hide();
            nextForm.Show();
        }

        private void removeDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveDriver nextForm = new frmRemoveDriver();
            this.Hide();
            nextForm.Show();
        }

        private void listDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers nextForm = new frmListDrivers();
            this.Hide();
            nextForm.Show();
        }

        private void scheduleRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleRace nextForm = new frmScheduleRace();
            this.Hide();
            nextForm.Show();
        }

        private void editRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditRace nextForm = new frmEditRace();
            this.Hide();
            nextForm.Show();
        }

        private void raceRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaceRegistration nextForm = new frmRaceRegistration();
            this.Hide();
            nextForm.Show();
        }

        private void recordTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordRaceTimes nextForm = new frmRecordRaceTimes();
            this.Hide();
            nextForm.Show();
        }

        private void raceResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRaceResults nextForm = new frmShowRaceResults();
            this.Hide();
            nextForm.Show();
        }

        private void seasonStandinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeasonStandings nextForm = new frmSeasonStandings();
            this.Hide();
            nextForm.Show();
        }

        private void cmboBoxRaceID_SelectedIndexChanged(object sender, EventArgs e)
        {

            int raceID = Convert.ToInt32(cboRace.Text.Substring(0, 3));
  

            grpBoxRace.Visible = (true);

 
            conn = new OracleConnection(oradb);

            conn.Open();

            

            try
            {
                String querry = "SELECT * FROM RACES WHERE Race_ID = " + raceID;

                cmd = new OracleCommand(querry, conn);

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    try
                    {
                        dtpRaceDate.Value = reader.GetDateTime(2);
                    }

                    //Displays a message if the race date returned is before the current time.
                    //This means that you cannot modify a race scheduled for today or for a day in the past
                    catch (ArgumentOutOfRangeException a)
                    {

                        grpBoxRace.Visible = false;
                        MessageBox.Show("The selected race has already taken place or has been scheduled for today.");
                        loadDetails();
                    }


                    txtRaceLocation.Text = reader.GetString(1).TrimEnd();





                } 
               
                conn.Close();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }


            
        }

        private void btnUpdateRace_Click(object sender, EventArgs e)
        {
            


            if (cboRace.Text.Equals(""))
            {
                MessageBox.Show("You must select a race");
                return;
            }

            int raceID = Convert.ToInt32(cboRace.Text.Substring(0, 3));

            //Validate the new details

            loadDetails();

            if(txtRaceLocation.Text.Equals(""))
            {
                MessageBox.Show("You must enter a race Location");
                txtRaceLocation.Focus();
                return;
            }


            conn = new OracleConnection(oradb);

            conn.Open();

            try
            {



                String querry = "UPDATE Races SET Race_Location = '" + txtRaceLocation.Text + "',Start_Date = '" + dtpRaceDate.Text + "' WHERE Race_ID = " + raceID;

                cmd = new OracleCommand(querry, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("The Race has been updated.");

                conn.Close();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message + cboRace.Text);
            }

           

            cboRace.SelectedIndex = -1;
            grpBoxRace.Visible = false;

        }

        private void frmEditRace_Load(object sender, EventArgs e)
        {

            dtpRaceDate.MinDate = dt;

            loadDetails();
           
 
        }

        public void loadDetails()
        {

            cboRace.Items.Clear();
            

            conn = new OracleConnection(oradb);

            String querry = "SELECT Race_ID,Race_Location FROM Races ORDER BY Race_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    
                    cboRace.Items.Add(reader.GetValue(0).ToString().PadLeft(3,'0') + ", " + reader.GetValue(1).ToString());



                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
