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
    public partial class frmEditDriver : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmEditDriver()
        {
            InitializeComponent();
        }

        private void registerTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegDriver nextForm = new frmRegDriver();
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

        

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            
            //Displays an error if no text has been entered or if the text entered contains any illegal characters.
            if (txtDriverName.Text.Equals("") || validChar(txtDriverName.Text) == false)
            {

                MessageBox.Show("Please re-enter the drivers name");
                txtDriverName.Focus();
                txtDriverName.Text = "";
                return;
            }


            //Displays an error if no text has been entered or if the text entered contains any illegal characters.
            if (cboBoxDriverCountry.Text.Equals(""))
            {

                MessageBox.Show("Driver country must be entered");
                cboBoxDriverCountry.Focus();
         
                return;
            }

            //Displays if no teams has been selected
            if (cboBoxDriverTeam.Text.Equals(""))
            {

                MessageBox.Show("Driver team must be entered");
                cboBoxDriverTeam.Focus();
                return;
            }

            

            //Any team can have only two active drivers at a time.
            //An error is displayed when you try to registered with a team that already has the maximum number of drivers
            /*if (numActiveTeamDrivers(cboBoxDriverTeam.Text.Substring(0, 3)) >= 2)
            {

                MessageBox.Show("The sleceted team has the maximum number of team members");
                cboBoxDriverTeam.SelectedIndex = -1;
                return;
            }

            */

            //When the above code was executed it could not be passed as it was seeing two drivers registered for the team
            //instead of the current driver plus other drivers.
            //By removing this it means that when a driver is modified they can be added to a team that already has 2 members. 





            conn = new OracleConnection(oradb);

            conn.Open();


            
            try
            {

                //Updates details for the selected driver_id
                String querry = "UPDATE Drivers SET Driver_Name = '" + txtDriverName.Text.Trim() + "',Country = '" + cboBoxDriverCountry.Text + "',Team_ID = '" + cboBoxDriverTeam.Text.Substring(0, 3) + "' WHERE Driver_ID = '" + cboDrivers.Text.Substring(0, 3) + "'";

                cmd = new OracleCommand(querry, conn);

                cmd.ExecuteNonQuery();

                //Displays confirmation message
                MessageBox.Show("The Team Details have been updated.");

                conn.Close();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }

            //Reset the GUI
            cboBoxDriverTeam.Items.Clear();
            txtDriverName.Text = "";
            cboBoxDriverCountry.SelectedIndex = -1;
            cboBoxDriverTeam.SelectedIndex = -1;
            cboDrivers.SelectedIndex = -1;
            grpDriver.Visible = false;

        }

        private void cboDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

            //All drivers are cleared from the combo box to prevent the re-entry of drivers
            cboBoxDriverTeam.Items.Clear();


            //When the GUI is being reset the cboDrivers selected index will change.
            //This prevents the code from continuing if the text was blank.
            //If it was not included the program would crash each time the GUI was reset
            if (cboDrivers.Text.Equals(""))
                return;
            
            
            else{
            

            conn = new OracleConnection(oradb);

            conn.Open();

            //Selects the driver details for the selected driver

            String querry = "SELECT Driver_Name,D.Country,T.Team_ID,Team_Name FROM Drivers D,Teams T WHERE Driver_ID = " + cboDrivers.Text.Substring(0,3) + " AND D.Team_ID = T.Team_ID";

            cmd = new OracleCommand(querry, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                txtDriverName.Text = dr.GetString(0).TrimEnd();
                
                cboBoxDriverCountry.SelectedIndex = -1;
                
                for (int i = 0; !cboBoxDriverCountry.Text.Equals(dr.GetString(1).TrimEnd()); i++)
                {
                    cboBoxDriverCountry.SelectedIndex = i;
                }
              
                conn = new OracleConnection(oradb);

                //Returns the teams id and name for all teams so that the driver can select another team 
                String querrya = "SELECT Team_ID,Team_Name FROM Teams WHERE Status = 'A' ORDER BY Team_ID";

                 cmd = new OracleCommand(querrya, conn);
                 OracleDataReader reader;

            
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cboBoxDriverTeam.Items.Add(reader.GetValue(0).ToString().PadLeft(3,'0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }
                conn.Close();

                //Sets the combo box text to the drivers current team
                cboBoxDriverTeam.Text = dr.GetValue(2).ToString().TrimEnd().PadLeft(3, '0') + ", " + dr.GetValue(3).ToString().TrimEnd();
                
                
            }

            conn.Close();


            //display group box
            grpDriver.Visible = true;

            }
        }

        private void frmEditDriver_Load(object sender, EventArgs e)
        {
            

            conn = new OracleConnection(oradb);

            //Selects driver id and name for all drivers in the system
            String querry = "SELECT Driver_ID,Driver_Name FROM Drivers WHERE Status = 'A' ORDER BY Driver_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

           
            conn.Open();
            reader = cmd.ExecuteReader(); 
            
            while (reader.Read())
                {

                    cboDrivers.Items.Add(reader.GetValue(0).ToString().PadLeft(3,'0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }
           
            //loads all countries into the countries combo box
            loadCountries();


           


        }

        public void loadCountries()
        {
            

            conn = new OracleConnection(oradb);

            //Selects all countries in the countries table
            String querrya = "SELECT * FROM COUNTRY ORDER BY Country";

            cmd = new OracleCommand(querrya, conn);
            OracleDataReader reader;


            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                //adds the countries to the country combo box
                cboBoxDriverCountry.Items.Add(reader.GetValue(0).ToString().TrimEnd());


            }
            conn.Close();
        }

        //Validates the string passed, to make sure it only contains letters and spaces
        public Boolean validChar(String word)
        {
            int numSpaces = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];


                if (character == ' ')
                    numSpaces++;

            }
            if (numSpaces == word.Length)
                return false;

            foreach (char c in word)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }

            return true;
        }

        //checks to see how many active members a team has
        public int numActiveTeamDrivers(String team_id)
        {

            conn = new OracleConnection(oradb);

            //Selects the number of active drivers who are with the specified team_id

            String querry = "SELECT Count(Driver_ID) FROM Drivers WHERE Status = 'A' AND Team_ID =  " + team_id;

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;
            int numDrivers = 0;
            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    numDrivers = Convert.ToInt32(reader.GetValue(0));

                }

                return numDrivers;


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
                return 10;
            }

        }
    }
}
