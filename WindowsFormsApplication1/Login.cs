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

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        
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
            this.Hide();
            Album albumDashboardView = new Album();
            albumDashboardView.Closed += (s, args) => this.Close();
            albumDashboardView.Show();
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
            string userPassword = signupPassword.Text;
            string userEmail = signupEmail.Text;

            //if inputs are not null
            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(userUsername) && !String.IsNullOrEmpty(userPassword) && !String.IsNullOrEmpty(userEmail))
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
                        new XElement("Password", userPassword)
                        );
                    newUser.Add(new XAttribute("UserId", userId));
                    newUser.Add(new XAttribute("Username", userUsername));

                    xmlDoc.Element("Users").Add(newUser);
                    xmlDoc.Save("Users.xml");
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
    }
}
