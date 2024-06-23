using SabiBeautyStudio.DTO;
using SabiBeautyStudio.forms;
using SabiBeautyStudio.services;

namespace SabiBeautyStudio
{
    public partial class LoginForm : Form
    {

        private AuthService authService = new();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text.Length == 0)
            {
                TextBoxLogin.Text = "ЛОГИН";
                TextBoxLogin.ForeColor = Color.LightGray;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.Length == 0)
            {
                TextBoxPassword.PasswordChar = '\0';
                TextBoxPassword.Text = "ПАРОЛЬ";
                TextBoxPassword.ForeColor = Color.LightGray;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            object? user = authService.authenticate(TextBoxLogin.Text, TextBoxPassword.Text);
            if (user == null) { TextBoxLogin.Text = "Неверный логин или пароль"; }
            if (user == null)
            {
                TextBoxPassword.PasswordChar = '\0';
                TextBoxPassword.Text = "НЕВЕРНЫЙ ПАРОЛЬ";
            }
            if (user is ClientDTO client)
            {
                Form form = new ClientForm(client);
                form.Show();
                Hide();
            }
            if (user is MasterDTO master)
            {
                Form form = new MasterForm(master);
                form.Show();
                Hide();
            }
        }

        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text.Equals("ЛОГИН") || TextBoxLogin.Text.Equals("Неверный логин или пароль"))
            {
                TextBoxLogin.Text = "";
                TextBoxLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.Equals("ПАРОЛЬ") || TextBoxPassword.Text.Equals("НЕВЕРНЫЙ ПАРОЛЬ"))
            {
                TextBoxPassword.PasswordChar = '*';
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new();
            form.Show();
            Hide();
        }
    }
}
