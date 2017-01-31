namespace F1Sys
{
    partial class frmRaceRegistration
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
            this.cboBoxRaceID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegDriver = new System.Windows.Forms.Button();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.txtFull = new System.Windows.Forms.TextBox();
            this.lblNumEntries = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 8;
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
            this.registerDriverToolStripMenuItem1,
            this.editDriverToolStripMenuItem,
            this.removeDriverToolStripMenuItem,
            this.listDriversToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
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
            // cboBoxRaceID
            // 
            this.cboBoxRaceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxRaceID.FormattingEnabled = true;
            this.cboBoxRaceID.Location = new System.Drawing.Point(17, 77);
            this.cboBoxRaceID.Name = "cboBoxRaceID";
            this.cboBoxRaceID.Size = new System.Drawing.Size(194, 23);
            this.cboBoxRaceID.TabIndex = 9;
            this.cboBoxRaceID.SelectedIndexChanged += new System.EventHandler(this.cmboBoxRaceID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select the driver you wish to enter in the race";
            // 
            // btnRegDriver
            // 
            this.btnRegDriver.Location = new System.Drawing.Point(188, 235);
            this.btnRegDriver.Name = "btnRegDriver";
            this.btnRegDriver.Size = new System.Drawing.Size(139, 38);
            this.btnRegDriver.TabIndex = 13;
            this.btnRegDriver.Text = "Register Driver";
            this.btnRegDriver.UseVisualStyleBackColor = true;
            this.btnRegDriver.Click += new System.EventHandler(this.btnRegDriver_Click);
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(17, 166);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(194, 23);
            this.cboDriver.TabIndex = 14;
            // 
            // txtFull
            // 
            this.txtFull.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFull.Location = new System.Drawing.Point(14, 111);
            this.txtFull.Multiline = true;
            this.txtFull.Name = "txtFull";
            this.txtFull.Size = new System.Drawing.Size(354, 162);
            this.txtFull.TabIndex = 15;
            this.txtFull.Visible = false;
            // 
            // lblNumEntries
            // 
            this.lblNumEntries.AutoSize = true;
            this.lblNumEntries.Location = new System.Drawing.Point(212, 170);
            this.lblNumEntries.Name = "lblNumEntries";
            this.lblNumEntries.Size = new System.Drawing.Size(0, 15);
            this.lblNumEntries.TabIndex = 16;
            // 
            // frmRaceRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 301);
            this.Controls.Add(this.lblNumEntries);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.cboDriver);
            this.Controls.Add(this.btnRegDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBoxRaceID);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRaceRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Registration";
            this.Load += new System.EventHandler(this.frmRaceRegistration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cboBoxRaceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegDriver;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.Label lblNumEntries;
    }
}