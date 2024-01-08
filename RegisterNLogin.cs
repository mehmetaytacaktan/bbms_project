using BMSAdminPanel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formProject
{
    public partial class RegisterNLogin : Form
    {
        public enum TypeLogin
        {
            User,
            Admin,
            Driver,
            Fail
        }

        public Profiles profiles = new Profiles();

        SelectTourDate MainMenu;
        Register2 RegisterMenu;
        bool login = true;

        public RegisterNLogin()
        {
            InitializeComponent();
            MainMenu = new SelectTourDate(this);
            RegisterMenu = new Register2(this);
            MainMenu.Hide();
            RegisterMenu.Hide();

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //trying to login
            if(login)
            {
                if (UserExists(textBox1.Text, textBox2.Text) == TypeLogin.User)
                {
                    //deploys main menu.
                    MainMenu.Show();
                    this.Hide();
                }
                else if (UserExists(textBox1.Text, textBox2.Text) == TypeLogin.Admin)
                {
                    //deploys admin menu.
                    AdminPanel AdminMenu = new AdminPanel();
                    AdminMenu.Show();
                    this.Hide();
                }
                else if (UserExists(textBox1.Text, textBox2.Text) == TypeLogin.Driver)
                {
                    //deploys driver menu.
                    Driver DriverMenu = new Driver();
                    DriverMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password are incorrect",
                        "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //trying to register
            else
            {
                //tried to register but username is in use
                if (UserExists(textBox1.Text))
                {
                    MessageBox.Show("Username is in use please try another username",
                        "Unavaliable username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //registered succesfully
                else
                {
                    OpenRegisterForm(textBox1.Text, textBox2.Text);
                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ChangeLoginOrRegister();
        }

        public void ChangeLoginOrRegister()
        {
            login = !login;

            //changes interface so that user knows that they are login'ing
            if (login)
            {
                BtnLogin.Text = "LOGIN";
                BtnLogin.Location = new Point(311, 338);
                BtnLogin.Size = new Size(169, 55);

                textBox2.PasswordChar = '*';

                label3.Location = new Point(335, 404);
                label3.Text = "Create account";
            }
            //changes interface so that user knows that they are register'ing
            else
            {
                BtnLogin.Text = "REGISTER";
                BtnLogin.Location = new Point(289, 338);
                BtnLogin.Size = new Size(216, 55);

                textBox2.PasswordChar = textBox1.PasswordChar;

                label3.Location = new Point(350, 405);
                label3.Text = "Click to login";
            }
        }

        //checks if user with that name exists
        bool UserExists(string username)//********************************DataBase
        {
            foreach (var profile in profiles.s)
            {
                if (profile.username == username)
                {
                    return true;
                }
            }
            return false;
        }

        //checks if user with that name and password exists
        TypeLogin UserExists(string username, string password)
        {
            foreach (var profile in profiles.s)
            {
                if (profile.username == username && profile.password == password)
                {
                    return (TypeLogin)(profile.type);
                }
            }
            //else
            {
                MessageBox.Show("Username or password are incorrect",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return TypeLogin.Fail;
            }
        }

        //creates user
        void OpenRegisterForm(string username, string password)//********************************DataBase
        {
            if(username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Username or password are empty",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Password has to be at least 8 character long",
                    "False information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RegisterMenu.username = username;
                RegisterMenu.password = password;

                RegisterMenu.Show();
                this.Hide();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}