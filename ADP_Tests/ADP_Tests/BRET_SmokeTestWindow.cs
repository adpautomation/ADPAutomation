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
    public partial class BRET_SmokeTestWindow : Form
    {
        public static string bret_id;
        public static string username;
        public static string password;
        public static int env_index;
        public static string env;
        public BRET_SmokeTestWindow()
        {
            InitializeComponent();
        }

        private void BRET_ID_TextChanged(object sender, EventArgs e)
        {
            bret_id = this.BRET_ID.Text;
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
            username = this.username_field.Text;
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

        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {
            password = this.password_field.Text;
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
            env_index = this.env_dropDown.SelectedIndex;
            if (env_dropDown.SelectedIndex == 0)
            {
                env = "http://bsg-mobile-dev/dist/#/lobby";
            }
            else if (env_dropDown.SelectedIndex == 1)
            {
                env = "http://bsg-mobile-staging/dist/#/lobby";
            }
        }
    }
}
