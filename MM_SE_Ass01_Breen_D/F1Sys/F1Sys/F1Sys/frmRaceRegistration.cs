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
    public partial class frmRaceRegistration : Form
    {

        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd,cmdb;

        public frmRaceRegistration()
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

        private void btnRegDriver_Click(object sender, EventArgs e)
        {

            //Displays an error message no race is selected
            if (cboBoxRaceID.Text.Equals(""))
            {
                MessageBox.Show("You must select a race");
                cboBoxRaceID.Focus();
                return;
            }
            
            if(cboDriver.Text.Equals(""))
            {
                MessageBox.Show("You must select a driver");
                cboDriver.Focus();
                return;
            }

            try
            {
                

                //Connect to Database 
                conn = new OracleConnection(oradb);

                //Define SQL Query (UPDATE) 

                String rID = cboBoxRaceID.Text;

                int position = rID.IndexOf(",");

                int raceID = Convert.ToInt16(rID.Substring(0, position));

                String dID = cboDriver.Text;

                int ComaPosition = dID.IndexOf(",");

                int driverID = Convert.ToInt16(dID.Substring(0, ComaPosition));

                String strSQL = "INSERT INTO Registrations (Race_ID,Driver_ID) VALUES (" + raceID + "," + driverID + ")";

                conn.Open();

               

                cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //Execute SQL Query

                
                    cmd.ExecuteNonQuery();
                    //Close Database 
               
                conn.Close();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            MessageBox.Show("The selected driver has been entered into the selected race");

            //Reset GUI

            cboBoxRaceID.SelectedIndex = -1;

            cboDriver.SelectedIndex = -1;

            lblNumEntries.Text = "";

            cboDriver.Items.Clear();
           
        }


        private void frmRaceRegistration_Load(object sender, EventArgs e)
        {
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

                    cboBoxRaceID.Items.Add(reader.GetValue(0).ToString().PadLeft(3,'0') + ", " + reader.GetValue(1).ToString().TrimEnd());
                    


                }

            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmboBoxRaceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxRaceID.Text.Equals(""))
            {
                return;
            }

            if (checkNumEntries() >= 20)
            {
                txtFull.Visible = true;
                txtFull.Text = "The maximum number of drivers have been entered into the selected race.Please continue by selecting a differrent race.";
                cboDriver.Items.Clear();
                lblNumEntries.Visible = false;
                return;
            }

            else
            {

                txtFull.Visible = false;
                cboDriver.Items.Clear();

                

                String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";

                conn = new OracleConnection(oradb);

                //SELECT Driver_ID,Race_ID FROM Registrations WHERE Race_ID != " + cmboBoxRaceID.Text.Substring(0, 3)
                String secondQuerry = "SELECT DISTINCT D.Driver_Name , D.Driver_ID FROM Drivers D WHERE D.Driver_ID NOT IN (SELECT DISTINCT Driver_ID FROM Registrations WHERE Race_ID = " + cboBoxRaceID.Text.Substring(0,3) + ") AND Status = 'A' ORDER BY Driver_ID";


                cmdb = new OracleCommand(secondQuerry, conn);

                OracleDataReader rdr;

                try
                {

                    conn.Open();

                    rdr = cmdb.ExecuteReader();

                    while (rdr.Read())
                    {
                        cboDriver.Items.Add(rdr.GetValue(1).ToString().PadLeft(3, '0') + ", " + rdr.GetValue(0).ToString().TrimEnd());


                    }



                }

                catch (OracleException ex)
                {

                    MessageBox.Show(ex.Message + "There was an error registering the driver");
                }

           }
        }

        public int checkNumEntries()
        {

            String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";

            conn = new OracleConnection(oradb);

            conn.Open();

            String querry = "SELECT COUNT(Driver_ID) FROM Registrations WHERE Race_ID = " + cboBoxRaceID.Text.Substring(0,3) + "  GROUP BY Race_ID";


            cmd = new OracleCommand(querry, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            int numEntries = 0;

            while (dr.Read())
            {
                numEntries = Convert.ToInt32(dr.GetValue(0));
            }


            return numEntries;


        }

        
    }
}
