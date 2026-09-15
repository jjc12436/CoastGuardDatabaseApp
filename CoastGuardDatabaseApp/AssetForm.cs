using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
            txtAssetName.MaxLength = 100;


            this.Load -= AssetForm_Load;
            this.Load += AssetForm_Load;

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

            dataGridViewAssets.CellClick -=
                dataGridViewAssets_CellClick;

            dataGridViewAssets.CellClick +=
                dataGridViewAssets_CellClick;
        }

        private void AssetForm_Load(
            object sender,
            EventArgs e)
        {
            LoadLists();
            LoadStations();
            LoadAssets();
            ClearFields();
        }

        private void LoadLists()
        {
            cmbAssetType.Items.Clear();

            cmbAssetType.Items.AddRange(
                new object[]
                {
                    "Boat",
                    "Vehicle",
                    "Aircraft",
                    "Trailer",
                    "Other"
                });

            cmbStatus.Items.Clear();

            cmbStatus.Items.AddRange(
                new object[]
                {
                    "Available",
                    "Underway",
                    "Maintenance",
                    "Out of Service",
                    "Reserved"
                });
        }

        private void LoadStations()
        {
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            station_id,
                            station_name
                          FROM station
                          ORDER BY station_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    cmbStation.DataSource = table;
                    cmbStation.DisplayMember =
                        "station_name";

                    cmbStation.ValueMember =
                        "station_id";

                    cmbStation.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load station list:\n" +
                    ex.Message);
            }
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
                            a.asset_id,
                            a.asset_name,
                            a.asset_type,
                            a.status,
                            a.station_id,
                            s.station_name AS station
                          FROM asset a
                          LEFT JOIN station s
                            ON a.station_id = s.station_id
                          ORDER BY a.asset_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewAssets.DataSource =
                        table;

                    if (dataGridViewAssets
                        .Columns["station_id"] != null)
                    {
                        dataGridViewAssets
                            .Columns["station_id"]
                            .Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load assets:\n" +
                    ex.Message);
            }
        }

        private void btnNew_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
            txtAssetName.Focus();
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAssetID.Text))
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
                        @"INSERT INTO asset
                          (
                            asset_name,
                            asset_type,
                            status,
                            station_id
                          )
                          VALUES
                          (
                            @name,
                            @type,
                            @status,
                            @station
                          )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@name",
                            DbText(txtAssetName.Text));

                        cmd.Parameters.AddWithValue(
                            "@type",
                            ComboValue(cmbAssetType));

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(cmbStatus));

                        cmd.Parameters.AddWithValue(
                            "@station",
                            cmbStation.SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbStation.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save asset:\n" +
                    ex.Message);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateFields()) return;

            if (string.IsNullOrWhiteSpace(
                txtAssetID.Text))
            {
                MessageBox.Show(
                    "Select an asset first.");

                return;
            }

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"UPDATE asset
                          SET asset_name = @name,
                              asset_type = @type,
                              status = @status,
                              station_id = @station
                          WHERE asset_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtAssetID.Text));

                        cmd.Parameters.AddWithValue(
                            "@name",
                            DbText(txtAssetName.Text));

                        cmd.Parameters.AddWithValue(
                            "@type",
                            ComboValue(cmbAssetType));

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(cmbStatus));

                        cmd.Parameters.AddWithValue(
                            "@station",
                            cmbStation.SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbStation.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update asset:\n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtAssetID.Text))
            {
                MessageBox.Show(
                    "Select an asset first.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this asset?",
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
                        @"DELETE FROM asset
                          WHERE asset_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtAssetID.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadAssets();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("This asset is still referenced by other records. Reassign or remove the related records first.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete asset:\n" +
                    ex.Message);
            }
        }

        private void dataGridViewAssets_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewAssets.Rows[e.RowIndex];

            txtAssetID.Text =
                row.Cells["asset_id"]
                   .Value?.ToString() ?? "";

            txtAssetName.Text =
                row.Cells["asset_name"]
                   .Value?.ToString() ?? "";

            SetComboText(
                cmbAssetType,
                row.Cells["asset_type"]
                   .Value?.ToString());

            SetComboText(
                cmbStatus,
                row.Cells["status"]
                   .Value?.ToString());

            if (row.Cells["station_id"].Value ==
                DBNull.Value)
            {
                cmbStation.SelectedIndex = -1;
            }
            else
            {
                cmbStation.SelectedValue =
                    row.Cells["station_id"].Value;
            }
        }

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtAssetName.Text))
            {
                MessageBox.Show("Asset name is required.");
                return false;
            }
            if (cmbAssetType.SelectedIndex < 0)
            {
                MessageBox.Show("Select a asset type.");
                return false;
            }
            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Select a asset status.");
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

        private object ComboValue(ComboBox combo)
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

        private void ClearFields()
        {
            txtAssetID.Clear();
            txtAssetName.Clear();

            cmbAssetType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbStation.SelectedIndex = -1;
        }
    }
}
