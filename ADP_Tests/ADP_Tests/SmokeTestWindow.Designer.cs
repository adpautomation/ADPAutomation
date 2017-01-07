namespace ADP_Tests
{
    partial class SmokeTestWindow
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
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // BRET_ID
            // 
            this.BRET_ID.Location = new System.Drawing.Point(12, 299);
            this.BRET_ID.MaxLength = 6;
            this.BRET_ID.Name = "BRET_ID";
            this.BRET_ID.Size = new System.Drawing.Size(190, 22);
            this.BRET_ID.TabIndex = 5;
            this.BRET_ID.TextChanged += new System.EventHandler(this.BRET_ID_TextChanged);
            // 
            // BRET_ID_text
            // 
            this.BRET_ID_text.AutoSize = true;
            this.BRET_ID_text.Location = new System.Drawing.Point(9, 279);
            this.BRET_ID_text.Name = "BRET_ID_text";
            this.BRET_ID_text.Size = new System.Drawing.Size(193, 17);
            this.BRET_ID_text.TabIndex = 1;
            this.BRET_ID_text.Text = "Please provide valid BRET ID";
            this.BRET_ID_text.Click += new System.EventHandler(this.BRET_ID_text_Click);
            // 
            // StartTest
            // 
            this.StartTest.BackColor = System.Drawing.SystemColors.Info;
            this.StartTest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartTest.Location = new System.Drawing.Point(753, 260);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(141, 61);
            this.StartTest.TabIndex = 7;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(12, 105);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(213, 22);
            this.password_field.TabIndex = 2;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(12, 48);
            this.username_field.MaxLength = 20;
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(213, 22);
            this.username_field.TabIndex = 1;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Location = new System.Drawing.Point(12, 28);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(224, 17);
            this.username_text.TabIndex = 5;
            this.username_text.Text = "LOGIN. Please provide username ";
            this.username_text.Click += new System.EventHandler(this.username_text_Click);
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(12, 85);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(217, 17);
            this.password_text.TabIndex = 6;
            this.password_text.Text = "LOGIN. Please provide password";
            this.password_text.Click += new System.EventHandler(this.password_text_Click);
            // 
            // env_dropDown
            // 
            this.env_dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.env_dropDown.FormattingEnabled = true;
            this.env_dropDown.Location = new System.Drawing.Point(547, 260);
            this.env_dropDown.MaxDropDownItems = 2;
            this.env_dropDown.Name = "env_dropDown";
            this.env_dropDown.Size = new System.Drawing.Size(187, 24);
            this.env_dropDown.TabIndex = 6;
            this.env_dropDown.SelectedIndexChanged += new System.EventHandler(this.env_dropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 240);
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
            this.Impersonate_listOfUsers.Location = new System.Drawing.Point(15, 159);
            this.Impersonate_listOfUsers.Name = "Impersonate_listOfUsers";
            this.Impersonate_listOfUsers.Size = new System.Drawing.Size(210, 24);
            this.Impersonate_listOfUsers.TabIndex = 3;
            this.Impersonate_listOfUsers.SelectedIndexChanged += new System.EventHandler(this.Impersonate_listOfUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "IMPERSONATE. Please choose user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // employeeID
            // 
            this.employeeID.Location = new System.Drawing.Point(12, 220);
            this.employeeID.MaxLength = 8;
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(210, 22);
            this.employeeID.TabIndex = 4;
            this.employeeID.TextChanged += new System.EventHandler(this.employeeID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "VOE. Please provide valid EmpID";
            // 
            // companyCode
            // 
            this.companyCode.Location = new System.Drawing.Point(264, 47);
            this.companyCode.MaxLength = 3;
            this.companyCode.Name = "companyCode";
            this.companyCode.Size = new System.Drawing.Size(222, 22);
            this.companyCode.TabIndex = 14;
            this.companyCode.TextChanged += new System.EventHandler(this.companyCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "BOB. Please provide testable CC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FEIN
            // 
            this.FEIN.Location = new System.Drawing.Point(264, 105);
            this.FEIN.MaxLength = 9;
            this.FEIN.Name = "FEIN";
            this.FEIN.Size = new System.Drawing.Size(222, 22);
            this.FEIN.TabIndex = 16;
            this.FEIN.TextChanged += new System.EventHandler(this.FEIN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ACA. Please provide testable FEIN";
            // 
            // SmokeTestWindow
            // 
            this.AcceptButton = this.StartTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 333);
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
            this.Name = "SmokeTestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}