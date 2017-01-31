namespace F1Sys
{
    partial class frmEditDriver
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
            this.cmboBoxDriverID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDriver = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBoxDriverTeam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxDriverCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDriverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cboDrivers = new System.Windows.Forms.ComboBox();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.grpDriver.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboBoxDriverID
            // 
            this.cmboBoxDriverID.Location = new System.Drawing.Point(0, 0);
            this.cmboBoxDriverID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmboBoxDriverID.Name = "cmboBoxDriverID";
            this.cmboBoxDriverID.Size = new System.Drawing.Size(139, 23);
            this.cmboBoxDriverID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the Driver you wish to modify";
            // 
            // grpDriver
            // 
            this.grpDriver.Controls.Add(this.label3);
            this.grpDriver.Controls.Add(this.cboBoxDriverTeam);
            this.grpDriver.Controls.Add(this.label6);
            this.grpDriver.Controls.Add(this.cboBoxDriverCountry);
            this.grpDriver.Controls.Add(this.label2);
            this.grpDriver.Controls.Add(this.txtDriverName);
            this.grpDriver.Location = new System.Drawing.Point(48, 130);
            this.grpDriver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDriver.Name = "grpDriver";
            this.grpDriver.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDriver.Size = new System.Drawing.Size(406, 260);
            this.grpDriver.TabIndex = 2;
            this.grpDriver.TabStop = false;
            this.grpDriver.Text = "Details of selected driver";
            this.grpDriver.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Team";
            // 
            // cboBoxDriverTeam
            // 
            this.cboBoxDriverTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxDriverTeam.FormattingEnabled = true;
            this.cboBoxDriverTeam.Location = new System.Drawing.Point(135, 180);
            this.cboBoxDriverTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboBoxDriverTeam.Name = "cboBoxDriverTeam";
            this.cboBoxDriverTeam.Size = new System.Drawing.Size(185, 23);
            this.cboBoxDriverTeam.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Country";
            // 
            // cboBoxDriverCountry
            // 
            this.cboBoxDriverCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxDriverCountry.FormattingEnabled = true;
            this.cboBoxDriverCountry.Location = new System.Drawing.Point(135, 125);
            this.cboBoxDriverCountry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboBoxDriverCountry.Name = "cboBoxDriverCountry";
            this.cboBoxDriverCountry.Size = new System.Drawing.Size(185, 23);
            this.cboBoxDriverCountry.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Driver Name";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(135, 70);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDriverName.MaxLength = 40;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(185, 21);
            this.txtDriverName.TabIndex = 4;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(506, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTeamToolStripMenuItem,
            this.editTeamToolStripMenuItem,
            this.removeTeamToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // registerTeamToolStripMenuItem
            // 
            this.registerTeamToolStripMenuItem.Name = "registerTeamToolStripMenuItem";
            this.registerTeamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.registerTeamToolStripMenuItem.Text = "Register Driver";
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
            this.registerDriverToolStripMenuItem1,
            this.editDriverToolStripMenuItem,
            this.removeDriverToolStripMenuItem,
            this.listDriversToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // registerDriverToolStripMenuItem1
            // 
            this.registerDriverToolStripMenuItem1.Name = "registerDriverToolStripMenuItem1";
            this.registerDriverToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.registerDriverToolStripMenuItem1.Text = "Register Driver";
            this.registerDriverToolStripMenuItem1.Click += new System.EventHandler(this.registerDriverToolStripMenuItem1_Click);
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
            this.racesToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
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
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // seasonStandinsToolStripMenuItem
            // 
            this.seasonStandinsToolStripMenuItem.Name = "seasonStandinsToolStripMenuItem";
            this.seasonStandinsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seasonStandinsToolStripMenuItem.Text = "Season Standins";
            this.seasonStandinsToolStripMenuItem.Click += new System.EventHandler(this.seasonStandinsToolStripMenuItem_Click);
            // 
            // cboDrivers
            // 
            this.cboDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivers.FormattingEnabled = true;
            this.cboDrivers.Location = new System.Drawing.Point(83, 84);
            this.cboDrivers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboDrivers.Name = "cboDrivers";
            this.cboDrivers.Size = new System.Drawing.Size(237, 23);
            this.cboDrivers.TabIndex = 9;
            this.cboDrivers.SelectedIndexChanged += new System.EventHandler(this.cboDrivers_SelectedIndexChanged);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Location = new System.Drawing.Point(268, 408);
            this.btnUpdateDriver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(184, 39);
            this.btnUpdateDriver.TabIndex = 11;
            this.btnUpdateDriver.Text = "Update Driver";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // frmEditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.btnUpdateDriver);
            this.Controls.Add(this.cboDrivers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpDriver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBoxDriverID);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmEditDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Driver";
            this.Load += new System.EventHandler(this.frmEditDriver_Load);
            this.grpDriver.ResumeLayout(false);
            this.grpDriver.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBoxDriverID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBoxDriverCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDriverToolStripMenuItem1;
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
        private System.Windows.Forms.ComboBox cboDrivers;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.ComboBox cboBoxDriverTeam;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label3;
    }
}