using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            txtStationID.ReadOnly = true;
            dataGridViewStations.ReadOnly = true;
            dataGridViewStations.AllowUserToAddRows = false;
            dataGridViewStations.AllowUserToDeleteRows = false;
            txtStationName.MaxLength = 100;
            txtLocation.MaxLength = 150;


            this.Load -= StationForm_Load;
            this.Load += StationForm_Load;

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

            dataGridViewStations.CellClick -=
                dataGridViewStations_CellClick;

            dataGridViewStations.CellClick +=
                dataGridViewStations_CellClick;
        }

        private void StationForm_Load(
            object sender,
            EventArgs e)
        {
            LoadStations();
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
                            station_name,
                            location
                          FROM station
                          ORDER BY station_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewStations.DataSource =
                        table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load stations:\n" +
                    ex.Message);
            }
        }

        private void btnNew_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
            txtStationName.Focus();
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStationID.Text))
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
                        @"INSERT INTO station
                          (station_name, location)
                          VALUES
                          (@name, @location)";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@name",
                            DbText(txtStationName.Text));

                        cmd.Parameters.AddWithValue(
                            "@location",
                            DbText(txtLocation.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadStations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save station:\n" +
                    ex.Message);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateFields()) return;

            if (string.IsNullOrWhiteSpace(
                txtStationID.Text))
            {
                MessageBox.Show(
                    "Select a station first.");

                return;
            }

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"UPDATE station
                          SET station_name = @name,
                              location = @location
                          WHERE station_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtStationID.Text));

                        cmd.Parameters.AddWithValue(
                            "@name",
                            DbText(txtStationName.Text));

                        cmd.Parameters.AddWithValue(
                            "@location",
                            DbText(txtLocation.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadStations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update station:\n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtStationID.Text))
            {
                MessageBox.Show(
                    "Select a station first.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this station?",
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
                        @"DELETE FROM station
                          WHERE station_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtStationID.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadStations();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show("This station is still referenced by other records. Reassign or remove the related records first.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete station:\n" +
                    ex.Message);
            }
        }

        private void dataGridViewStations_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewStations.Rows[e.RowIndex];

            txtStationID.Text =
                row.Cells["station_id"]
                   .Value?.ToString() ?? "";

            txtStationName.Text =
                row.Cells["station_name"]
                   .Value?.ToString() ?? "";

            txtLocation.Text =
                row.Cells["location"]
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
            if (string.IsNullOrWhiteSpace(txtStationName.Text))
            {
                MessageBox.Show("Station name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Location is required.");
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

        private void ClearFields()
        {
            txtStationID.Clear();
            txtStationName.Clear();
            txtLocation.Clear();
        }


        private void txtStationName_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dataGridViewStations_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}
