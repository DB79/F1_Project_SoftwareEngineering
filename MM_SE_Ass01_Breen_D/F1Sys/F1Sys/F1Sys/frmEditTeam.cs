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
    public partial class frmEditTeam : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";
        OracleConnection conn;
        OracleCommand cmd;

        public frmEditTeam()
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

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            //Validate data entered

            if (cboBoxTeam.Text.Equals(""))
            {
                MessageBox.Show("You must select the team you wish to update");
                cboBoxTeam.Focus();
                return;
            }



            if (txtTeamName.Text.Equals("") || validChar(txtTeamName.Text) == false)
            {

                MessageBox.Show("Please re-enter the team name");
                txtTeamName.Focus();
                return;
            }

            //Is owner name entered
            if (txtOwnerName.Text.Equals("") || validChar(txtOwnerName.Text) == false)
            {

                MessageBox.Show("Please re-enter the owner name");
                txtOwnerName.Focus();
                return;
            }

            //Is team country selected
            if (cboBoxTeamCountry.Text.Equals(""))
            {

                MessageBox.Show("Team country must be entered");
                cboBoxTeamCountry.Focus();
                return;
            }

            //Update team details in the teams file
            

            conn = new OracleConnection(oradb);

            conn.Open();

            try
            {
                String querry = "UPDATE Teams SET Team_Name = '" + txtTeamName.Text.Trim() + "', Owner_Name = '" + txtOwnerName.Text.Trim() + "',Country = '" + cboBoxTeamCountry.Text.Trim() + "' WHERE Team_ID = '" + cboBoxTeam.Text.Substring(0, 3) + "'";

                cmd = new OracleCommand(querry, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("The Team Details have been updated.");

                conn.Close();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }

            
            cboBoxTeam.Items.Clear();
            load();
            grpTeam.Visible = false;
        }

        private void cmboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            conn = new OracleConnection(oradb);
            
            conn.Open();

            String querry = "SELECT * FROM Teams WHERE Team_ID = '" + cboBoxTeam.Text.Substring(0,3) + "'";

            cmd = new OracleCommand(querry, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtTeamName.Text = dr.GetString(1).TrimEnd();
                txtOwnerName.Text = dr.GetString(2).TrimEnd();
              
             
                cboBoxTeamCountry.SelectedIndex = 0;
                for (int i = 0; !cboBoxTeamCountry.Text.Equals(dr.GetString(3).TrimEnd());i++ )
                {

                    cboBoxTeamCountry.SelectedIndex = i;
                }

                

            }

            conn.Close();

           
            //display group box
            grpTeam.Visible = true;
        }





        private void frmEditTeam_Load(object sender, EventArgs e)
        {
            load();
            loadCountries();
        }

        public void load()
        {
            

            conn = new OracleConnection(oradb);

            String querry = "SELECT Team_ID,Team_Name FROM Teams WHERE Status = 'A' ORDER BY Team_ID";

            cmd = new OracleCommand(querry, conn);
            OracleDataReader reader;

            try
            {

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cboBoxTeam.Items.Add(reader.GetValue(0).ToString().PadLeft(3, '0') + ", " + reader.GetValue(1).ToString().TrimEnd());


                }


            }

            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void loadCountries()
        {
            String orad = "Data Source=Oracle;User Id = t00171168;Password = p9udna7n;";

            conn = new OracleConnection(orad);

            String querrya = "SELECT * FROM COUNTRY ORDER BY COUNTRY";

            cmd = new OracleCommand(querrya, conn);
            OracleDataReader reader;


            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                cboBoxTeamCountry.Items.Add(reader.GetValue(0).ToString().TrimEnd());


            }
            conn.Close();
        }

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
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return false;
            }

            return true;
        }

    }
}
    
    


