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
    public partial class WFN_SubmissionWindow : Form
    {
        public static string Username;
        public static string Password;
        public static string ValidWfnUsername;
        public static string ValidWfnPassword;
        public static string ValidBretId;
        public static int EnvIndex;
        public static string Env;
        public static string WfnEnv;


        public WFN_SubmissionWindow()
        {
            InitializeComponent();
        }

        private void WFN_SubmissionWindow_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            env_dropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            if (!env_dropDown.Items.Contains("development"))
            {
                env_dropDown.Items.Add("development");
            }
            if (!env_dropDown.Items.Contains("staging"))
            {
                env_dropDown.Items.Add("staging");
            }
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            if ((username_field.Text.Length > 0) && (password_field.Text.Length > 0) && (BRET_ID_text.Text.Length > 0) && (wfnUsername.Text.Length > 0) && (wfnPassword.Text.Length > 0))
            {
                StartTest.Enabled = true;
            }
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_field_TextChanged(object sender, EventArgs e)
        {
            Username = this.username_field.Text;
        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {
            Password = this.password_field.Text;
        }

        private void wfnUsername_TextChanged(object sender, EventArgs e)
        {
            ValidWfnUsername = wfnUsername.Text;
        }

        private void wfnPassword_TextChanged(object sender, EventArgs e)
        {
            ValidWfnPassword = wfnPassword.Text;
        }

        private void BRET_ID_TextChanged(object sender, EventArgs e)
        {
            ValidBretId = BRET_ID.Text;
        }

        private void env_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnvIndex = this.env_dropDown.SelectedIndex;
            if (env_dropDown.SelectedIndex == 0)
            {
                Env = "http://bsg-mobile-dev/dist/#/lobby";
                WfnEnv = "https://wfn-dit.nj.adp.com/public/index.htm";
            }
            else if (env_dropDown.SelectedIndex == 1)
            {
                Env = "http://bsg-mobile-staging/dist/#/lobby";
                WfnEnv = "https://wfn-fit.nj.adp.com/public/index.htm";
            }
        }
    }
 }
