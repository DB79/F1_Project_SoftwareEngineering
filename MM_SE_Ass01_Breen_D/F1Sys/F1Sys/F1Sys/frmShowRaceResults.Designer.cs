namespace F1Sys
{
    partial class frmShowRaceResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cboBoxRace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 23;
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
            // cboBoxRace
            // 
            this.cboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxRace.FormattingEnabled = true;
            this.cboBoxRace.Location = new System.Drawing.Point(23, 77);
            this.cboBoxRace.Name = "cboBoxRace";
            this.cboBoxRace.Size = new System.Drawing.Size(223, 23);
            this.cboBoxRace.TabIndex = 24;
            this.cboBoxRace.SelectedIndexChanged += new System.EventHandler(this.cboBoxRace_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select a race";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.grdData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(23, 117);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 70;
            this.grdData.Size = new System.Drawing.Size(814, 562);
            this.grdData.TabIndex = 26;
            // 
            // frmShowRaceResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 710);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBoxRace);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmShowRaceResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Results";
            this.Load += new System.EventHandler(this.frmShowRaceResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
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
        private System.Windows.Forms.ComboBox cboBoxRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdData;
    }
}