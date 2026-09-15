using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            txtMaintenanceType.MaxLength = 100;
            txtNotes.MaxLength = 4000;


            this.Load -= MaintenanceForm_Load;
            this.Load += MaintenanceForm_Load;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            btnNew.Click -= btnNew_Click;
            btnNew.Click += btnNew_Click;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            dataGridViewMaintenance.CellClick -=
                dataGridViewMaintenance_CellClick;

            dataGridViewMaintenance.CellClick +=
                dataGridViewMaintenance_CellClick;
        }

        private void MaintenanceForm_Load(
            object sender,
            EventArgs e)
        {
            LoadStatusList();
            LoadAssets();
            LoadMaintenance();
            ClearFields();
        }

        private void LoadStatusList()
        {
            cmbMaintenanceStatus.Items.Clear();

            cmbMaintenanceStatus.Items.AddRange(
                new object[]
                {
                    "Scheduled",
                    "In Progress",
                    "Completed",
                    "Cancelled",
                    "Overdue"
                });
        }

        private void LoadAssets()
        {
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            asset_id,
                            asset_name
                          FROM asset
                          ORDER BY asset_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    cmbMaintenanceAsset.DataSource =
                        table;

                    cmbMaintenanceAsset.DisplayMember =
                        "asset_name";

                    cmbMaintenanceAsset.ValueMember =
                        "asset_id";

                    cmbMaintenanceAsset.SelectedIndex =
                        -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load asset list:\n" +
                    ex.Message);
            }
        }

        private void LoadMaintenance()
        {
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            mr.maintenance_id,
                            mr.asset_id,
                            a.asset_name,
                            mr.maintenance_type,
                            mr.service_date,
                            mr.next_due_date,
                            mr.maintenance_status,
                            mr.notes
                          FROM maintenance_record mr
                          LEFT JOIN asset a
                            ON mr.asset_id =
                               a.asset_id
                          ORDER BY
                            mr.maintenance_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewMaintenance
                        .DataSource = table;

                    if (dataGridViewMaintenance
                        .Columns["asset_id"] != null)
                    {
                        dataGridViewMaintenance
                            .Columns["asset_id"]
                            .Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load maintenance records:\n" +
                    ex.Message);
            }
        }

        private void btnNew_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaintenanceID.Text))
            {
                MessageBox.Show("Use Update to change this record, or New to create another.");
                return;
            }

            if (!ValidateFields()) return;

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"INSERT INTO
                          maintenance_record
                          (
                            asset_id,
                            maintenance_type,
                            service_date,
                            next_due_date,
                            maintenance_status,
                            notes
                          )
                          VALUES
                          (
                            @asset,
                            @type,
                            @service,
                            @next,
                            @status,
                            @notes
                          )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@asset",
                            cmbMaintenanceAsset
                                .SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbMaintenanceAsset
                                  .SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@type",
                            DbText(
                                txtMaintenanceType
                                .Text));

                        cmd.Parameters.AddWithValue(
                            "@service",
                            dtpServiceDate.Checked
                                ? (object)
                                  dtpServiceDate
                                  .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@next",
                            dtpNextDueDate.Checked
                                ? (object)
                                  dtpNextDueDate
                                  .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(
                                cmbMaintenanceStatus));

                        cmd.Parameters.AddWithValue(
                            "@notes",
                            DbText(txtNotes.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadMaintenance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save maintenance record:\n" +
                    ex.Message);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateFields()) return;

            if (string.IsNullOrWhiteSpace(
                txtMaintenanceID.Text))
            {
                MessageBox.Show(
                    "Select a maintenance record first.");

                return;
            }

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"UPDATE maintenance_record
                          SET asset_id = @asset,
                              maintenance_type = @type,
                              service_date = @service,
                              next_due_date = @next,
                              maintenance_status = @status,
                              notes = @notes
                          WHERE
                            maintenance_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtMaintenanceID
                                .Text));

                        cmd.Parameters.AddWithValue(
                            "@asset",
                            cmbMaintenanceAsset
                                .SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbMaintenanceAsset
                                  .SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@type",
                            DbText(
                                txtMaintenanceType
                                .Text));

                        cmd.Parameters.AddWithValue(
                            "@service",
                            dtpServiceDate.Checked
                                ? (object)
                                  dtpServiceDate
                                  .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@next",
                            dtpNextDueDate.Checked
                                ? (object)
                                  dtpNextDueDate
                                  .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(
                                cmbMaintenanceStatus));

                        cmd.Parameters.AddWithValue(
                            "@notes",
                            DbText(txtNotes.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadMaintenance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update maintenance record:\n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtMaintenanceID.Text))
            {
                MessageBox.Show(
                    "Select a maintenance record first.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this maintenance record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"DELETE FROM
                          maintenance_record
                          WHERE
                            maintenance_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtMaintenanceID
                                .Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadMaintenance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete maintenance record:\n" +
                    ex.Message);
            }
        }

        private void dataGridViewMaintenance_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewMaintenance
                    .Rows[e.RowIndex];

            txtMaintenanceID.Text =
                row.Cells["maintenance_id"]
                   .Value?.ToString() ?? "";

            if (row.Cells["asset_id"].Value ==
                DBNull.Value)
            {
                cmbMaintenanceAsset
                    .SelectedIndex = -1;
            }
            else
            {
                cmbMaintenanceAsset
                    .SelectedValue =
                    row.Cells["asset_id"].Value;
            }

            txtMaintenanceType.Text =
                row.Cells["maintenance_type"]
                   .Value?.ToString() ?? "";

            SetDatePicker(
                dtpServiceDate,
                row.Cells["service_date"].Value);

            SetDatePicker(
                dtpNextDueDate,
                row.Cells["next_due_date"].Value);

            SetComboText(
                cmbMaintenanceStatus,
                row.Cells[
                    "maintenance_status"]
                    .Value?.ToString());

            txtNotes.Text =
                row.Cells["notes"]
                   .Value?.ToString() ?? "";
        }

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtMaintenanceType.Text))
            {
                MessageBox.Show("Maintenance type is required.");
                return false;
            }
            if (cmbMaintenanceAsset.SelectedIndex < 0)
            {
                MessageBox.Show("Select a asset.");
                return false;
            }
            if (cmbMaintenanceStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Select a maintenance status.");
                return false;
            }
            if (dtpServiceDate.Checked && dtpNextDueDate.Checked &&
                dtpNextDueDate.Value.Date < dtpServiceDate.Value.Date)
            {
                MessageBox.Show("The next due date cannot be before the service date.");
                return false;
            }
            return true;
        }

        private object DbText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return DBNull.Value;
            }

            return value.Trim();
        }

        private object ComboValue(
            ComboBox combo)
        {
            if (combo.SelectedIndex == -1)
            {
                return DBNull.Value;
            }

            return combo.Text;
        }

        private void SetComboText(
            ComboBox combo,
            string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                combo.SelectedIndex = -1;
            }
            else
            {
                if (!combo.Items.Contains(value))
                    combo.Items.Add(value);
                combo.SelectedItem = value;
            }
        }

        private void SetDatePicker(
            DateTimePicker picker,
            object value)
        {
            if (value == null ||
                value == DBNull.Value)
            {
                picker.Checked = false;

                return;
            }

            picker.Value =
                Convert.ToDateTime(value);

            picker.Checked = true;
        }

        private void ClearFields()
        {
            txtMaintenanceID.Clear();
            txtMaintenanceType.Clear();
            txtNotes.Clear();

            cmbMaintenanceAsset.SelectedIndex =
                -1;

            cmbMaintenanceStatus.SelectedIndex =
                -1;

            dtpServiceDate.Checked = false;
            dtpNextDueDate.Checked = false;
        }
    }
}
