namespace CoastGuardDatabaseApp
{
    partial class MaintenanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlMaintenanceEditor = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtMaintenanceType = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cmbMaintenanceStatus = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpNextDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblMaintenanceStatus = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblNextDueDate = new System.Windows.Forms.Label();
            this.cmbMaintenanceAsset = new System.Windows.Forms.ComboBox();
            this.txtMaintenanceID = new System.Windows.Forms.TextBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblMaintenanceType = new System.Windows.Forms.Label();
            this.lblMaintenanceAsset = new System.Windows.Forms.Label();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.pnlMaintenanceRecords = new System.Windows.Forms.Panel();
            this.dataGridViewMaintenance = new System.Windows.Forms.DataGridView();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMaintenanceEditor.SuspendLayout();
            this.pnlMaintenanceRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1258, 64);
            this.pnlHeader.TabIndex = 13;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(140, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(476, 36);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "COAST GUARD ASSET MANAGEMENT";
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
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 88);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(500, 56);
            this.lblPageTitle.TabIndex = 19;
            this.lblPageTitle.Text = "Maintenance";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(32, 144);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(650, 28);
            this.lblPageSubtitle.TabIndex = 20;
            this.lblPageSubtitle.Text = "Track completed, scheduled, and ongoing asset maintenance.";
            // 
            // pnlMaintenanceEditor
            // 
            this.pnlMaintenanceEditor.BackColor = System.Drawing.Color.White;
            this.pnlMaintenanceEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaintenanceEditor.Controls.Add(this.btnDelete);
            this.pnlMaintenanceEditor.Controls.Add(this.btnSave);
            this.pnlMaintenanceEditor.Controls.Add(this.btnUpdate);
            this.pnlMaintenanceEditor.Controls.Add(this.btnNew);
            this.pnlMaintenanceEditor.Controls.Add(this.txtMaintenanceType);
            this.pnlMaintenanceEditor.Controls.Add(this.txtNotes);
            this.pnlMaintenanceEditor.Controls.Add(this.cmbMaintenanceStatus);
            this.pnlMaintenanceEditor.Controls.Add(this.lblNotes);
            this.pnlMaintenanceEditor.Controls.Add(this.dtpNextDueDate);
            this.pnlMaintenanceEditor.Controls.Add(this.lblMaintenanceStatus);
            this.pnlMaintenanceEditor.Controls.Add(this.dtpServiceDate);
            this.pnlMaintenanceEditor.Controls.Add(this.lblNextDueDate);
            this.pnlMaintenanceEditor.Controls.Add(this.cmbMaintenanceAsset);
            this.pnlMaintenanceEditor.Controls.Add(this.txtMaintenanceID);
            this.pnlMaintenanceEditor.Controls.Add(this.lblServiceDate);
            this.pnlMaintenanceEditor.Controls.Add(this.lblMaintenanceType);
            this.pnlMaintenanceEditor.Controls.Add(this.lblMaintenanceAsset);
            this.pnlMaintenanceEditor.Controls.Add(this.lblMaintenanceID);
            this.pnlMaintenanceEditor.Controls.Add(this.lblEditorTitle);
            this.pnlMaintenanceEditor.Location = new System.Drawing.Point(30, 175);
            this.pnlMaintenanceEditor.Name = "pnlMaintenanceEditor";
            this.pnlMaintenanceEditor.Size = new System.Drawing.Size(380, 523);
            this.pnlMaintenanceEditor.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(52)))), ((int)(((byte)(47)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(195, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnNew.Location = new System.Drawing.Point(20, 437);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 36);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtMaintenanceType
            // 
            this.txtMaintenanceType.Location = new System.Drawing.Point(20, 182);
            this.txtMaintenanceType.Name = "txtMaintenanceType";
            this.txtMaintenanceType.Size = new System.Drawing.Size(338, 34);
            this.txtMaintenanceType.TabIndex = 7;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(20, 400);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(338, 34);
            this.txtNotes.TabIndex = 16;
            // 
            // cmbMaintenanceStatus
            // 
            this.cmbMaintenanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaintenanceStatus.FormattingEnabled = true;
            this.cmbMaintenanceStatus.Location = new System.Drawing.Point(20, 345);
            this.cmbMaintenanceStatus.Name = "cmbMaintenanceStatus";
            this.cmbMaintenanceStatus.Size = new System.Drawing.Size(338, 36);
            this.cmbMaintenanceStatus.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblNotes.Location = new System.Drawing.Point(20, 379);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(350, 20);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes:";
            // 
            // dtpNextDueDate
            // 
            this.dtpNextDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextDueDate.Location = new System.Drawing.Point(20, 291);
            this.dtpNextDueDate.Name = "dtpNextDueDate";
            this.dtpNextDueDate.ShowCheckBox = true;
            this.dtpNextDueDate.Size = new System.Drawing.Size(338, 34);
            this.dtpNextDueDate.TabIndex = 12;
            // 
            // lblMaintenanceStatus
            // 
            this.lblMaintenanceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMaintenanceStatus.Location = new System.Drawing.Point(20, 323);
            this.lblMaintenanceStatus.Name = "lblMaintenanceStatus";
            this.lblMaintenanceStatus.Size = new System.Drawing.Size(350, 20);
            this.lblMaintenanceStatus.TabIndex = 13;
            this.lblMaintenanceStatus.Text = "Status:";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(20, 237);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.ShowCheckBox = true;
            this.dtpServiceDate.Size = new System.Drawing.Size(338, 34);
            this.dtpServiceDate.TabIndex = 10;
            // 
            // lblNextDueDate
            // 
            this.lblNextDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblNextDueDate.Location = new System.Drawing.Point(20, 269);
            this.lblNextDueDate.Name = "lblNextDueDate";
            this.lblNextDueDate.Size = new System.Drawing.Size(350, 20);
            this.lblNextDueDate.TabIndex = 11;
            this.lblNextDueDate.Text = "Next Due Date:";
            // 
            // cmbMaintenanceAsset
            // 
            this.cmbMaintenanceAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaintenanceAsset.FormattingEnabled = true;
            this.cmbMaintenanceAsset.Location = new System.Drawing.Point(20, 126);
            this.cmbMaintenanceAsset.Name = "cmbMaintenanceAsset";
            this.cmbMaintenanceAsset.Size = new System.Drawing.Size(338, 36);
            this.cmbMaintenanceAsset.TabIndex = 5;
            // 
            // txtMaintenanceID
            // 
            this.txtMaintenanceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtMaintenanceID.Location = new System.Drawing.Point(20, 73);
            this.txtMaintenanceID.Name = "txtMaintenanceID";
            this.txtMaintenanceID.ReadOnly = true;
            this.txtMaintenanceID.Size = new System.Drawing.Size(338, 34);
            this.txtMaintenanceID.TabIndex = 3;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblServiceDate.Location = new System.Drawing.Point(21, 215);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(350, 20);
            this.lblServiceDate.TabIndex = 8;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // lblMaintenanceType
            // 
            this.lblMaintenanceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMaintenanceType.Location = new System.Drawing.Point(20, 160);
            this.lblMaintenanceType.Name = "lblMaintenanceType";
            this.lblMaintenanceType.Size = new System.Drawing.Size(350, 24);
            this.lblMaintenanceType.TabIndex = 6;
            this.lblMaintenanceType.Text = "Maintenance Type:";
            // 
            // lblMaintenanceAsset
            // 
            this.lblMaintenanceAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMaintenanceAsset.Location = new System.Drawing.Point(20, 104);
            this.lblMaintenanceAsset.Name = "lblMaintenanceAsset";
            this.lblMaintenanceAsset.Size = new System.Drawing.Size(350, 20);
            this.lblMaintenanceAsset.TabIndex = 4;
            this.lblMaintenanceAsset.Text = "Asset:";
            // 
            // lblMaintenanceID
            // 
            this.lblMaintenanceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblMaintenanceID.Location = new System.Drawing.Point(20, 50);
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            this.lblMaintenanceID.Size = new System.Drawing.Size(350, 20);
            this.lblMaintenanceID.TabIndex = 2;
            this.lblMaintenanceID.Text = "Maintenance ID:";
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblEditorTitle.Location = new System.Drawing.Point(20, 14);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Size = new System.Drawing.Size(309, 28);
            this.lblEditorTitle.TabIndex = 1;
            this.lblEditorTitle.Text = "Maintenance Information";
            // 
            // pnlMaintenanceRecords
            // 
            this.pnlMaintenanceRecords.BackColor = System.Drawing.Color.White;
            this.pnlMaintenanceRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaintenanceRecords.Controls.Add(this.dataGridViewMaintenance);
            this.pnlMaintenanceRecords.Controls.Add(this.lblRecordsTitle);
            this.pnlMaintenanceRecords.Location = new System.Drawing.Point(430, 175);
            this.pnlMaintenanceRecords.Name = "pnlMaintenanceRecords";
            this.pnlMaintenanceRecords.Size = new System.Drawing.Size(820, 523);
            this.pnlMaintenanceRecords.TabIndex = 22;
            // 
            // dataGridViewMaintenance
            // 
            this.dataGridViewMaintenance.AllowUserToAddRows = false;
            this.dataGridViewMaintenance.AllowUserToDeleteRows = false;
            this.dataGridViewMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaintenance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMaintenance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMaintenance.EnableHeadersVisualStyles = false;
            this.dataGridViewMaintenance.Location = new System.Drawing.Point(20, 58);
            this.dataGridViewMaintenance.MultiSelect = false;
            this.dataGridViewMaintenance.Name = "dataGridViewMaintenance";
            this.dataGridViewMaintenance.ReadOnly = true;
            this.dataGridViewMaintenance.RowHeadersVisible = false;
            this.dataGridViewMaintenance.RowHeadersWidth = 62;
            this.dataGridViewMaintenance.RowTemplate.Height = 28;
            this.dataGridViewMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaintenance.Size = new System.Drawing.Size(778, 450);
            this.dataGridViewMaintenance.TabIndex = 2;
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblRecordsTitle.Location = new System.Drawing.Point(20, 18);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(300, 28);
            this.lblRecordsTitle.TabIndex = 1;
            this.lblRecordsTitle.Text = "Maintenance Records";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1258, 704);
            this.Controls.Add(this.pnlMaintenanceRecords);
            this.Controls.Add(this.pnlMaintenanceEditor);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.pnlHeader.ResumeLayout(false);
            this.pnlMaintenanceEditor.ResumeLayout(false);
            this.pnlMaintenanceEditor.PerformLayout();
            this.pnlMaintenanceRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlMaintenanceEditor;
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.Label lblMaintenanceID;
        private System.Windows.Forms.TextBox txtMaintenanceID;
        private System.Windows.Forms.Label lblMaintenanceType;
        private System.Windows.Forms.ComboBox cmbMaintenanceAsset;
        private System.Windows.Forms.Label lblMaintenanceAsset;
        private System.Windows.Forms.TextBox txtMaintenanceType;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.ComboBox cmbMaintenanceStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtpNextDueDate;
        private System.Windows.Forms.Label lblMaintenanceStatus;
        private System.Windows.Forms.Label lblNextDueDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlMaintenanceRecords;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.DataGridView dataGridViewMaintenance;
    }
}