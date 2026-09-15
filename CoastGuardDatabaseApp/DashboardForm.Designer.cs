namespace CoastGuardDatabaseApp
{
    partial class DashboardForm
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
            this.btnStations = new System.Windows.Forms.Button();
            this.btnAssets = new System.Windows.Forms.Button();
            this.btnCrew = new System.Windows.Forms.Button();
            this.btnMissions = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlTotalAssets = new System.Windows.Forms.Panel();
            this.lblTotalAssetsValue = new System.Windows.Forms.Label();
            this.pnlTotalAssetsLabel = new System.Windows.Forms.Label();
            this.pnlAvailableAssets = new System.Windows.Forms.Panel();
            this.lblAvailableAssetsValue = new System.Windows.Forms.Label();
            this.pnlAvailableAssetsLabel = new System.Windows.Forms.Label();
            this.pnlActiveMissions = new System.Windows.Forms.Panel();
            this.lblActiveMissionsValue = new System.Windows.Forms.Label();
            this.pnlActiveMissionsLabel = new System.Windows.Forms.Label();
            this.pnlMaintenanceDue = new System.Windows.Forms.Panel();
            this.lblMaintenanceDueValue = new System.Windows.Forms.Label();
            this.pnlMaintenanceDueLabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlTotalAssets.SuspendLayout();
            this.pnlAvailableAssets.SuspendLayout();
            this.pnlActiveMissions.SuspendLayout();
            this.pnlMaintenanceDue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStations
            // 
            this.btnStations.BackColor = System.Drawing.Color.White;
            this.btnStations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStations.Location = new System.Drawing.Point(12, 180);
            this.btnStations.Margin = new System.Windows.Forms.Padding(4);
            this.btnStations.Name = "btnStations";
            this.btnStations.Size = new System.Drawing.Size(232, 100);
            this.btnStations.TabIndex = 0;
            this.btnStations.Text = "Stations \r\nManage Locations";
            this.btnStations.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStations.UseVisualStyleBackColor = false;
            this.btnStations.Click += new System.EventHandler(this.btnStations_Click);
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.White;
            this.btnAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnAssets.Location = new System.Drawing.Point(263, 180);
            this.btnAssets.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(232, 100);
            this.btnAssets.TabIndex = 1;
            this.btnAssets.Text = "Assets \r\nBoats + Vehicles";
            this.btnAssets.UseVisualStyleBackColor = false;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
            // 
            // btnCrew
            // 
            this.btnCrew.BackColor = System.Drawing.Color.White;
            this.btnCrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCrew.Location = new System.Drawing.Point(512, 180);
            this.btnCrew.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrew.Name = "btnCrew";
            this.btnCrew.Size = new System.Drawing.Size(232, 100);
            this.btnCrew.TabIndex = 2;
            this.btnCrew.Text = "Crew \r\nPersonnel";
            this.btnCrew.UseVisualStyleBackColor = false;
            this.btnCrew.Click += new System.EventHandler(this.btnCrew_Click);
            // 
            // btnMissions
            // 
            this.btnMissions.BackColor = System.Drawing.Color.White;
            this.btnMissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMissions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnMissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnMissions.Location = new System.Drawing.Point(762, 180);
            this.btnMissions.Margin = new System.Windows.Forms.Padding(4);
            this.btnMissions.Name = "btnMissions";
            this.btnMissions.Size = new System.Drawing.Size(232, 100);
            this.btnMissions.TabIndex = 3;
            this.btnMissions.Text = "Missions \r\nOperations";
            this.btnMissions.UseVisualStyleBackColor = false;
            this.btnMissions.Click += new System.EventHandler(this.btnMissions_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.White;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnMaintenance.Location = new System.Drawing.Point(1012, 180);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(232, 100);
            this.btnMaintenance.TabIndex = 4;
            this.btnMaintenance.TabStop = false;
            this.btnMaintenance.Text = "Maintenance \r\nService Records";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1258, 64);
            this.pnlHeader.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1156, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 46);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(30, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(476, 36);
            this.lblAppName.TabIndex = 14;
            this.lblAppName.Text = "COAST GUARD ASSET MANAGEMENT";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPageTitle.Location = new System.Drawing.Point(27, 88);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(500, 56);
            this.lblPageTitle.TabIndex = 19;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(32, 144);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(500, 32);
            this.lblPageSubtitle.TabIndex = 20;
            this.lblPageSubtitle.Text = "Operational asset tracking overview.";
            // 
            // pnlTotalAssets
            // 
            this.pnlTotalAssets.BackColor = System.Drawing.Color.White;
            this.pnlTotalAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsValue);
            this.pnlTotalAssets.Controls.Add(this.pnlTotalAssetsLabel);
            this.pnlTotalAssets.Location = new System.Drawing.Point(30, 360);
            this.pnlTotalAssets.Name = "pnlTotalAssets";
            this.pnlTotalAssets.Size = new System.Drawing.Size(280, 150);
            this.pnlTotalAssets.TabIndex = 21;
            // 
            // lblTotalAssetsValue
            // 
            this.lblTotalAssetsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblTotalAssetsValue.Location = new System.Drawing.Point(20, 55);
            this.lblTotalAssetsValue.Name = "lblTotalAssetsValue";
            this.lblTotalAssetsValue.Size = new System.Drawing.Size(230, 63);
            this.lblTotalAssetsValue.TabIndex = 1;
            this.lblTotalAssetsValue.Text = "0";
            // 
            // pnlTotalAssetsLabel
            // 
            this.pnlTotalAssetsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTotalAssetsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.pnlTotalAssetsLabel.Location = new System.Drawing.Point(20, 20);
            this.pnlTotalAssetsLabel.Name = "pnlTotalAssetsLabel";
            this.pnlTotalAssetsLabel.Size = new System.Drawing.Size(230, 26);
            this.pnlTotalAssetsLabel.TabIndex = 0;
            this.pnlTotalAssetsLabel.Text = "Total Assets:";
            // 
            // pnlAvailableAssets
            // 
            this.pnlAvailableAssets.BackColor = System.Drawing.Color.White;
            this.pnlAvailableAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailableAssets.Controls.Add(this.lblAvailableAssetsValue);
            this.pnlAvailableAssets.Controls.Add(this.pnlAvailableAssetsLabel);
            this.pnlAvailableAssets.Location = new System.Drawing.Point(330, 360);
            this.pnlAvailableAssets.Name = "pnlAvailableAssets";
            this.pnlAvailableAssets.Size = new System.Drawing.Size(280, 150);
            this.pnlAvailableAssets.TabIndex = 22;
            // 
            // lblAvailableAssetsValue
            // 
            this.lblAvailableAssetsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableAssetsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblAvailableAssetsValue.Location = new System.Drawing.Point(20, 55);
            this.lblAvailableAssetsValue.Name = "lblAvailableAssetsValue";
            this.lblAvailableAssetsValue.Size = new System.Drawing.Size(230, 63);
            this.lblAvailableAssetsValue.TabIndex = 2;
            this.lblAvailableAssetsValue.Text = "0";
            // 
            // pnlAvailableAssetsLabel
            // 
            this.pnlAvailableAssetsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAvailableAssetsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.pnlAvailableAssetsLabel.Location = new System.Drawing.Point(20, 20);
            this.pnlAvailableAssetsLabel.Name = "pnlAvailableAssetsLabel";
            this.pnlAvailableAssetsLabel.Size = new System.Drawing.Size(230, 26);
            this.pnlAvailableAssetsLabel.TabIndex = 1;
            this.pnlAvailableAssetsLabel.Text = "Available Assets:";
            // 
            // pnlActiveMissions
            // 
            this.pnlActiveMissions.BackColor = System.Drawing.Color.White;
            this.pnlActiveMissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveMissions.Controls.Add(this.lblActiveMissionsValue);
            this.pnlActiveMissions.Controls.Add(this.pnlActiveMissionsLabel);
            this.pnlActiveMissions.Location = new System.Drawing.Point(630, 360);
            this.pnlActiveMissions.Name = "pnlActiveMissions";
            this.pnlActiveMissions.Size = new System.Drawing.Size(280, 150);
            this.pnlActiveMissions.TabIndex = 23;
            // 
            // lblActiveMissionsValue
            // 
            this.lblActiveMissionsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMissionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblActiveMissionsValue.Location = new System.Drawing.Point(20, 55);
            this.lblActiveMissionsValue.Name = "lblActiveMissionsValue";
            this.lblActiveMissionsValue.Size = new System.Drawing.Size(230, 63);
            this.lblActiveMissionsValue.TabIndex = 2;
            this.lblActiveMissionsValue.Text = "0";
            // 
            // pnlActiveMissionsLabel
            // 
            this.pnlActiveMissionsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlActiveMissionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.pnlActiveMissionsLabel.Location = new System.Drawing.Point(20, 20);
            this.pnlActiveMissionsLabel.Name = "pnlActiveMissionsLabel";
            this.pnlActiveMissionsLabel.Size = new System.Drawing.Size(230, 26);
            this.pnlActiveMissionsLabel.TabIndex = 1;
            this.pnlActiveMissionsLabel.Text = "Active Missions:";
            // 
            // pnlMaintenanceDue
            // 
            this.pnlMaintenanceDue.BackColor = System.Drawing.Color.White;
            this.pnlMaintenanceDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaintenanceDue.Controls.Add(this.lblMaintenanceDueValue);
            this.pnlMaintenanceDue.Controls.Add(this.pnlMaintenanceDueLabel);
            this.pnlMaintenanceDue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMaintenanceDue.Location = new System.Drawing.Point(930, 360);
            this.pnlMaintenanceDue.Name = "pnlMaintenanceDue";
            this.pnlMaintenanceDue.Size = new System.Drawing.Size(280, 150);
            this.pnlMaintenanceDue.TabIndex = 24;
            // 
            // lblMaintenanceDueValue
            // 
            this.lblMaintenanceDueValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblMaintenanceDueValue.Location = new System.Drawing.Point(20, 55);
            this.lblMaintenanceDueValue.Name = "lblMaintenanceDueValue";
            this.lblMaintenanceDueValue.Size = new System.Drawing.Size(230, 63);
            this.lblMaintenanceDueValue.TabIndex = 2;
            this.lblMaintenanceDueValue.Text = "0";
            // 
            // pnlMaintenanceDueLabel
            // 
            this.pnlMaintenanceDueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMaintenanceDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.pnlMaintenanceDueLabel.Location = new System.Drawing.Point(20, 20);
            this.pnlMaintenanceDueLabel.Name = "pnlMaintenanceDueLabel";
            this.pnlMaintenanceDueLabel.Size = new System.Drawing.Size(230, 26);
            this.pnlMaintenanceDueLabel.TabIndex = 1;
            this.pnlMaintenanceDueLabel.Text = "Maintenance Due:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1258, 704);
            this.Controls.Add(this.pnlMaintenanceDue);
            this.Controls.Add(this.pnlActiveMissions);
            this.Controls.Add(this.pnlAvailableAssets);
            this.Controls.Add(this.pnlTotalAssets);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnMissions);
            this.Controls.Add(this.btnCrew);
            this.Controls.Add(this.btnAssets);
            this.Controls.Add(this.btnStations);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTotalAssets.ResumeLayout(false);
            this.pnlAvailableAssets.ResumeLayout(false);
            this.pnlActiveMissions.ResumeLayout(false);
            this.pnlMaintenanceDue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStations;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button btnCrew;
        private System.Windows.Forms.Button btnMissions;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlTotalAssets;
        private System.Windows.Forms.Label pnlTotalAssetsLabel;
        private System.Windows.Forms.Label lblTotalAssetsValue;
        private System.Windows.Forms.Panel pnlAvailableAssets;
        private System.Windows.Forms.Label lblAvailableAssetsValue;
        private System.Windows.Forms.Label pnlAvailableAssetsLabel;
        private System.Windows.Forms.Panel pnlActiveMissions;
        private System.Windows.Forms.Label lblActiveMissionsValue;
        private System.Windows.Forms.Label pnlActiveMissionsLabel;
        private System.Windows.Forms.Panel pnlMaintenanceDue;
        private System.Windows.Forms.Label pnlMaintenanceDueLabel;
        private System.Windows.Forms.Label lblMaintenanceDueValue;
    }
}