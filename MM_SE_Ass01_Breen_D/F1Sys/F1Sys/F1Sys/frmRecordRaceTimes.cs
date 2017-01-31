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
using System.Collections;

namespace F1Sys
{
    public partial class frmRecordRaceTimes : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd, cmdb;
        DateTime today = DateTime.Now;

        public frmRecordRaceTimes()
        {
            InitializeComponent();
        }

       private void btnRecordTime_Click(object sender, EventArgs e)
        {
          
            //Displays message if the user hasn't selected a race but is trying to record a time 
            if(cboBoxRaceID.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a race");
                return;
            }

            //Displays message if the user hasn't selected a driver but is trying to record a time 
            if(cboBoxDriver.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a driver");
                return;

            }

            //Displays message if the user hasn't entered a time
            if (txtHours.Text.Equals("") || txtMins.Text.Equals("") || txtSeconds.Text.Equals("") || txtNanoSecs.Text.Equals(""))
            {
                MessageBox.Show("You must enter a time");
                return;
            }

            else
            {

                //joins the different parts of the time
                String timeAsString = txtHours.Text.PadLeft(2, '0') + txtMins.Text.PadLeft(2, '0') + txtSeconds.Text.PadLeft(2, '0') + txtNanoSecs.Text.PadLeft(2, '0');

                //checks that the time entered contains only numbers
                if(checkDigits(timeAsString) == false){
                    MessageBox.Show("The time you entered contains illegal characters please try again");
                     txtHours.Text = "";
                    txtMins.Text = "";
                    txtNanoSecs.Text = "";
                    txtSeconds.Text = "";
                    return;

                }


                //checks that the time fields contain valid times.
                //txtHours must be between 0-24
                //txtMins and txtSeconds must be between 0-60
                //no check is done on nanoSecs as it can contain any number and his has already been checked
                if (checkValidHour(txtHours.Text.PadLeft(2, '0')) == false || checkValidMinSec(txtMins.Text.PadLeft(2, '0')) == false || checkValidMinSec(txtSeconds.Text.PadLeft(2, '0')) == false)
                {
                    MessageBox.Show("There was an error in the time you entered.");
                    txtHours.Text = "";
                    txtMins.Text = "";
                    txtNanoSecs.Text = "";
                    txtSeconds.Text = "";
                    return;
                }

                else
                {
                    //converts the string to an int so that it can be stored
                    int time = Convert.ToInt32(timeAsString);

                    try
                    {
                        
                        conn = new OracleConnection(oradb);

                        //Records the time for the selected race and driver

                        String strSQL = "UPDATE Registrations SET RACE_TIME = " + time + " WHERE Race_ID = " + cboBoxRaceID.Text.Substring(0, 3) + " AND Driver_ID = " + cboBoxDriver.Text.Substring(0, 3);

                        conn.Open();

                        OracleCommand cmd = conn.CreateCommand();

                        cmd.CommandText = strSQL;

                        
                        cmd.ExecuteNonQuery();
                        

                        conn.Close();
                    }

                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    MessageBox.Show("The time has been successfully recorded");

                    //Reloads the races combo box and clears all items from the drivers combo box
                    load();
                    
                    
                    //reset GUI
                    txtHours.Text = "";
                    txtMins.Text = "";
                    txtSeconds.Text = "";
                    txtNanoSecs.Text = "";
                    cboBoxRaceID.SelectedIndex = -1;
                    cboBoxDriver.SelectedIndex = -1;

                } 
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

        private void frmRecordRaceTimes_Load(object sender, EventArgs e)
        {

            load();
        }

        private void cmboBoxRaceID_SelectedIndexChanged(object sender, EventArgs e)
        {

            //retrieves the race id from the races combo box
            int race_id = Int32.Parse(cboBoxRaceID.Text.Substring(0, 3));

            //checks that the race date is less than the current date.
            //Times can only be recorded for a race that has taken place
            //If the race date is after the currnet date the race has yet to take place and therefore you cannot add times
            if(getRaceDate(race_id) > today)
            {
                MessageBox.Show("You cannot add results for this race as it hasnt happened yet");
                grpDriver.Visible = false;
                return;
            }

            //If the number of entries is equal to 11 and the numnber of times recorded is equal to 11 then no more times can be recorded
            //The system now allows the user to allocate points for the race selected
            if (checkNumEntries(race_id) >= 20 && (numTimesRecorded(race_id) == 20))
            {

                lblMessage.Text = "The maximum number of entries has been" +
                                   "\nreached for this race.Please select another race. " +
                                   "\nThank you";

                btnRecordTime.Visible = false;
                grpAddPoints.Visible = true;
                grpDriver.Visible = true;
                btnAdd.Visible = true;                 
                
            }

            else
            {

            grpAddPoints.Visible = false;
            grpDriver.Visible = true;
            
            // Clears any drivers from the drivers combo box so that drivers do not appear more than once
            cboBoxDriver.Items.Clear();

            conn = new OracleConnection(oradb);

            //return all drivers entered in the selected race who have yet to have a time recorded for the race
            String querryb = "SELECT D.Driver_ID, D.Driver_Name FROM Registrations R,Drivers D WHERE D.Driver_ID = R.Driver_ID AND Race_ID = " + race_id + "AND Race_Time IS null ORDER BY D.Driver_ID";
            

            cmdb = new OracleCommand(querryb, conn);
            OracleDataReader rdr;

            try
            {

                conn.Open();
                rdr = cmdb.ExecuteReader();

                while (rdr.Read())
                {
                    //Adds the drivers to the drivers combo box
                    cboBoxDriver.Items.Add(rdr.GetValue(0).ToString().PadLeft(3,'0') + ", " +  rdr.GetValue(1).ToString());

                }

            }

            catch (OracleException ex)
            {

                MessageBox.Show("There was an error");
            }
            }
      

        }

        //Loads the races into the races combo box
        public void load()
        {
            //clears all items from the drivers combo box
            cboBoxDriver.Items.Clear();
            //clears all races from the races combo box
            cboBoxRaceID.Items.Clear();

           
            
            conn = new OracleConnection(oradb);

            //Returns the race_id and race location for all races in the races file
            String querry = "SELECT Race_ID,Race_Location FROM Races ORDER BY Race_ID";


            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //Adds the races to the races combo box
                    cboBoxRaceID.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString());


                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        
        //returns the number of entries for the race_id passed through
        public int checkNumEntries(int race_id)
        {

            conn = new OracleConnection(oradb);

            conn.Open();

            //Return the number of drivers who have entered the specified race

            String querryc = "SELECT COUNT(Driver_ID) FROM Registrations WHERE Race_ID = " + race_id + "  GROUP BY Race_ID";


            cmd = new OracleCommand(querryc, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            int numEntries = 0;

            while (dr.Read())
            {
                numEntries =  Convert.ToInt32(dr.GetValue(0));
            }

            conn.Close();
            
            //returns the number of entries in the race
            return numEntries;
            

        }

        //return the number of times recorded for the race_id passed through
        public int numTimesRecorded(int race_id)
        {
            

            conn = new OracleConnection(oradb);

            conn.Open();

            // Returns the number of entries who have a time recorded for the specified race
            String querryd = "SELECT COUNT(Race_Time) FROM Registrations WHERE Race_ID = " + race_id + " GROUP BY Race_ID";

            cmd = new OracleCommand(querryd, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            int numTimes = 0;

            while (dr.Read())
            {
                numTimes = Convert.ToInt32(dr.GetValue(0));
            }

            conn.Close();

            //returns the number of times recorded
            return numTimes;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            conn = new OracleConnection(oradb);

            int race_id = Convert.ToInt32(cboBoxRaceID.Text.Substring(0, 3));

            conn.Open();

            //Selects the drivers who are entered in the selected race, returning them by order of their time

            //Returns all drivers who are entered into the selected race orderer by there time
            //in the race
            String querryd = "SELECT Driver_ID FROM Registrations WHERE Race_ID = " + race_id + " ORDER BY Race_Time";


            cmd = new OracleCommand(querryd, conn);

            OracleDataReader rdr = cmd.ExecuteReader();


            ArrayList res = new ArrayList();


            while (rdr.Read())
            {
                //Adds the driver_id's to the ArrayList res
                res.Add(rdr.GetValue(0));
            }

            
            //loop which goes through each driver_id in the res ArrayList
            //the id's are ordered by time meaning the first is the quickest and so on
            for (int i = 0; i < res.Count - 1; i++)
            {

                //the first driver_id is the driver that has the quickest time and therefore has won the race
                //meaning they are rewarded 25 points for select race_id
                if (i == 0)
                {
                    //point is the number of points the driver will recieve
                    int point = 25;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point,race_id);

                }

                //2nd place
                if (i == 1)
                {
                    int point = 18;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);
                
                }

                //3rd place
                if (i == 2)
                {
                    int point = 15;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //4th place
                if (i == 3)
                {
                    int point = 12;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //5th place
                if (i == 4)
                {
                    int point = 10;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //6th place
                if (i == 5)
                {
                    int point = 8;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //7th place
                if (i == 6)
                {
                    int point = 6;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //8th place
                if (i == 7)
                {
                    int point = 4;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //9th place
                if (i == 8)
                {
                    int point = 2;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //10th place
                if (i == 9)
                {
                    int point = 1;
                    int driver_id = Int32.Parse(res[i].ToString());

                    addPoints(driver_id, point, race_id);

                }

                //Only the top ten driver's receive points so the remaining drivers do not need to be given points


            }

            MessageBox.Show("The points have been allocated for the selected race");
           


        }

        //Method which add's points to the registrations file for a selected rcea
        public void addPoints(int driver_id, int points, int race_id)
        {

            
            conn = new OracleConnection(oradb);

            conn.Open();

            try
            {
                //Updates the registrations file to set the points for the selected driver in the selected race
                String update = "UPDATE Registrations SET Points = " + points + " WHERE Driver_ID = " + driver_id + " AND Race_ID = " + race_id;

                cmd = new OracleCommand(update, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Check's that the time entered only contains digits between 0-6
        public Boolean checkDigits(String time)
        {
            //chekcs that each character is a number
            foreach (char c in time)
            {
                if (!char.IsNumber(c))
                    return false;
            }

            //returns true if the string contains only numbers
            return true;

        }

        //chekcs the string passed through is a valid hour time
        public Boolean checkValidHour(String time)
        {

          int hrs = Convert.ToInt32(time);
          if (hrs < 0 || hrs > 24)
              return false;

          //returns true if the string is a valid hour
          else
              return true;
        }

        //checks that the string passed through is a valid minute/second
        //of time
        public Boolean checkValidMinSec(String time)
        {
            int tm = Convert.ToInt32(time);

            if (tm < 0 || tm > 60)
                return false;
            
            //returns true if it is a valid time
            else
                return true;
        }


        //Return the date of a selected race. This enables the system to check wheather or not a race has taken place.
        public DateTime getRaceDate(int raceID)
        {
            conn = new OracleConnection(oradb);

            //returns the start_date of the selected race_id
            String querry = "SELECT Start_Date FROM Races WHERE Race_ID = " + raceID;

            cmd = new OracleCommand(querry, conn);

            conn.Open();
            
            OracleDataReader rdr = cmd.ExecuteReader();

            DateTime race;


            rdr.Read();

       
            //returns the start_time for the selected race     
            return  (DateTime)rdr.GetDateTime(0);
            
            conn.Close();
        
        }

        
    }
}
