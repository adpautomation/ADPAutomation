using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADP_Tests
{
    public partial class SmokeTestWindow : Form
    {
        public static string BretId;
        public static string Username;
        public static string Password;
        public static string ValidEmployeeId;
        public static int EnvIndex;
        public static string Env;
        public static int ImpersonatedUserIndex;
        public static string ImpersonatedUser;
        public static string ValidCompanyCode;
        public static string ValidFein;
        public SmokeTestWindow()
        {
            InitializeComponent();
        }

        private void BRET_ID_TextChanged(object sender, EventArgs e)
        {
            BretId = this.BRET_ID.Text;
            if (string.IsNullOrWhiteSpace(BRET_ID.Text))
            {
                errorMessage.SetError(BRET_ID, "Please provide valid BRET ID");
            }
            else
            {
                errorMessage.Dispose();
            }

        }

        private void username_field_TextChanged(object sender, EventArgs e)
        {
            Username = this.username_field.Text;
            if (string.IsNullOrWhiteSpace(username_field.Text))
            {
                errorMessage.SetError(username_field, "Please provide the username");
            }
            else
            {
                errorMessage.Dispose();
            }
        }

        private void username_text_Click(object sender, EventArgs e)
        {

        }

        public void SmokeTestWindow_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            env_dropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            env_dropDown.Items.Add("development");
            env_dropDown.Items.Add("staging");
            if (!Impersonate_listOfUsers.Items.Contains("Felipe Adams"))
            {
                Impersonate_listOfUsers.Items.Add("Felipe Adams");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Allen Lee"))
            {
                Impersonate_listOfUsers.Items.Add("Allen Lee");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Ross Herrera"))
            {
                Impersonate_listOfUsers.Items.Add("Ross Herrera");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Jesus Rodriguez"))
            {
                Impersonate_listOfUsers.Items.Add("Jesus Rodriguez");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Giovanni Perez"))
            {
                Impersonate_listOfUsers.Items.Add("Giovanni Perez");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Robert Lyn"))
            {
                Impersonate_listOfUsers.Items.Add("Robert Lyn");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Aznariy Ramazanov"))
            {
                Impersonate_listOfUsers.Items.Add("Aznariy Ramazanov");
            }
            if (!Impersonate_listOfUsers.Items.Contains("Michelle Supple"))
            {
                Impersonate_listOfUsers.Items.Add("Michelle Supple");
            }
        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {
            Password = this.password_field.Text;
            if (string.IsNullOrWhiteSpace(password_field.Text)){
                errorMessage.SetError(password_field, "Please provide the password");
            }
            else
            {
                errorMessage.Dispose();
            }
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            //  StartTest.Enabled = username_field.Text.Length >0 && password_field.Text.Length >0 && BRET_ID_text.Text.Length>0 && env_dropDown.SelectedIndex>=0;
            if ((username_field.Text.Length > 0) && (password_field.Text.Length > 0) && (BRET_ID_text.Text.Length > 0)){ 
                StartTest.Enabled = true;
            }
            this.Close();
        }

        private void env_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnvIndex = this.env_dropDown.SelectedIndex;
            if (env_dropDown.SelectedIndex == 0)
            {
                Env = "http://bsg-mobile-dev/dist/#/lobby";
            }
            else if (env_dropDown.SelectedIndex == 1)
            {
                Env = "http://bsg-mobile-staging/dist/#/lobby";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void password_text_Click(object sender, EventArgs e)
        {

        }

        private void BRET_ID_text_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Impersonate_listOfUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImpersonatedUserIndex = this.Impersonate_listOfUsers.SelectedIndex;
            if (Impersonate_listOfUsers.SelectedIndex == 0)
            {
                ImpersonatedUser = "Felipe Adams";
            }else if(Impersonate_listOfUsers.SelectedIndex == 1)
            {
                ImpersonatedUser = "Allen Lee";
            }else if(Impersonate_listOfUsers.SelectedIndex == 2)
            {
                ImpersonatedUser = "Ross Herrera";
            }else if(Impersonate_listOfUsers.SelectedIndex == 3)
            {
                ImpersonatedUser = "Jesus Rodriguez";
            }else if(Impersonate_listOfUsers.SelectedIndex == 4)
            {
                ImpersonatedUser = "Giovanni Perez";
            }else if(Impersonate_listOfUsers.SelectedIndex == 5)
            {
                ImpersonatedUser = "Robert Lyn";
            }else if(Impersonate_listOfUsers.SelectedIndex == 6)
            {
                ImpersonatedUser = "Aznariy Ramazanov";
            }else if(Impersonate_listOfUsers.SelectedIndex == 7)
            {
                ImpersonatedUser = "Michelle Supple";
            }
        }

        private void employeeID_TextChanged(object sender, EventArgs e)
        {
            ValidEmployeeId = this.employeeID.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void companyCode_TextChanged(object sender, EventArgs e)
        {
            ValidCompanyCode = this.companyCode.Text;
        }

        private void FEIN_TextChanged(object sender, EventArgs e)
        {
            ValidFein = this.FEIN.Text;
        }
    }
}
