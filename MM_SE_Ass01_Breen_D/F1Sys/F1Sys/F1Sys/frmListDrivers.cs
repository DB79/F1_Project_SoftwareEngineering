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
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
           
            getDrivers("Driver_ID");
            
        }

        private void radioBtnID_CheckedChanged(object sender, EventArgs e)
        {
            //Order drivers by driver id
            getDrivers("Driver_ID");

        }

        private void radioBtnDriverName_CheckedChanged(object sender, EventArgs e)
        {
            //Order drivers by driver names
            getDrivers("Driver_Name");
        }

        private void radioBtnTeamName_CheckedChanged(object sender, EventArgs e)
        {
            getDrivers("Team_Name");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print the grid data
            MessageBox.Show("The data is now being printed");
        }

        private void getDrivers(String sortOrder)
        {

           
            string oradb = "Data Source=Oracle;User Id=t00171168;Password=p9udna7n;";
            try
            {
                
                OracleConnection conn = new OracleConnection(oradb);

             
                OracleCommand cmd = new OracleCommand("SELECT Driver_ID AS ID,Driver_Name AS Name,D.Country ,Team_Name AS Team " +
                                                      "FROM Drivers D,Teams T WHERE D.Status = 'A' AND T.Team_ID = D.Team_ID ORDER BY " + sortOrder, conn);

               
                cmd.CommandType = CommandType.Text;

                
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                
                DataSet ds = new DataSet();

               
                da.Fill(ds, "ss".Trim());

                
                grdData.DataSource = ds.Tables["ss".Trim()];
                
                conn.Close();
            }

            
            catch (OracleException ex)
            {
                MessageBox.Show("The System was unable to connect to the database");
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
