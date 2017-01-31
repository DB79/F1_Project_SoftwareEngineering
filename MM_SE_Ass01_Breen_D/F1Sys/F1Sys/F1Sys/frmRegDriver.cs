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
    public partial class frmRegDriver : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmRegDriver()
        {
            InitializeComponent();
            
        }

        private void btnRegDriver_Click(object sender, EventArgs e)
        {
            
           
            //Displays errro if the text is blank or contains illegal characters
            if (txtDriverName.Text.Equals("") || validChar(txtDriverName.Text) == false)
            {

                MessageBox.Show("Please re-enter the driver name");
                txtDriverName.Focus();
                txtDriverName.Text = "";
                return;
            }

            
            //Displays an error if the user doesn't select a country
            if (cboBoxDriverCountry.Text.Equals(""))
            {

                MessageBox.Show("Driver country must be entered");
                cboBoxDriverCountry.Focus();
                return;
            }

            //Displays an error if the user doesn't have a team selected
            if (cboBoxDriverTeam.Text.Equals(""))
            {

                MessageBox.Show("Driver team must be entered");
                cboBoxDriverTeam.Focus();
                return;
            }

            //Any team can have only two active drivers at a time.
            //An error is displayed when you try to registered with a team that already has the maximum number of drivers
            if (numActiveTeamDrivers(cboBoxDriverTeam.Text.Substring(0,3)) >= 2)
            {

                MessageBox.Show("The sleceted team has the maximum number of team members");
                cboBoxDriverTeam.SelectedIndex = -1;
                return;
            }


            


            try
            {

               
                conn = new OracleConnection(oradb);


                //Inserts the details for the driver into the drivers table
                String strSQL = "INSERT INTO Drivers (Driver_ID,Driver_Name,Country,Team_ID) VALUES (" + txtDriverID.Text + ",'" + txtDriverName.Text.Trim() + "','" + cboBoxDriverCountry.Text.Trim() + "','" + cboBoxDriverTeam.Text.Substring(0, 3) + "')";

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

            

            //Display Confirmation Message
            MessageBox.Show("The Driver has been successfully added to the system");


            //Reset theUI
            load();
            txtDriverName.Text = "";
            cboBoxDriverCountry.SelectedIndex = -1;
            cboBoxDriverTeam.SelectedIndex = -1;
        }

        private void registerTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegTeam nextForm = new frmRegTeam();
            this.Hide();
            nextForm.Show();
        }

        private void removeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveTeam nextForm = new frmRemoveTeam();
            this.Hide();
            nextForm.Show();
        }

        private void editTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTeam nextForm = new frmEditTeam();
            this.Hide();
            nextForm.Show();
        }

        private void registerDriverToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmRegDriver_Load(object sender, EventArgs e)
        {

            //If there aer no teams then no driver can be registered as every driver must register with a team
            if (checkTeams() < 1)
            {
                //MessageBox.Show("There are no teams currently in the system and therefore you cannot register a driver");
                grpMain.Visible = false;
                lblMessage.Visible = true;
                lblMessage.Text = "Please go and create a team";
                return;
            }

            else{

            grpMain.Visible = true;
            lblMessage.Visible = false;
            
            //Loads teams into teams combo box
            load();
            
            //Loads countries into countries combo box
            loadCountries();
            }
            }

        //Gets the current highest driver id so that the next available can be applied to the new driver
        private int getDriverID()
        {

            try
            {
                int last; 
                
                conn = new OracleConnection(oradb);
                
                conn.Open(); 
                
                cmd = conn.CreateCommand();
                
                
                //Return the highest id currently in the system
                String strSQL = "SELECT MAX(Driver_ID) FROM Drivers";
                
                cmd.CommandText = strSQL;
                
                OracleDataReader dr = cmd.ExecuteReader();
                
                dr.Read();
                
                //If there is no drivers the first driver_id will be 1
                if (dr[0] == DBNull.Value) 
                    last = 1;

                //driver_id will be the max(driver_id) plus 1
                else last = Convert.ToInt32(dr[0])+1; 
                
                conn.Close(); 
                
                //returns the next availabe driver_id
                return last;
               }
                
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
      }

        //Determines the total number of active drivers for a specified team
        public int numActiveTeamDrivers(String team_name)
        {
            
            conn = new OracleConnection(oradb);

            //Returns the number of active drivers for the specified team
            String querry = "SELECT Count(Driver_ID) FROM Drivers WHERE Status = 'A' AND Team_ID =  '" + team_name + "'";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;
            int numDrivers=0;
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
                return 0;
            }

        }

        //Loads teams into teams combo box
        public void load()
        {

            //Clears all teams from the combo box
            cboBoxDriverTeam.Items.Clear();

            //Assisgns the next id to the text box
            txtDriverID.Text = getDriverID().ToString();

            

            conn = new OracleConnection(oradb);

            //Selects the team id and name for all active teams
            String querry = "SELECT Team_ID,Team_Name FROM Teams WHERE Status = 'A' ORDER BY Team_ID";
            

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Adds driver_id and driver_name to the drivers combo box
                    cboBoxDriverTeam.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Loads all countries into the countries combo box
        public void loadCountries()
        {
            

            conn = new OracleConnection(oradb);

            //returns all countries from the countries file
            String querrya = "SELECT * FROM COUNTRY ORDER BY COUNTRY";

            cmd = new OracleCommand(querrya, conn);
            OracleDataReader reader;


            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //adds the countries to the countries combo box
                cboBoxDriverCountry.Items.Add(reader.GetValue(0).ToString().TrimEnd());


            }
            conn.Close();

        }

        //A check is done to make sure there are teams registered in the system
        public int checkTeams()
        {
            conn = new OracleConnection(oradb);

            //returns the number of activer teams in the teams file
            String querry = "SELECT Count(Team_ID) FROM Teams WHERE STATUS = 'A'";

            cmd = new OracleCommand(querry, conn);

            OracleDataReader rdr;

            conn.Open();
            int numTeams=0;
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                numTeams = Convert.ToInt32(rdr.GetValue(0).ToString());
            }

            //returns the number of activer teams
            return numTeams;
        }


        //Checks the charcters of the word are valid
        public Boolean validChar(String word)
        {
            int numSpaces = 0;

            //counts the number of spaces in the string
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];


                if (character == ' ')
                    numSpaces++;

            }

            //if the number of spaces in the string equals the length of
            //the string it means the string is made up of onlt spaces
            //which makes it invalid
            if (numSpaces == word.Length)
                return false;

            //checks that each character is either a space or a letter
            foreach (char c in word)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }

            //returns true if the string contains only valid characters
            return true;
        }

        }
        

    }

