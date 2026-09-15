using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class MissionForm : Form
    {
        public MissionForm()
        {
            InitializeComponent();
            txtRoleOnMission.MaxLength = 100;


            this.Load -= MissionForm_Load;
            this.Load += MissionForm_Load;

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

            btnAssignCrew.Click -=
                btnAssignCrew_Click;

            btnAssignCrew.Click +=
                btnAssignCrew_Click;

            btnRemoveCrew.Click -=
                btnRemoveCrew_Click;

            btnRemoveCrew.Click +=
                btnRemoveCrew_Click;

            dataGridViewMissions.CellClick -=
                dataGridViewMissions_CellClick;

            dataGridViewMissions.CellClick +=
                dataGridViewMissions_CellClick;

            dataGridViewMissionCrew.CellClick -=
                dataGridViewMissionCrew_CellClick;

            dataGridViewMissionCrew.CellClick +=
                dataGridViewMissionCrew_CellClick;
        }

        private void MissionForm_Load(
            object sender,
            EventArgs e)
        {
            LoadLists();
            LoadAssets();
            LoadCrewMembers();
            LoadMissions();
            ClearFields();
        }

        private void LoadLists()
        {
            cmbMissionType.Items.Clear();

            cmbMissionType.Items.AddRange(
                new object[]
                {
                    "Search and Rescue",
                    "Law Enforcement",
                    "Safety Patrol",
                    "Training",
                    "Security",
                    "Environmental Response",
                    "Other"
                });

            cmbMissionStatus.Items.Clear();

            cmbMissionStatus.Items.AddRange(
                new object[]
                {
                    "Planned",
                    "Active",
                    "Completed",
                    "Cancelled"
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

                    cmbMissionAsset.DataSource =
                        table;

                    cmbMissionAsset.DisplayMember =
                        "asset_name";

                    cmbMissionAsset.ValueMember =
                        "asset_id";

                    cmbMissionAsset.SelectedIndex =
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

        private void LoadCrewMembers()
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
                            CONCAT(
                                first_name,
                                ' ',
                                last_name
                            ) AS crew_name
                          FROM crew_member
                          ORDER BY crew_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    cmbCrewMember.DataSource =
                        table;

                    cmbCrewMember.DisplayMember =
                        "crew_name";

                    cmbCrewMember.ValueMember =
                        "crew_id";

                    cmbCrewMember.SelectedIndex =
                        -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load crew list:\n" +
                    ex.Message);
            }
        }

        private void LoadMissions()
        {
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            m.mission_id,
                            m.mission_type,
                            m.start_date,
                            m.end_date,
                            m.status,
                            m.asset_id,
                            a.asset_name
                          FROM mission m
                          LEFT JOIN asset a
                            ON m.asset_id =
                               a.asset_id
                          ORDER BY
                            m.mission_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewMissions.DataSource =
                        table;

                    if (dataGridViewMissions
                        .Columns["asset_id"] != null)
                    {
                        dataGridViewMissions
                            .Columns["asset_id"]
                            .Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load missions:\n" +
                    ex.Message);
            }
        }

        private void LoadMissionCrew(
            int missionID)
        {
            dataGridViewMissionCrew.DataSource = null;
            try
            {
                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT
                            mc.crew_id,
                            CONCAT(
                                c.first_name,
                                ' ',
                                c.last_name
                            ) AS crew_member,
                            c.rank_name,
                            mc.role_on_mission
                          FROM mission_crew mc
                          JOIN crew_member c
                            ON mc.crew_id =
                               c.crew_id
                          WHERE
                            mc.mission_id =
                            @mission
                          ORDER BY
                            mc.crew_id ASC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    adapter.SelectCommand
                        .Parameters.AddWithValue(
                            "@mission",
                            missionID);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dataGridViewMissionCrew
                        .DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load mission crew:\n" +
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
            if (!string.IsNullOrWhiteSpace(txtMissionID.Text))
            {
                MessageBox.Show("Use Update to change this record, or New to create another.");
                return;
            }

            if (!ValidateFields()) return;

            if (!DatesAreValid())
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
                        @"INSERT INTO mission
                          (
                            mission_type,
                            start_date,
                            end_date,
                            status,
                            asset_id
                          )
                          VALUES
                          (
                            @type,
                            @start,
                            @end,
                            @status,
                            @asset
                          )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@type",
                            ComboValue(
                                cmbMissionType));

                        cmd.Parameters.AddWithValue(
                            "@start",
                            dtpStartDate.Checked
                                ? (object)
                                    dtpStartDate
                                    .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@end",
                            dtpEndDate.Checked
                                ? (object)
                                    dtpEndDate
                                    .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(
                                cmbMissionStatus));

                        cmd.Parameters.AddWithValue(
                            "@asset",
                            cmbMissionAsset
                                .SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbMissionAsset
                                  .SelectedValue);

                        cmd.ExecuteNonQuery();

                        txtMissionID.Text =
                            cmd.LastInsertedId
                               .ToString();
                    }
                }

                cmbCrewMember.SelectedIndex = -1;
                txtRoleOnMission.Clear();
                dataGridViewMissionCrew.DataSource = null;
                LoadMissions();
                LoadMissionCrew(Convert.ToInt32(txtMissionID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save mission:\n" +
                    ex.Message);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateFields()) return;

            if (string.IsNullOrWhiteSpace(
                txtMissionID.Text))
            {
                MessageBox.Show(
                    "Select a mission first.");

                return;
            }

            if (!DatesAreValid())
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
                        @"UPDATE mission
                          SET mission_type = @type,
                              start_date = @start,
                              end_date = @end,
                              status = @status,
                              asset_id = @asset
                          WHERE mission_id = @id";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            Convert.ToInt32(
                                txtMissionID.Text));

                        cmd.Parameters.AddWithValue(
                            "@type",
                            ComboValue(
                                cmbMissionType));

                        cmd.Parameters.AddWithValue(
                            "@start",
                            dtpStartDate.Checked
                                ? (object)
                                    dtpStartDate
                                    .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@end",
                            dtpEndDate.Checked
                                ? (object)
                                    dtpEndDate
                                    .Value.Date
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            ComboValue(
                                cmbMissionStatus));

                        cmd.Parameters.AddWithValue(
                            "@asset",
                            cmbMissionAsset
                                .SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cmbMissionAsset
                                  .SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMissions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update mission:\n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtMissionID.Text, out id))
            {
                MessageBox.Show("Select a mission first.");
                return;
            }
            if (MessageBox.Show(
                "Delete this mission and all of its crew assignments?",
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
                            "DELETE FROM mission_crew WHERE mission_id = @id", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        using (var cmd = new MySqlCommand(
                            "DELETE FROM mission WHERE mission_id = @id", conn, transaction))
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
                LoadMissions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete mission:\n" + ex.Message);
            }
        }

        private void btnAssignCrew_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtMissionID.Text))
            {
                MessageBox.Show(
                    "Save or select a mission before assigning crew.");

                return;
            }

            if (cmbCrewMember.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Select a crew member.");

                return;
            }

            try
            {
                int missionID =
                    Convert.ToInt32(
                        txtMissionID.Text);

                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"INSERT INTO mission_crew
                          (
                            mission_id,
                            crew_id,
                            role_on_mission
                          )
                          VALUES
                          (
                            @mission,
                            @crew,
                            @role
                          )
                          ON DUPLICATE KEY UPDATE
                          role_on_mission =
                            VALUES(
                                role_on_mission
                            )";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@mission",
                            missionID);

                        cmd.Parameters.AddWithValue(
                            "@crew",
                            cmbCrewMember
                                .SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@role",
                            DbText(
                                txtRoleOnMission.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMissionCrew(missionID);

                txtRoleOnMission.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to assign crew:\n" +
                    ex.Message);
            }
        }

        private void btnRemoveCrew_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtMissionID.Text))
            {
                MessageBox.Show(
                    "Select a mission first.");

                return;
            }

            if (cmbCrewMember.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Select a crew member to remove.");

                return;
            }

            try
            {
                int missionID =
                    Convert.ToInt32(
                        txtMissionID.Text);

                using (MySqlConnection conn =
                       Database.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"DELETE FROM mission_crew
                          WHERE mission_id =
                                @mission
                          AND crew_id =
                                @crew";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@mission",
                            missionID);

                        cmd.Parameters.AddWithValue(
                            "@crew",
                            cmbCrewMember
                                .SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadMissionCrew(missionID);

                cmbCrewMember.SelectedIndex = -1;
                txtRoleOnMission.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to remove crew:\n" +
                    ex.Message);
            }
        }

        private void dataGridViewMissions_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewMissions
                    .Rows[e.RowIndex];

            txtMissionID.Text =
                row.Cells["mission_id"]
                   .Value?.ToString() ?? "";

            SetComboText(
                cmbMissionType,
                row.Cells["mission_type"]
                   .Value?.ToString());

            SetComboText(
                cmbMissionStatus,
                row.Cells["status"]
                   .Value?.ToString());

            if (row.Cells["asset_id"].Value ==
                DBNull.Value)
            {
                cmbMissionAsset.SelectedIndex = -1;
            }
            else
            {
                cmbMissionAsset.SelectedValue =
                    row.Cells["asset_id"].Value;
            }

            SetDatePicker(
                dtpStartDate,
                row.Cells["start_date"].Value);

            SetDatePicker(
                dtpEndDate,
                row.Cells["end_date"].Value);

            int missionID =
                Convert.ToInt32(
                    txtMissionID.Text);

            LoadMissionCrew(missionID);

            cmbCrewMember.SelectedIndex = -1;
            txtRoleOnMission.Clear();
        }

        private void dataGridViewMissionCrew_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dataGridViewMissionCrew
                    .Rows[e.RowIndex];

            if (row.Cells["crew_id"].Value !=
                DBNull.Value)
            {
                cmbCrewMember.SelectedValue =
                    row.Cells["crew_id"].Value;
            }

            txtRoleOnMission.Text =
                row.Cells["role_on_mission"]
                   .Value?.ToString() ?? "";
        }

        private bool DatesAreValid()
        {
            if (dtpStartDate.Checked &&
                dtpEndDate.Checked &&
                dtpEndDate.Value.Date <
                dtpStartDate.Value.Date)
            {
                MessageBox.Show(
                    "The end date cannot be before the start date.");

                return false;
            }

            return true;
        }

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            if (cmbMissionType.SelectedIndex < 0)
            {
                MessageBox.Show("Select a mission type.");
                return false;
            }
            if (cmbMissionStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Select a mission status.");
                return false;
            }
            if (cmbMissionAsset.SelectedIndex < 0)
            {
                MessageBox.Show("Select a asset.");
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
            txtMissionID.Clear();

            cmbMissionType.SelectedIndex = -1;
            cmbMissionStatus.SelectedIndex = -1;
            cmbMissionAsset.SelectedIndex = -1;

            dtpStartDate.Checked = false;
            dtpEndDate.Checked = false;

            cmbCrewMember.SelectedIndex = -1;
            txtRoleOnMission.Clear();

            dataGridViewMissionCrew.DataSource =
                null;
        }
    }
}
