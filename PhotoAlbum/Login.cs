using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhotoAlbum
{
    public partial class Login : Form
    {
        //Hashing passwords using md5
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string userUsername = signinUsername.Text;
            string userPasswordEnteredHash = CreateMD5(signinPassword.Text);

            //if inputs are not null
            if (!String.IsNullOrEmpty(userUsername) && !String.IsNullOrEmpty(signinPassword.Text))
            {
                //Load XML to Write the account information using LINQ
                XDocument xmlDoc = XDocument.Load("Users.xml");
    
                //Get password hash from the xml document
                IEnumerable<XElement> userWithUsername =
                    from el in xmlDoc.Root.Elements("User")
                    where (string)el.Attribute("Username") == userUsername
                    select el;
                if (userWithUsername.Count() != 0)
                {
                    String userPasswordHash = userWithUsername.First().Element("PasswordHash").Value;

                    if (userPasswordHash == userPasswordEnteredHash)
                    {
                        //signinNotifyLabel.ForeColor = System.Drawing.Color.LawnGreen;
                        //signinNotifyLabel.Text = "Login Successful";
                        //signinNotifyLabel.Visible = true;

                        Album albumDashboardView = new Album();
                        albumDashboardView.Closed += (s, args) => this.Close();
                        albumDashboardView.Show();
                        this.Hide();
                    }
                    else
                    {
                        signinNotifyLabel.ForeColor = System.Drawing.Color.OrangeRed;
                        signinNotifyLabel.Text = "The username or password is incorrect.";
                        signinNotifyLabel.Visible = true;
                    }
                }
                else
                {
                    signinNotifyLabel.ForeColor = System.Drawing.Color.OrangeRed;
                    signinNotifyLabel.Text = "The username or password is incorrect.";
                    signinNotifyLabel.Visible = true;
                }
            }
            else //if inputs are null
            {
                signinNotifyLabel.ForeColor = System.Drawing.Color.OrangeRed;
                signinNotifyLabel.Text = "All the fields are required.";
                signinNotifyLabel.Visible = true;
            }
            
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            loginViewPanel.Visible = false;
            createAccountPanel.Visible = true;

        

        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            string userName = signupName.Text;
            string userUsername = signupUsername.Text;
            string userPasswordHash = CreateMD5(signupPassword.Text);
            string userEmail = signupEmail.Text;

            //if inputs are not null
            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(userUsername) && !String.IsNullOrEmpty(signupPassword.Text) && !String.IsNullOrEmpty(userEmail))
            {
                //Load XML to Write the account information using LINQ
                XDocument xmlDoc = XDocument.Load("Users.xml");

                //search the xml for same username, if found return error.
                IEnumerable<XElement> userWithSameUsername =
                from el in xmlDoc.Root.Elements("User")
                where (string)el.Attribute("Username") == userUsername
                select el;

                if (userWithSameUsername.Count() == 0)
                { //Create a new user

                    //get the last userId from the XML file
                    int userId = Int32.Parse(xmlDoc.Root.Elements("User").Last().Attribute("UserId").Value);

                    //Increment the last userId for the new user.
                    userId++;

                    XElement newUser = new XElement("User",
                        new XElement("Name", userName),
                        new XElement("Email", userEmail),
                        new XElement("PasswordHash", userPasswordHash)
                        );
                    newUser.Add(new XAttribute("UserId", userId));
                    newUser.Add(new XAttribute("Username", userUsername));

                    xmlDoc.Element("Users").Add(newUser);
                    xmlDoc.Save("Users.xml");
                    signupErrorLabel.ForeColor = System.Drawing.Color.LawnGreen;
                    signupErrorLabel.Text = "Congratulations, Registration Successful.";
                    signupErrorLabel.Visible = true;
                }
                else
                {
                    signupErrorLabel.Text = "Username already exists, please login.";
                    signupErrorLabel.Visible = true;
                }
            }
            else //if inputs are null
            {
                signupErrorLabel.Text = "All the fields are required.";
                signupErrorLabel.Visible = true;
            }


            

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loginViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupBackButton_Click(object sender, EventArgs e)
        {
            createAccountPanel.Visible = false;
            loginViewPanel.Visible = true;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signinPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton_Click(this, new EventArgs());
            }
        }
    }
}
