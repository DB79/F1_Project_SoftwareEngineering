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
    public partial class frmRemoveTeam : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmRemoveTeam()
        {
            InitializeComponent();
        }

        private void registerTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegTeam nextForm = new frmRegTeam();
            this.Hide();
            nextForm.Show();
        }

        

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {

            //if the user confirms they want to remove the driver
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove the selected team", "Confrimation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
           try
                {
                    
                    conn = new OracleConnection(oradb);

                     
                    //Updates the status of the selected team to 'I'(inactive)
                    String strSQL = "UPDATE Teams SET Status = 'I' WHERE Team_Name = '" + txtTeamName.Text + "'";

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
               

                //The gui is reset
                txtTeamName.Text = "";
                txtTeamOwner.Text = "";
                txtTeamCountry.Text = "";
                cboBoxTeam.SelectedIndex = -1;
                grpTeam.Visible = false;

                //the teams in the text box are reloaded so that the removed team doesn't still appear
                load();
                
            }

            //if the user says that they do not wish to continue
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void editTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTeam nextForm = new frmEditTeam();
            this.Hide();
            nextForm.Show();
        }

        private void removeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveTeam  nextForm = new frmRemoveTeam();
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
            //Included as the combobox will change to blank when the GUI is reset
            if (cboBoxTeam.Text.Equals(""))
            {
                return;
            }

            else
            {
                

                conn = new OracleConnection(oradb);

                conn.Open();

                //Selects details for the team selected in the combo box
                String querry = "SELECT * FROM Teams WHERE Team_ID = '" + cboBoxTeam.Text.Substring(0, 3) + "'";

                cmd = new OracleCommand(querry, conn);

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Sets the text of the teamName text box to the name retrieved from the teams file
                    txtTeamName.Text = dr.GetString(1).TrimEnd();
                    //Sets the text of the teamOwner text box to the name retrieved from the teams file
                    txtTeamOwner.Text = dr.GetString(2).TrimEnd();
                    //Sets the text of the teamCountry text box to the name retrieved from the teams file
                    txtTeamCountry.Text = (dr.GetString(3)).TrimEnd();


                }

                conn.Close();
                
                //displays the group box containing the text-boxes
                grpTeam.Visible = true;
            }
            }

        private void frmRemoveTeam_Load(object sender, EventArgs e)
        {
            //loads teams into the combo box
            load();
        }

        //fills the team combo box with team_id and team_neme for all activer teams in the teams file
        public void load()
        {
            //clears the teams from the combo box
            cboBoxTeam.Items.Clear();

            conn = new OracleConnection(oradb);

            //Returns team_id an d team _name for all active teams in the teams file ordered by team_id
            String querry = "SELECT Team_ID,Team_Name FROM Teams WHERE Status = 'A' ORDER BY Team_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Adds the team_id and name to the team combo box
                    cboBoxTeam.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        



     
    }
}
