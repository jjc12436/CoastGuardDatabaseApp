using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class DashboardForm : Form
    {
        private bool loadingStats;
        public DashboardForm()
        {
            InitializeComponent();


            this.Load -= DashboardForm_Load;
            this.Load += DashboardForm_Load;

            this.Activated -= DashboardForm_Activated;
            this.Activated += DashboardForm_Activated;

            btnStations.Click -= btnStations_Click;
            btnStations.Click += btnStations_Click;

            btnAssets.Click -= btnAssets_Click;
            btnAssets.Click += btnAssets_Click;

            btnCrew.Click -= btnCrew_Click;
            btnCrew.Click += btnCrew_Click;

            btnMissions.Click -= btnMissions_Click;
            btnMissions.Click += btnMissions_Click;

            btnMaintenance.Click -= btnMaintenance_Click;
            btnMaintenance.Click += btnMaintenance_Click;

            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Activated handles the initial refresh and return from a child page.
        }

        private void DashboardForm_Activated(
            object sender,
            EventArgs e)
        {
            LoadDashboardStats();
        }

        private void btnStations_Click(
            object sender,
            EventArgs e)
        {
            OpenPage(new StationForm());
        }

        private void btnAssets_Click(
            object sender,
            EventArgs e)
        {
            OpenPage(new AssetForm());
        }

        private void btnCrew_Click(
            object sender,
            EventArgs e)
        {
            OpenPage(new CrewForm());
        }

        private void btnMissions_Click(
            object sender,
            EventArgs e)
        {
            OpenPage(new MissionForm());
        }

        private void btnMaintenance_Click(
            object sender,
            EventArgs e)
        {
            OpenPage(new MaintenanceForm());
        }

        private void OpenPage(Form page)
        {
            this.Hide();

            using (page)
            {
                page.ShowDialog();
            }

            this.Show();
        }

        private void LoadDashboardStats()
        {
            if (loadingStats) return;
            loadingStats = true;
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    const string query = @"
                        SELECT
                            (SELECT COUNT(*) FROM asset) AS total_assets,
                            (SELECT COUNT(*) FROM asset WHERE status = 'Available') AS available_assets,
                            (SELECT COUNT(*) FROM mission WHERE status = 'Active') AS active_missions,
                            (SELECT COUNT(DISTINCT asset_id)
                             FROM maintenance_record
                             WHERE next_due_date <= CURDATE()
                               AND maintenance_status IN ('Scheduled', 'In Progress', 'Overdue'))
                                AS maintenance_due";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new InvalidOperationException("No dashboard result was returned.");
                        lblTotalAssetsValue.Text = reader["total_assets"].ToString();
                        lblAvailableAssetsValue.Text = reader["available_assets"].ToString();
                        lblActiveMissionsValue.Text = reader["active_missions"].ToString();
                        lblMaintenanceDueValue.Text = reader["maintenance_due"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblTotalAssetsValue.Text = "N/A";
                lblAvailableAssetsValue.Text = "N/A";
                lblActiveMissionsValue.Text = "N/A";
                lblMaintenanceDueValue.Text = "N/A";
                MessageBox.Show("Unable to load dashboard information:\n" + ex.Message);
            }
            finally
            {
                loadingStats = false;
            }
        }



        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void lblPageSubtitle_Click(
            object sender,
            EventArgs e)
        {
        }

        private void pnlTotalAssets_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}
