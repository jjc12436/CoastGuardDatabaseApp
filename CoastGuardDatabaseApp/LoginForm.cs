using System;
using System.Windows.Forms;

namespace CoastGuardDatabaseApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

            btnLogin.Click -= btnLogin_Click;
            btnLogin.Click += btnLogin_Click;

            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string expectedPassword =
                Environment.GetEnvironmentVariable(
                    "CG_APP_PASSWORD",
                    EnvironmentVariableTarget.User);

            if (string.IsNullOrEmpty(expectedPassword))
            {
                MessageBox.Show(
                    "CG_APP_PASSWORD is not set in Windows.");

                return;
            }

            if (txtUsername.Text.Trim() == "admin" &&
                txtPassword.Text == expectedPassword)
            {
                this.Hide();

                using (DashboardForm dashboard =
                       new DashboardForm())
                {
                    dashboard.ShowDialog();
                }


                this.Show();

                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }


        private void txtUsername_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtPassword_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}
