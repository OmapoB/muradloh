using SabiBeautyStudio.DTO;
using SabiBeautyStudio.repositories;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace SabiBeautyStudio.forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Equals("ИМЯ"))
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length == 0)
            {
                TextBoxName.Text = "ИМЯ";
                TextBoxName.ForeColor = Color.LightGray;
            }
        }

        private void TextBoxLastName_Enter(object sender, EventArgs e)
        {
            if (TextBoxLastName.Text.Equals("ФАМИЛИЯ"))
            {
                TextBoxLastName.Text = "";
                TextBoxLastName.ForeColor = Color.Black;
            }
        }

        private void TextBoxSurname_Leave(object sender, EventArgs e)
        {
            if (TextBoxLastName.Text.Length == 0)
            {
                TextBoxLastName.Text = "ФАМИЛИЯ";
                TextBoxLastName.ForeColor = Color.LightGray;
            }
        }

        private void TextBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (TextBoxPhoneNumber.Text.Equals("НОМЕР ТЕЛЕФОНА"))
            {
                TextBoxPhoneNumber.Text = "";
                TextBoxPhoneNumber.ForeColor = Color.Black;
            }
        }

        private void TextBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (TextBoxPhoneNumber.Text.Length == 0)
            {
                TextBoxPhoneNumber.Text = "НОМЕР ТЕЛЕФОНА";
                TextBoxPhoneNumber.ForeColor = Color.LightGray;
            }
        }

        private void TextBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[A-z]|[А-яёЁ]+"))
            {
                e.KeyChar = '\0';
            }
        }

        private void TextBoxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(TextBoxPhoneNumber.Text, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
            {
                BtnReg.Enabled = true;
            }
        }

        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text.Equals("ЛОГИН"))
            {
                TextBoxLogin.Text = "";
                TextBoxLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text.Length == 0)
            {
                TextBoxLogin.Text = "ЛОГИН";
                TextBoxLogin.ForeColor = Color.LightGray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.Equals("ПАРОЛЬ"))
            {
                TextBoxPassword.PasswordChar = '*';
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
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

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (client.Checked)
            {
                int curRoot = RootRepo.getLastId("root");
                ClientDTO newClient = new()
                {
                    firstName = TextBoxName.Text,
                    lastName = TextBoxLastName.Text,
                    phoneNumber = TextBoxPhoneNumber.Text,
                    rootId = curRoot,
                    root = new()
                    {
                        id = curRoot,
                        login = TextBoxLogin.Text,
                        password = TextBoxPassword.Text,
                        role = Role.Client
                    }
                };
                try
                {
                    ClientRepo.create(newClient);
                }
                catch
                {
                    TextBoxLogin.Text = "Логин занят";
                    return;
                }

                Form form = new ClientForm(newClient);
                form.Show();
                Hide();
            }
            if (master.Checked)
            {
                int curRoot = RootRepo.getLastId("root");
                MasterDTO newMaster = new()
                {
                    firstName = TextBoxName.Text,
                    lastName = TextBoxLastName.Text,
                    phoneNumber = TextBoxPhoneNumber.Text,
                    rootId = curRoot,
                    root = new()
                    {
                        id = curRoot,
                        login = TextBoxLogin.Text,
                        password = TextBoxPassword.Text,
                        role = Role.Master
                    }
                };
                try
                {
                    MasterRepo.create(newMaster);
                }
                catch
                {
                    TextBoxLogin.Text = "Логин занят";
                    return;
                }
                Form form = new MasterForm(newMaster);
                form.Show();
                Hide();
            }
        }
    }
}
