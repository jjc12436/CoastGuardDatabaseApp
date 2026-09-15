namespace CoastGuardDatabaseApp
{
    partial class MissionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlMissionEditor = new System.Windows.Forms.Panel();
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.lblMissionID = new System.Windows.Forms.Label();
            this.txtMissionID = new System.Windows.Forms.TextBox();
            this.lblMissionType = new System.Windows.Forms.Label();
            this.cmbMissionType = new System.Windows.Forms.ComboBox();
            this.lblMissionAsset = new System.Windows.Forms.Label();
            this.cmbMissionAsset = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblMissionStatus = new System.Windows.Forms.Label();
            this.cmbMissionStatus = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMissionRecords = new System.Windows.Forms.Panel();
            this.lblMissionRecordsTitle = new System.Windows.Forms.Label();
            this.dataGridViewMissions = new System.Windows.Forms.DataGridView();
            this.pnlMissionCrew = new System.Windows.Forms.Panel();
            this.lblAssignedCrewTitle = new System.Windows.Forms.Label();
            this.dataGridViewMissionCrew = new System.Windows.Forms.DataGridView();
            this.lblCrewMember = new System.Windows.Forms.Label();
            this.cmbCrewMember = new System.Windows.Forms.ComboBox();
            this.lblRoleOnMission = new System.Windows.Forms.Label();
            this.txtRoleOnMission = new System.Windows.Forms.TextBox();
            this.btnAssignCrew = new System.Windows.Forms.Button();
            this.btnRemoveCrew = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMissionEditor.SuspendLayout();
            this.pnlMissionRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).BeginInit();
            this.pnlMissionCrew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1258, 64);
            this.pnlHeader.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(102)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(140, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(476, 36);
            this.lblAppName.TabIndex = 14;
            this.lblAppName.Text = "COAST GUARD ASSET MANAGEMENT";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPageTitle.Location = new System.Drawing.Point(30, 88);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(500, 56);
            this.lblPageTitle.TabIndex = 19;
            this.lblPageTitle.Text = "Missions";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(32, 144);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(650, 36);
            this.lblPageSubtitle.TabIndex = 20;
            this.lblPageSubtitle.Text = "Create missions, assign assets, and manage participating crew.";
            // 
            // pnlMissionEditor
            // 
            this.pnlMissionEditor.BackColor = System.Drawing.Color.White;
            this.pnlMissionEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMissionEditor.Controls.Add(this.btnDelete);
            this.pnlMissionEditor.Controls.Add(this.btnUpdate);
            this.pnlMissionEditor.Controls.Add(this.btnSave);
            this.pnlMissionEditor.Controls.Add(this.btnNew);
            this.pnlMissionEditor.Controls.Add(this.cmbMissionStatus);
            this.pnlMissionEditor.Controls.Add(this.lblMissionStatus);
            this.pnlMissionEditor.Controls.Add(this.dtpEndDate);
            this.pnlMissionEditor.Controls.Add(this.dtpStartDate);
            this.pnlMissionEditor.Controls.Add(this.cmbMissionAsset);
            this.pnlMissionEditor.Controls.Add(this.cmbMissionType);
            this.pnlMissionEditor.Controls.Add(this.lblMissionAsset);
            this.pnlMissionEditor.Controls.Add(this.lblMissionType);
            this.pnlMissionEditor.Controls.Add(this.txtMissionID);
            this.pnlMissionEditor.Controls.Add(this.lblMissionID);
            this.pnlMissionEditor.Controls.Add(this.lblEditorTitle);
            this.pnlMissionEditor.Controls.Add(this.lblStartDate);
            this.pnlMissionEditor.Controls.Add(this.lblEndDate);
            this.pnlMissionEditor.Location = new System.Drawing.Point(30, 175);
            this.pnlMissionEditor.Name = "pnlMissionEditor";
            this.pnlMissionEditor.Size = new System.Drawing.Size(380, 523);
            this.pnlMissionEditor.TabIndex = 21;
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblEditorTitle.Location = new System.Drawing.Point(20, 16);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Size = new System.Drawing.Size(300, 28);
            this.lblEditorTitle.TabIndex = 1;
            this.lblEditorTitle.Text = "Mission Information";
            // 
            // lblMissionID
            // 
            this.lblMissionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMissionID.Location = new System.Drawing.Point(20, 54);
            this.lblMissionID.Name = "lblMissionID";
            this.lblMissionID.Size = new System.Drawing.Size(300, 20);
            this.lblMissionID.TabIndex = 2;
            this.lblMissionID.Text = "Mission ID:";
            // 
            // txtMissionID
            // 
            this.txtMissionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtMissionID.Location = new System.Drawing.Point(20, 76);
            this.txtMissionID.Name = "txtMissionID";
            this.txtMissionID.ReadOnly = true;
            this.txtMissionID.Size = new System.Drawing.Size(338, 34);
            this.txtMissionID.TabIndex = 3;
            // 
            // lblMissionType
            // 
            this.lblMissionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMissionType.Location = new System.Drawing.Point(20, 110);
            this.lblMissionType.Name = "lblMissionType";
            this.lblMissionType.Size = new System.Drawing.Size(300, 24);
            this.lblMissionType.TabIndex = 4;
            this.lblMissionType.Text = "Mission Type:";
            // 
            // cmbMissionType
            // 
            this.cmbMissionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionType.FormattingEnabled = true;
            this.cmbMissionType.Location = new System.Drawing.Point(20, 135);
            this.cmbMissionType.Name = "cmbMissionType";
            this.cmbMissionType.Size = new System.Drawing.Size(338, 36);
            this.cmbMissionType.TabIndex = 5;
            // 
            // lblMissionAsset
            // 
            this.lblMissionAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMissionAsset.Location = new System.Drawing.Point(20, 169);
            this.lblMissionAsset.Name = "lblMissionAsset";
            this.lblMissionAsset.Size = new System.Drawing.Size(300, 24);
            this.lblMissionAsset.TabIndex = 6;
            this.lblMissionAsset.Text = "Asset: ";
            // 
            // cmbMissionAsset
            // 
            this.cmbMissionAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionAsset.FormattingEnabled = true;
            this.cmbMissionAsset.Location = new System.Drawing.Point(20, 192);
            this.cmbMissionAsset.Name = "cmbMissionAsset";
            this.cmbMissionAsset.Size = new System.Drawing.Size(338, 36);
            this.cmbMissionAsset.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblStartDate.Location = new System.Drawing.Point(20, 226);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(300, 24);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(20, 248);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(338, 34);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblEndDate.Location = new System.Drawing.Point(20, 281);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(300, 24);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(20, 303);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(338, 34);
            this.dtpEndDate.TabIndex = 11;
            // 
            // lblMissionStatus
            // 
            this.lblMissionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMissionStatus.Location = new System.Drawing.Point(20, 337);
            this.lblMissionStatus.Name = "lblMissionStatus";
            this.lblMissionStatus.Size = new System.Drawing.Size(300, 24);
            this.lblMissionStatus.TabIndex = 12;
            this.lblMissionStatus.Text = "Status:";
            // 
            // cmbMissionStatus
            // 
            this.cmbMissionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMissionStatus.FormattingEnabled = true;
            this.cmbMissionStatus.Location = new System.Drawing.Point(21, 359);
            this.cmbMissionStatus.Name = "cmbMissionStatus";
            this.cmbMissionStatus.Size = new System.Drawing.Size(338, 36);
            this.cmbMissionStatus.TabIndex = 13;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnNew.Location = new System.Drawing.Point(20, 414);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 42);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(52)))), ((int)(((byte)(47)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(195, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlMissionRecords
            // 
            this.pnlMissionRecords.BackColor = System.Drawing.Color.White;
            this.pnlMissionRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMissionRecords.Controls.Add(this.dataGridViewMissions);
            this.pnlMissionRecords.Controls.Add(this.lblMissionRecordsTitle);
            this.pnlMissionRecords.Location = new System.Drawing.Point(430, 175);
            this.pnlMissionRecords.Name = "pnlMissionRecords";
            this.pnlMissionRecords.Size = new System.Drawing.Size(820, 523);
            this.pnlMissionRecords.TabIndex = 22;
            // 
            // lblMissionRecordsTitle
            // 
            this.lblMissionRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblMissionRecordsTitle.Location = new System.Drawing.Point(20, 18);
            this.lblMissionRecordsTitle.Name = "lblMissionRecordsTitle";
            this.lblMissionRecordsTitle.Size = new System.Drawing.Size(300, 28);
            this.lblMissionRecordsTitle.TabIndex = 1;
            this.lblMissionRecordsTitle.Text = "Mission Records";
            // 
            // dataGridViewMissions
            // 
            this.dataGridViewMissions.AllowUserToAddRows = false;
            this.dataGridViewMissions.AllowUserToDeleteRows = false;
            this.dataGridViewMissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMissions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMissions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMissions.EnableHeadersVisualStyles = false;
            this.dataGridViewMissions.Location = new System.Drawing.Point(20, 58);
            this.dataGridViewMissions.MultiSelect = false;
            this.dataGridViewMissions.Name = "dataGridViewMissions";
            this.dataGridViewMissions.ReadOnly = true;
            this.dataGridViewMissions.RowHeadersVisible = false;
            this.dataGridViewMissions.RowHeadersWidth = 62;
            this.dataGridViewMissions.RowTemplate.Height = 28;
            this.dataGridViewMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMissions.Size = new System.Drawing.Size(778, 180);
            this.dataGridViewMissions.TabIndex = 2;
            // 
            // pnlMissionCrew
            // 
            this.pnlMissionCrew.BackColor = System.Drawing.Color.White;
            this.pnlMissionCrew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMissionCrew.Controls.Add(this.btnRemoveCrew);
            this.pnlMissionCrew.Controls.Add(this.btnAssignCrew);
            this.pnlMissionCrew.Controls.Add(this.txtRoleOnMission);
            this.pnlMissionCrew.Controls.Add(this.lblRoleOnMission);
            this.pnlMissionCrew.Controls.Add(this.cmbCrewMember);
            this.pnlMissionCrew.Controls.Add(this.lblCrewMember);
            this.pnlMissionCrew.Controls.Add(this.dataGridViewMissionCrew);
            this.pnlMissionCrew.Controls.Add(this.lblAssignedCrewTitle);
            this.pnlMissionCrew.Location = new System.Drawing.Point(430, 430);
            this.pnlMissionCrew.Name = "pnlMissionCrew";
            this.pnlMissionCrew.Size = new System.Drawing.Size(820, 268);
            this.pnlMissionCrew.TabIndex = 23;
            // 
            // lblAssignedCrewTitle
            // 
            this.lblAssignedCrewTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedCrewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblAssignedCrewTitle.Location = new System.Drawing.Point(20, 16);
            this.lblAssignedCrewTitle.Name = "lblAssignedCrewTitle";
            this.lblAssignedCrewTitle.Size = new System.Drawing.Size(300, 34);
            this.lblAssignedCrewTitle.TabIndex = 0;
            this.lblAssignedCrewTitle.Text = "Assigned Crew";
            // 
            // dataGridViewMissionCrew
            // 
            this.dataGridViewMissionCrew.AllowUserToAddRows = false;
            this.dataGridViewMissionCrew.AllowUserToDeleteRows = false;
            this.dataGridViewMissionCrew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMissionCrew.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMissionCrew.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMissionCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMissionCrew.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMissionCrew.EnableHeadersVisualStyles = false;
            this.dataGridViewMissionCrew.Location = new System.Drawing.Point(20, 50);
            this.dataGridViewMissionCrew.MultiSelect = false;
            this.dataGridViewMissionCrew.Name = "dataGridViewMissionCrew";
            this.dataGridViewMissionCrew.ReadOnly = true;
            this.dataGridViewMissionCrew.RowHeadersVisible = false;
            this.dataGridViewMissionCrew.RowHeadersWidth = 62;
            this.dataGridViewMissionCrew.RowTemplate.Height = 28;
            this.dataGridViewMissionCrew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMissionCrew.Size = new System.Drawing.Size(490, 205);
            this.dataGridViewMissionCrew.TabIndex = 3;
            // 
            // lblCrewMember
            // 
            this.lblCrewMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCrewMember.Location = new System.Drawing.Point(530, 50);
            this.lblCrewMember.Name = "lblCrewMember";
            this.lblCrewMember.Size = new System.Drawing.Size(265, 20);
            this.lblCrewMember.TabIndex = 4;
            this.lblCrewMember.Text = "Crew Member";
            // 
            // cmbCrewMember
            // 
            this.cmbCrewMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrewMember.FormattingEnabled = true;
            this.cmbCrewMember.Location = new System.Drawing.Point(530, 72);
            this.cmbCrewMember.Name = "cmbCrewMember";
            this.cmbCrewMember.Size = new System.Drawing.Size(265, 36);
            this.cmbCrewMember.TabIndex = 5;
            // 
            // lblRoleOnMission
            // 
            this.lblRoleOnMission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleOnMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblRoleOnMission.Location = new System.Drawing.Point(530, 116);
            this.lblRoleOnMission.Name = "lblRoleOnMission";
            this.lblRoleOnMission.Size = new System.Drawing.Size(265, 20);
            this.lblRoleOnMission.TabIndex = 6;
            this.lblRoleOnMission.Text = "Role on Mission";
            // 
            // txtRoleOnMission
            // 
            this.txtRoleOnMission.Location = new System.Drawing.Point(530, 138);
            this.txtRoleOnMission.Name = "txtRoleOnMission";
            this.txtRoleOnMission.Size = new System.Drawing.Size(265, 34);
            this.txtRoleOnMission.TabIndex = 7;
            // 
            // btnAssignCrew
            // 
            this.btnAssignCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnAssignCrew.FlatAppearance.BorderSize = 0;
            this.btnAssignCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignCrew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCrew.ForeColor = System.Drawing.Color.White;
            this.btnAssignCrew.Location = new System.Drawing.Point(530, 190);
            this.btnAssignCrew.Name = "btnAssignCrew";
            this.btnAssignCrew.Size = new System.Drawing.Size(125, 38);
            this.btnAssignCrew.TabIndex = 9;
            this.btnAssignCrew.Text = "Assign Crew";
            this.btnAssignCrew.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCrew
            // 
            this.btnRemoveCrew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(52)))), ((int)(((byte)(47)))));
            this.btnRemoveCrew.FlatAppearance.BorderSize = 0;
            this.btnRemoveCrew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCrew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCrew.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCrew.Location = new System.Drawing.Point(670, 190);
            this.btnRemoveCrew.Name = "btnRemoveCrew";
            this.btnRemoveCrew.Size = new System.Drawing.Size(125, 38);
            this.btnRemoveCrew.TabIndex = 10;
            this.btnRemoveCrew.Text = "Remove Crew";
            this.btnRemoveCrew.UseVisualStyleBackColor = false;
            // 
            // MissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1258, 704);
            this.Controls.Add(this.pnlMissionCrew);
            this.Controls.Add(this.pnlMissionRecords);
            this.Controls.Add(this.pnlMissionEditor);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblPageSubtitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission";
            this.pnlHeader.ResumeLayout(false);
            this.pnlMissionEditor.ResumeLayout(false);
            this.pnlMissionEditor.PerformLayout();
            this.pnlMissionRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).EndInit();
            this.pnlMissionCrew.ResumeLayout(false);
            this.pnlMissionCrew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionCrew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlMissionEditor;
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.TextBox txtMissionID;
        private System.Windows.Forms.Label lblMissionID;
        private System.Windows.Forms.Label lblMissionType;
        private System.Windows.Forms.ComboBox cmbMissionAsset;
        private System.Windows.Forms.ComboBox cmbMissionType;
        private System.Windows.Forms.Label lblMissionAsset;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbMissionStatus;
        private System.Windows.Forms.Label lblMissionStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlMissionRecords;
        private System.Windows.Forms.Label lblMissionRecordsTitle;
        private System.Windows.Forms.DataGridView dataGridViewMissions;
        private System.Windows.Forms.Panel pnlMissionCrew;
        private System.Windows.Forms.Label lblCrewMember;
        private System.Windows.Forms.DataGridView dataGridViewMissionCrew;
        private System.Windows.Forms.Label lblAssignedCrewTitle;
        private System.Windows.Forms.Button btnRemoveCrew;
        private System.Windows.Forms.Button btnAssignCrew;
        private System.Windows.Forms.TextBox txtRoleOnMission;
        private System.Windows.Forms.Label lblRoleOnMission;
        private System.Windows.Forms.ComboBox cmbCrewMember;
    }
}