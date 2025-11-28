namespace Hotel_BS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Hotel Booking System";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            var registerForm = new CustomerRegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("¡Registro exitoso! Ahora puedes iniciar sesión.", "Éxito");
            }
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            var loginForm = new CustomerLoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                new CustomerDashboard(loginForm.CustomerId).Show();
                this.Hide();
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            var adminLogin = new AdminLoginForm();
            if (adminLogin.ShowDialog() == DialogResult.OK)
            {
                new AdminDashboard().Show();
                this.Hide();
            }
        }
    }
}
