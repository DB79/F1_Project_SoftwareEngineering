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
    public partial class frmRemoveDriver : Form
    {

        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd; 

        public frmRemoveDriver()
        {
            InitializeComponent();
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove the selected team", "Confrimation", MessageBoxButtons.YesNo);
            
            //continues to update the status if the user confirms they want to continue
            if (dialogResult == DialogResult.Yes)
            {
               
                try
                {
                    
                    
                    conn= new OracleConnection(oradb);

                    //Updates  the status of the sellected driver to 'I'(inactive)
                    String strSQL = "UPDATE Drivers SET Status = 'I' WHERE Driver_Name = '" + txtDriveName.Text + "'";

                    conn.Open();

                    cmd = conn.CreateCommand();

                    cmd.CommandText = strSQL;

                    cmd.ExecuteNonQuery();
                   
                    conn.Close();
                }

                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                //Resets the GUI
                txtDriveName.Text = "";
                txtDriverCountry.Text = "";
                txtDriverTeam.Text = "";
                cboDrivers.SelectedIndex = -1;
                grpDriverDetails.Visible = false;
                //Reloads the drivers in the combo box so that the driver removed is no longer included
                load();

            }

            //returns if the user does not wish to continue with the removing of the driver
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
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

        private void cmboBoxTeamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Used as the text will be empty when the GUI is reset
            if(cboDrivers.Text.Equals(""))
            {
                return;
            }

            grpDriverDetails.Visible = true;
           
            conn = new OracleConnection(oradb);

            conn.Open();

            //returns the driver details for the selected driver
            String querry = "SELECT Driver_Name,D.Country,T.Team_ID,T.Team_Name FROM Drivers D,Teams T WHERE Driver_ID = '" + cboDrivers.Text.Substring(0,3) + "' AND T.Team_ID = D.Team_ID";

            cmd = new OracleCommand(querry, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Sets the driver name to the name that was returned from the drivers file
                txtDriveName.Text = dr.GetString(0).TrimEnd();
                //Sets the driver country to the country that was returned from the drivers file
                txtDriverCountry.Text = (dr.GetString(1));
                //Sets the driver team to the team_id and name that was returned from the drivers file
                txtDriverTeam.Text = (dr.GetValue(2).ToString().PadLeft(3,'0') + ", " + dr.GetString(3).TrimEnd());


            }

            conn.Close(); 
        }


        private void frmRemoveDriver_Load(object sender, EventArgs e)
        {
            //loads the drivers into the combo box
            load();
        }

        //Adds the drivers id and name to the drivers combo box
        public void load()
        {

            //removes drivers from the drivers combo box
            cboDrivers.Items.Clear();
           
            conn = new OracleConnection(oradb);

            //returns the driver_id and driver_name for all active drivers in the drivers file ordered by driver_id
            String querry = "SELECT Driver_ID,Driver_Name FROM Drivers WHERE Status = 'A' ORDER BY Driver_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Adds the drivers to the drivers combo box
                    cboDrivers.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
