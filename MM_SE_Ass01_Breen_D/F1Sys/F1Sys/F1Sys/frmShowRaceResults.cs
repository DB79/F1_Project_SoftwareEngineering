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
    public partial class frmShowRaceResults : Form
    {

        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmShowRaceResults()
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


        private void frmShowRaceResults_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(oradb);

            //Return a list of all races and race_id
            String querry = "SELECT Race_ID,Race_Location FROM Races ORDER BY Race_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Add the race_idd and location to a text box
                    cboBoxRace.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString());



                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(oradb);

            //Return the driver_id,driver,team,country,time and points for the race which was selected from the combo box
            cmd = new OracleCommand("SELECT R.Driver_ID AS ID, D.Driver_Name AS NAME, T.Team_Name AS TEAM, D.Country,Race_Time AS Time, SUM(Points) AS Points " +
                                    "FROM Registrations R,Drivers D, Teams T WHERE D.Driver_ID = R.Driver_ID AND T.Team_ID = D.Team_ID AND Race_ID = " + cboBoxRace.Text.Substring(0,3) + 
                                    "GROUP BY R.Driver_ID ,D.Driver_Name,T.Team_name,D.Country,Race_Time ORDER BY Race_Time", conn);

           
            cmd.CommandType = CommandType.Text;

            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            
            DataSet ds = new DataSet();

            
            da.Fill(ds, "ss".TrimEnd());

            
            grdData.DataSource = ds.Tables["ss".TrimEnd()];
             

            grdData.Visible = true;

            conn.Close();
            
        }
    }
}
