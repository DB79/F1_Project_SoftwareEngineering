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
    public partial class frmSeasonStandings : Form
    {

        string oradb = "Data Source=Oracle;User Id=t00171168;Password=p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmSeasonStandings()
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

        private void frmSeasonStandings_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(oradb);

            //Returns driver_id,name,team,country and the total number of points for all drivers who have been entered into a race
            cmd = new OracleCommand("SELECT R.Driver_ID AS ID, D.Driver_Name AS NAME, T.Team_Name AS TEAM, D.Country, SUM(Points) AS Pts " +
                                                  "FROM Registrations R,Drivers D, Teams T WHERE D.Driver_ID = R.Driver_ID AND T.Team_ID = D.Team_ID " +
                                                  "GROUP BY R.Driver_ID ,D.Driver_Name,T.Team_name,D.Country ORDER BY SUM(Points) DESC", conn);

           
            cmd.CommandType = CommandType.Text;

            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            
            DataSet ds = new DataSet();

           
            da.Fill(ds, "ss".TrimEnd());

            
            grdSeasonData.DataSource = ds.Tables["ss".TrimEnd()];
           

            grdSeasonData.Visible = true;

            conn.Close();
        
        }

       
        
    }
}
