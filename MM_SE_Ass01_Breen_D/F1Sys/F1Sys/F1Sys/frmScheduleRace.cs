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


    public partial class frmScheduleRace : Form
    {

        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        DateTime dt = DateTime.Now;

        public frmScheduleRace()
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

        private void btnScheduleRace_Click(object sender, EventArgs e)
        {

            

            //Displays an error if the text entered is empty or contains invalid characters
            if (txtRaceLocation.Text.Equals("") || validChar(txtRaceLocation.Text) == false)
            {

                MessageBox.Show("Please re-enter the race location");
                txtRaceLocation.Focus();
                return;
            }

            //Check that no race already in the system has the entered loaaction
            //An error is displayed if a race is already scheduled for the location entered
            if (checkLocation(txtRaceLocation.Text.Trim()) == false)
            {
                MessageBox.Show("Only one race can be scheduled for any location.Please try another location.");
                txtRaceLocation.Text = "";
                txtRaceLocation.Focus();
                return;
            }

           


            try
            {

                //Connect to Database 
                conn = new OracleConnection(oradb);

                //The race details are inserted into the Races file
                String strSQL = "INSERT INTO Races (Race_ID,Race_Location,Start_Date) VALUES (" + txtRaceID.Text + ",'" + txtRaceLocation.Text.Trim() + "','" + dtpRaceDate.Text + "')";

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
            MessageBox.Show("The Race has successfully added to the system");


            //Reset theUI
            txtRaceLocation.Text = "";
            txtRaceID.Text = getRaceID().ToString();
            //the date on date time picker is set to the current date
            dtpRaceDate.Value = dt;


        }

        private void frmScheduleRace_Load(object sender, EventArgs e)
        {
            //retrieves the next id and displays it
            txtRaceID.Text = getRaceID().ToString();
            txtRaceLocation.Focus();
            //Sets the minDate to the current date
            dtpRaceDate.MinDate = dt;
            //Sets the current selected date to today's date
            dtpRaceDate.Value = dt;


        }

        //Retuurns the next available race_id 
        private int getRaceID()
        {


            try
            {
                int last;

                conn = new OracleConnection(oradb);

                conn.Open();

                cmd = conn.CreateCommand();

                //Return the highest/latest race_id from the races file
                String strSQL = "SELECT MAX(Race_ID) FROM Races";

                cmd.CommandText = strSQL;

                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                //If no value is return the is set to 1 as there are no previous races.
                if (dr[0] == DBNull.Value)
                    last = 1;

                //otherwise the race_id is set to the previous id plus 1
                else last = Convert.ToInt32(dr[0]) + 1;

                conn.Close();

                //the next race_id is returned
                return last;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //checks that the string passed through contains only valid characters.
        public Boolean validChar(String word)
        {
            int numSpaces = 0;

            //counts the number of spaces used 
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];


                if (character == ' ')
                    numSpaces++;

            }

            //if the number of spaces is equal to the number of characters then a blank string was passed which 
            //makes the text invalid
            if (numSpaces == word.Length)
                return false;

            //checks that each character is either a letter or a space
            //the string may contain more than one word so spaces need to be accomidated
            foreach (char c in word)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return false;
            }

            //if there are no errors then true is returned meaning the string is valid
            return true;

        }

        //chekcs that the race loaction entered by the user is unique
        public Boolean checkLocation(String newLocation)
        {

            conn = new OracleConnection(oradb);

            //returnd all race_locations from the race file
            String querry = "SELECT Race_Location FROM Races";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //if any location returned is equal to the string passed by the user 
                //false is returned as the race location is already in use
                if (reader.GetString(0).TrimEnd() == newLocation)
                {
                    return false;

                }

            }
            conn.Close();

            //if the race location passed in is unique there are no problems so true is passed back
            return true;
        }

    }
}

        
    

