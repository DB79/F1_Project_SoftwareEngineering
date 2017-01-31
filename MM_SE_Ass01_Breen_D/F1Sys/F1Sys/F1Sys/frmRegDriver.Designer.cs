namespace F1Sys
{
    partial class frmRegDriver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxTeamDetails = new System.Windows.Forms.GroupBox();
            this.cboBoxDriverTeam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxDriverCountry = new System.Windows.Forms.ComboBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegDriver = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seasonStandinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpBoxTeamDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTeamDetails
            // 
            this.grpBoxTeamDetails.Controls.Add(this.cboBoxDriverTeam);
            this.grpBoxTeamDetails.Controls.Add(this.label6);
            this.grpBoxTeamDetails.Controls.Add(this.cboBoxDriverCountry);
            this.grpBoxTeamDetails.Controls.Add(this.txtDriverName);
            this.grpBoxTeamDetails.Controls.Add(this.label3);
            this.grpBoxTeamDetails.Controls.Add(this.label1);
            this.grpBoxTeamDetails.Location = new System.Drawing.Point(35, 83);
            this.grpBoxTeamDetails.Name = "grpBoxTeamDetails";
            this.grpBoxTeamDetails.Size = new System.Drawing.Size(461, 181);
            this.grpBoxTeamDetails.TabIndex = 7;
            this.grpBoxTeamDetails.TabStop = false;
            this.grpBoxTeamDetails.Text = "Fill in all details";
            // 
            // cboBoxDriverTeam
            // 
            this.cboBoxDriverTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxDriverTeam.FormattingEnabled = true;
            this.cboBoxDriverTeam.Location = new System.Drawing.Point(112, 148);
            this.cboBoxDriverTeam.Name = "cboBoxDriverTeam";
            this.cboBoxDriverTeam.Size = new System.Drawing.Size(207, 23);
            this.cboBoxDriverTeam.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Team";
            // 
            // cboBoxDriverCountry
            // 
            this.cboBoxDriverCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxDriverCountry.FormattingEnabled = true;
            this.cboBoxDriverCountry.Location = new System.Drawing.Point(112, 92);
            this.cboBoxDriverCountry.Name = "cboBoxDriverCountry";
            this.cboBoxDriverCountry.Size = new System.Drawing.Size(207, 23);
            this.cboBoxDriverCountry.TabIndex = 6;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(112, 46);
            this.txtDriverName.MaxLength = 40;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(207, 21);
            this.txtDriverName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Name";
            // 
            // txtDriverID
            // 
            this.txtDriverID.Location = new System.Drawing.Point(140, 43);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.ReadOnly = true;
            this.txtDriverID.Size = new System.Drawing.Size(51, 21);
            this.txtDriverID.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Driver ID";
            // 
            // btnRegDriver
            // 
            this.btnRegDriver.Location = new System.Drawing.Point(352, 285);
            this.btnRegDriver.Name = "btnRegDriver";
            this.btnRegDriver.Size = new System.Drawing.Size(157, 38);
            this.btnRegDriver.TabIndex = 14;
            this.btnRegDriver.Text = "Register Driver";
            this.btnRegDriver.UseVisualStyleBackColor = true;
            this.btnRegDriver.Click += new System.EventHandler(this.btnRegDriver_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.racesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTeamToolStripMenuItem,
            this.editTeamToolStripMenuItem,
            this.removeTeamToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // registerTeamToolStripMenuItem
            // 
            this.registerTeamToolStripMenuItem.Name = "registerTeamToolStripMenuItem";
            this.registerTeamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.registerTeamToolStripMenuItem.Text = "Register Team";
            this.registerTeamToolStripMenuItem.Click += new System.EventHandler(this.registerTeamToolStripMenuItem_Click);
            // 
            // editTeamToolStripMenuItem
            // 
            this.editTeamToolStripMenuItem.Name = "editTeamToolStripMenuItem";
            this.editTeamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editTeamToolStripMenuItem.Text = "Edit Team";
            this.editTeamToolStripMenuItem.Click += new System.EventHandler(this.editTeamToolStripMenuItem_Click);
            // 
            // removeTeamToolStripMenuItem
            // 
            this.removeTeamToolStripMenuItem.Name = "removeTeamToolStripMenuItem";
            this.removeTeamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.removeTeamToolStripMenuItem.Text = "Remove Team";
            this.removeTeamToolStripMenuItem.Click += new System.EventHandler(this.removeTeamToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerDriverToolStripMenuItem,
            this.editDriverToolStripMenuItem,
            this.removeDriverToolStripMenuItem,
            this.listDriversToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // registerDriverToolStripMenuItem
            // 
            this.registerDriverToolStripMenuItem.Name = "registerDriverToolStripMenuItem";
            this.registerDriverToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.registerDriverToolStripMenuItem.Text = "Register Driver";
            this.registerDriverToolStripMenuItem.Click += new System.EventHandler(this.registerDriverToolStripMenuItem_Click);
            // 
            // editDriverToolStripMenuItem
            // 
            this.editDriverToolStripMenuItem.Name = "editDriverToolStripMenuItem";
            this.editDriverToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editDriverToolStripMenuItem.Text = "Edit Driver";
            this.editDriverToolStripMenuItem.Click += new System.EventHandler(this.editDriverToolStripMenuItem_Click);
            // 
            // removeDriverToolStripMenuItem
            // 
            this.removeDriverToolStripMenuItem.Name = "removeDriverToolStripMenuItem";
            this.removeDriverToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.removeDriverToolStripMenuItem.Text = "Remove Driver";
            this.removeDriverToolStripMenuItem.Click += new System.EventHandler(this.removeDriverToolStripMenuItem_Click);
            // 
            // listDriversToolStripMenuItem
            // 
            this.listDriversToolStripMenuItem.Name = "listDriversToolStripMenuItem";
            this.listDriversToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listDriversToolStripMenuItem.Text = "List Drivers";
            this.listDriversToolStripMenuItem.Click += new System.EventHandler(this.listDriversToolStripMenuItem_Click);
            // 
            // racesToolStripMenuItem
            // 
            this.racesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleRaceToolStripMenuItem,
            this.editRaceToolStripMenuItem,
            this.raceRegistrationToolStripMenuItem,
            this.recordTimesToolStripMenuItem,
            this.raceResultsToolStripMenuItem});
            this.racesToolStripMenuItem.Name = "racesToolStripMenuItem";
            this.racesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.racesToolStripMenuItem.Text = "Races";
            // 
            // scheduleRaceToolStripMenuItem
            // 
            this.scheduleRaceToolStripMenuItem.Name = "scheduleRaceToolStripMenuItem";
            this.scheduleRaceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.scheduleRaceToolStripMenuItem.Text = "Schedule Race";
            this.scheduleRaceToolStripMenuItem.Click += new System.EventHandler(this.scheduleRaceToolStripMenuItem_Click);
            // 
            // editRaceToolStripMenuItem
            // 
            this.editRaceToolStripMenuItem.Name = "editRaceToolStripMenuItem";
            this.editRaceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editRaceToolStripMenuItem.Text = "Edit Race";
            this.editRaceToolStripMenuItem.Click += new System.EventHandler(this.editRaceToolStripMenuItem_Click);
            // 
            // raceRegistrationToolStripMenuItem
            // 
            this.raceRegistrationToolStripMenuItem.Name = "raceRegistrationToolStripMenuItem";
            this.raceRegistrationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.raceRegistrationToolStripMenuItem.Text = "Race Registration";
            this.raceRegistrationToolStripMenuItem.Click += new System.EventHandler(this.raceRegistrationToolStripMenuItem_Click);
            // 
            // recordTimesToolStripMenuItem
            // 
            this.recordTimesToolStripMenuItem.Name = "recordTimesToolStripMenuItem";
            this.recordTimesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.recordTimesToolStripMenuItem.Text = "Record Times";
            this.recordTimesToolStripMenuItem.Click += new System.EventHandler(this.recordTimesToolStripMenuItem_Click);
            // 
            // raceResultsToolStripMenuItem
            // 
            this.raceResultsToolStripMenuItem.Name = "raceResultsToolStripMenuItem";
            this.raceResultsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.raceResultsToolStripMenuItem.Text = "Race Results";
            this.raceResultsToolStripMenuItem.Click += new System.EventHandler(this.raceResultsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seasonStandinsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // seasonStandinsToolStripMenuItem
            // 
            this.seasonStandinsToolStripMenuItem.Name = "seasonStandinsToolStripMenuItem";
            this.seasonStandinsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seasonStandinsToolStripMenuItem.Text = "Season Standins";
            this.seasonStandinsToolStripMenuItem.Click += new System.EventHandler(this.seasonStandinsToolStripMenuItem_Click);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnRegDriver);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.txtDriverID);
            this.grpMain.Controls.Add(this.grpBoxTeamDetails);
            this.grpMain.Location = new System.Drawing.Point(52, 108);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(517, 347);
            this.grpMain.TabIndex = 16;
            this.grpMain.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(178, 76);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 11;
            // 
            // frmRegDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 470);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRegDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Driver";
            this.Load += new System.EventHandler(this.frmRegDriver_Load);
            this.grpBoxTeamDetails.ResumeLayout(false);
            this.grpBoxTeamDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTeamDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBoxDriverCountry;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegDriver;
        private System.Windows.Forms.ComboBox cboBoxDriverTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seasonStandinsToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblMessage;
    }
}