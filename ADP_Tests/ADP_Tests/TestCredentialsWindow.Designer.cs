namespace ADP_Tests
{
    partial class TestCredentialsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCredentialsWindow));
            this.BRET_ID = new System.Windows.Forms.TextBox();
            this.BRET_ID_text = new System.Windows.Forms.Label();
            this.StartTest = new System.Windows.Forms.Button();
            this.password_field = new System.Windows.Forms.TextBox();
            this.username_field = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.env_dropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.Impersonate_listOfUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FEIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MEP_companycode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wfnUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wfnPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // BRET_ID
            // 
            this.BRET_ID.Location = new System.Drawing.Point(12, 215);
            this.BRET_ID.MaxLength = 6;
            this.BRET_ID.Name = "BRET_ID";
            this.BRET_ID.Size = new System.Drawing.Size(235, 22);
            this.BRET_ID.TabIndex = 5;
            this.BRET_ID.TextChanged += new System.EventHandler(this.BRET_ID_TextChanged);
            // 
            // BRET_ID_text
            // 
            this.BRET_ID_text.AutoSize = true;
            this.BRET_ID_text.Location = new System.Drawing.Point(95, 195);
            this.BRET_ID_text.Name = "BRET_ID_text";
            this.BRET_ID_text.Size = new System.Drawing.Size(152, 17);
            this.BRET_ID_text.TabIndex = 1;
            this.BRET_ID_text.Text = "Please provide valid ID";
            this.BRET_ID_text.Click += new System.EventHandler(this.BRET_ID_text_Click);
            // 
            // StartTest
            // 
            this.StartTest.BackColor = System.Drawing.SystemColors.Info;
            this.StartTest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartTest.Location = new System.Drawing.Point(786, 279);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(141, 80);
            this.StartTest.TabIndex = 7;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(12, 105);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(235, 22);
            this.password_field.TabIndex = 2;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(12, 48);
            this.username_field.MaxLength = 20;
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(235, 22);
            this.username_field.TabIndex = 1;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username_text.Location = new System.Drawing.Point(74, 26);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(173, 17);
            this.username_text.TabIndex = 5;
            this.username_text.Text = "Please provide username ";
            this.username_text.Click += new System.EventHandler(this.username_text_Click);
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(81, 85);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(166, 17);
            this.password_text.TabIndex = 6;
            this.password_text.Text = "Please provide password";
            this.password_text.Click += new System.EventHandler(this.password_text_Click);
            // 
            // env_dropDown
            // 
            this.env_dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.env_dropDown.FormattingEnabled = true;
            this.env_dropDown.Location = new System.Drawing.Point(516, 335);
            this.env_dropDown.MaxDropDownItems = 3;
            this.env_dropDown.Name = "env_dropDown";
            this.env_dropDown.Size = new System.Drawing.Size(249, 24);
            this.env_dropDown.TabIndex = 6;
            this.env_dropDown.SelectedIndexChanged += new System.EventHandler(this.env_dropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please choose the environment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // Impersonate_listOfUsers
            // 
            this.Impersonate_listOfUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Impersonate_listOfUsers.FormattingEnabled = true;
            this.Impersonate_listOfUsers.Location = new System.Drawing.Point(516, 279);
            this.Impersonate_listOfUsers.Name = "Impersonate_listOfUsers";
            this.Impersonate_listOfUsers.Size = new System.Drawing.Size(249, 24);
            this.Impersonate_listOfUsers.TabIndex = 3;
            this.Impersonate_listOfUsers.SelectedIndexChanged += new System.EventHandler(this.Impersonate_listOfUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please choose user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // employeeID
            // 
            this.employeeID.Location = new System.Drawing.Point(12, 160);
            this.employeeID.MaxLength = 8;
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(235, 22);
            this.employeeID.TabIndex = 4;
            this.employeeID.TextChanged += new System.EventHandler(this.employeeID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Please provide valid EmpID";
            // 
            // companyCode
            // 
            this.companyCode.Location = new System.Drawing.Point(299, 47);
            this.companyCode.MaxLength = 3;
            this.companyCode.Name = "companyCode";
            this.companyCode.Size = new System.Drawing.Size(235, 22);
            this.companyCode.TabIndex = 14;
            this.companyCode.TextChanged += new System.EventHandler(this.companyCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Please provide testable CC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FEIN
            // 
            this.FEIN.Location = new System.Drawing.Point(299, 105);
            this.FEIN.MaxLength = 9;
            this.FEIN.Name = "FEIN";
            this.FEIN.Size = new System.Drawing.Size(235, 22);
            this.FEIN.TabIndex = 16;
            this.FEIN.TextChanged += new System.EventHandler(this.FEIN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Please provide testable FEIN";
            // 
            // MEP_companycode
            // 
            this.MEP_companycode.Location = new System.Drawing.Point(12, 270);
            this.MEP_companycode.MaxLength = 3;
            this.MEP_companycode.Name = "MEP_companycode";
            this.MEP_companycode.Size = new System.Drawing.Size(235, 22);
            this.MEP_companycode.TabIndex = 18;
            this.MEP_companycode.TextChanged += new System.EventHandler(this.MEP_companycode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Please provide testable CC";
            // 
            // wfnUsername
            // 
            this.wfnUsername.Location = new System.Drawing.Point(299, 160);
            this.wfnUsername.Name = "wfnUsername";
            this.wfnUsername.Size = new System.Drawing.Size(235, 22);
            this.wfnUsername.TabIndex = 20;
            this.wfnUsername.TextChanged += new System.EventHandler(this.wfnUsername_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Please provide username";
            // 
            // wfnPassword
            // 
            this.wfnPassword.Location = new System.Drawing.Point(299, 215);
            this.wfnPassword.Name = "wfnPassword";
            this.wfnPassword.Size = new System.Drawing.Size(235, 22);
            this.wfnPassword.TabIndex = 22;
            this.wfnPassword.TextChanged += new System.EventHandler(this.wfnPassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Please provide password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "LOGIN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "LOGIN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "VOE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "BRET:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "MEP:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "BOB:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "ACA:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(298, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "WFN:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(298, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "WFN:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(513, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "IMPERSONATE:";
            // 
            // TestCredentialsWindow
            // 
            this.AcceptButton = this.StartTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 371);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wfnPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wfnUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MEP_companycode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FEIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companyCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Impersonate_listOfUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.env_dropDown);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.username_field);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.BRET_ID_text);
            this.Controls.Add(this.BRET_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestCredentialsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Credentials";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SmokeTestWindow_Load);
            this.Load += new System.EventHandler(this.SmokeTestWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BRET_ID;
        private System.Windows.Forms.Label BRET_ID_text;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.ComboBox env_dropDown;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider errorMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Impersonate_listOfUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FEIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MEP_companycode;
        private System.Windows.Forms.TextBox wfnUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wfnPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}