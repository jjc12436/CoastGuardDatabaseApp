using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class CrewForm : Form
    {
        public CrewForm()
        {
            InitializeComponent();
            txtFirstName.MaxLength = 50;
            txtLastName.MaxLength = 50;
            txtRank.MaxLength = 50;
            txtQualification.MaxLength = 255;


            this.Load -= CrewForm_Load;
            this.Load += CrewForm_Load;

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

            dataGridViewCrew.CellClick -=
                dataGridViewCrew_CellClick;

            dataGridViewCrew.CellClick +=
                dataGridViewCrew_CellClick;
        }

        private void CrewForm_Load(
            object sender,
            EventArgs e)
        {
            LoadCrew();
        }

        private void LoadCrew()
        {
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            crew_id,
                            first_name,
                            last_name,
                            rank_name,
                            qualification
                          FROM crew_member
                          ORDER BY crew_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewCrew.DataSource =
                        table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load crew:\n" +
                    ex.Message);
            }
        }

        private void btnNew_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
            txtFirstName.Focus();
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCrewID.Text))
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
                        @"INSERT INTO crew_member
                          (
                            first_name,
                            last_name,
                            rank_name,
                            qualification
                          )
                          VALUES
                          (
                            @first,
                            @last,
                            @rank,
                            @qualification
                          )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@first",
                            DbText(txtFirstName.Text));

                        cmd.Parameters.AddWithValue(
                            "@last",
                            DbText(txtLastName.Text));

                        cmd.Parameters.AddWithValue(
                            "@rank",
                            DbText(txtRank.Text));

                        cmd.Parameters.AddWithValue(
                            "@qualification",
                            DbText(
                                txtQualification.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadCrew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save crew member:\n" +
                    ex.Message);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateFields()) return;

            if (string.IsNullOrWhiteSpace(
                txtCrewID.Text))
            {
                MessageBox.Show(
                    "Select a crew member first.");

                return;
            }

            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"UPDATE crew_member
                          SET first_name = @first,
                              last_name = @last,
                              rank_name = @rank,
                              qualification = @qualification
                          WHERE crew_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtCrewID.Text));

                        cmd.Parameters.AddWithValue(
                            "@first",
                            DbText(txtFirstName.Text));

                        cmd.Parameters.AddWithValue(
                            "@last",
                            DbText(txtLastName.Text));

                        cmd.Parameters.AddWithValue(
                            "@rank",
                            DbText(txtRank.Text));

                        cmd.Parameters.AddWithValue(
                            "@qualification",
                            DbText(
                                txtQualification.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearFields();
                LoadCrew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update crew member:\n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtCrewID.Text, out id))
            {
                MessageBox.Show("Select a crew member first.");
                return;
            }
            if (MessageBox.Show(
                "Delete this crew member and all of its crew assignments?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // InnoDB is required. Disposal rolls back if either command fails.
                        using (var cmd = new MySqlCommand(
                            "DELETE FROM mission_crew WHERE crew_id = @id", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new MySqlCommand(
                            "DELETE FROM crew_member WHERE crew_id = @id", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            if (cmd.ExecuteNonQuery() != 1)
                                throw new InvalidOperationException(
                                    "The record no longer exists. Reopen this page to refresh it.");
                        }
                        transaction.Commit();
                    }
                }
                ClearFields();
                LoadCrew();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete crew member:\n" + ex.Message);
            }
        }

        private void dataGridViewCrew_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewCrew.Rows[e.RowIndex];

            txtCrewID.Text =
                row.Cells["crew_id"]
                   .Value?.ToString() ?? "";

            txtFirstName.Text =
                row.Cells["first_name"]
                   .Value?.ToString() ?? "";

            txtLastName.Text =
                row.Cells["last_name"]
                   .Value?.ToString() ?? "";

            txtRank.Text =
                row.Cells["rank_name"]
                   .Value?.ToString() ?? "";

            txtQualification.Text =
                row.Cells["qualification"]
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.");
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
            txtCrewID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtRank.Clear();
            txtQualification.Clear();
        }
    }
}
