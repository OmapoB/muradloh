namespace SabiBeautyStudio.forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            Hide();
        }
    }
}
