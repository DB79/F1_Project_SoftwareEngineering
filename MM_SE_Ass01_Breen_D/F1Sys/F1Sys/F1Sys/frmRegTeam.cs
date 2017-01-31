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
    public partial class frmRegTeam : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmRegTeam()
        {
            InitializeComponent();
        }


        private void btnRegTeam_Click(object sender, EventArgs e)
        {

            //Displays an error message if the team name is left empty or contains
            //an illegal character.
            if (validChar(txtTeamName.Text) == false || txtTeamName.Text.Equals(""))
            {

                MessageBox.Show("Please re-enter the team name");
                txtTeamName.Focus();
                txtTeamName.Text = "";
                return;
            }

            //Displays an error message if the owner name is left empty or 
            // if it contains an illegal character
            if (validChar(txtOwnerName.Text) == false || txtOwnerName.Text.Equals(""))
            {
                MessageBox.Show("Please re-enter the owner name");
                txtOwnerName.Focus();
                txtOwnerName.Text = "";
                return;
            }

            //Displays an error if no country is selected
            if (cboBoxTeamCountry.Text.Equals(""))
            {

                MessageBox.Show("Team country must be entered");
                cboBoxTeamCountry.Focus();
                return;
            }

            //Displays an error if the team name entered is already used by another 
            //team in the teams file
            if (checkValidTeam(txtTeamName.Text.Trim()) == false)
            {

                MessageBox.Show("A team already exists with the given name. Please try again");
                txtTeamName.Focus();
                txtTeamName.Text = "";
                return;
            }


            try
            {
                
                conn = new OracleConnection(oradb);

                //Inserts the team details into the teams file
                String strSQL = "INSERT INTO Teams (Team_ID,Team_Name,Owner_Name,Country)VALUES (" + getTeamID() + ",'" + txtTeamName.Text.Replace("'", "''").Trim() + "','" + txtOwnerName.Text.Trim() + "','" + cboBoxTeamCountry.Text.Trim() + "')";

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
            MessageBox.Show("Your team has been registered");


            //Reset theUI
            txtTeamName.Text = "";
            txtOwnerName.Text = "";
            cboBoxTeamCountry.SelectedIndex = -1;
            txtTeamName.Focus();
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

        //retturns the team_id which will be given to the next team
        private int getTeamID()
        {

            try
            {
                int last;

                conn = new OracleConnection(oradb);

                conn.Open();

                cmd = conn.CreateCommand();

                //Returns the largest/previus team_id used in the teams file
                String strSQL = "SELECT MAX(Team_ID) FROM Teams";

                cmd.CommandText = strSQL;

                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                //if nothing is returned then there are no teams meaning the 
                //next team_id will be 1
                if (dr[0] == DBNull.Value)
                    last = 1;

                //if there is already teams the next will be the highest plus 1
                else last = Convert.ToInt32(dr[0]) + 1;

                conn.Close();

                //the next team_id is returned
                return last;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //when the form is loaded the countries are put into the countries combo box
        private void frmRegTeam_Load(object sender, EventArgs e)
        {

            
            conn = new OracleConnection(oradb);

            //Returns all countries in the countries file ordered by country
            String querrya = "SELECT * FROM COUNTRY ORDER BY COUNTRY";

            cmd = new OracleCommand(querrya, conn);
            OracleDataReader reader;


            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //the countries are added to the countries combo box
                cboBoxTeamCountry.Items.Add(reader.GetValue(0).ToString().TrimEnd());


            }
            conn.Close();
        }

        //checks the string to make sure it doesn't contain illegal characters
        public Boolean validChar(String word)
        {

            int numSpaces = 0;
            
            //calculates how many spaces are in the string
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];


                if (character == ' ')
                    numSpaces++;

            }

            //if the number of spaces is equal to the length of the
            //string then is an empty string which makes it invalid
            if (numSpaces == word.Length)
                return false;

            //checks each character to make sure it contains only letters or spaces
            foreach (char c in word)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return false;
            }

            //true is returned if the string contains only valid characters
            return true;
        }


        //checks that the team name passed through is unique
        public Boolean checkValidTeam(String tName)
        {

            conn = new OracleConnection(oradb);

            //returns all team names from the teams file
            String querry = "SELECT Team_Name FROM Teams";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                //if the tName is equal to any team already in the teams file
                //false is returned
                if (reader.GetString(0).TrimEnd() == tName)
                { 
                    return false;
     
                }

            }
            conn.Close();

            return true;
      }
    }
}

