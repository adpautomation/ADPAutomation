namespace ADP_Tests
{
     partial class WFN_SubmissionWindow
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
            this.username_field = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.env_dropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTest = new System.Windows.Forms.Button();
            this.BRET_ID = new System.Windows.Forms.TextBox();
            this.BRET_ID_text = new System.Windows.Forms.Label();
            this.wfnUsername = new System.Windows.Forms.TextBox();
            this.wfnPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(15, 48);
            this.username_field.MaxLength = 20;
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(213, 22);
            this.username_field.TabIndex = 2;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Location = new System.Drawing.Point(12, 28);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(224, 17);
            this.username_text.TabIndex = 6;
            this.username_text.Text = "LOGIN. Please provide username ";
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(12, 96);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(217, 17);
            this.password_text.TabIndex = 7;
            this.password_text.Text = "LOGIN. Please provide password";
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(12, 116);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(213, 22);
            this.password_field.TabIndex = 8;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // env_dropDown
            // 
            this.env_dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.env_dropDown.FormattingEnabled = true;
            this.env_dropDown.Location = new System.Drawing.Point(139, 268);
            this.env_dropDown.MaxDropDownItems = 2;
            this.env_dropDown.Name = "env_dropDown";
            this.env_dropDown.Size = new System.Drawing.Size(187, 24);
            this.env_dropDown.TabIndex = 9;
            this.env_dropDown.SelectedIndexChanged += new System.EventHandler(this.env_dropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please choose the environment";
            // 
            // StartTest
            // 
            this.StartTest.BackColor = System.Drawing.SystemColors.Info;
            this.StartTest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartTest.Location = new System.Drawing.Point(343, 268);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(141, 61);
            this.StartTest.TabIndex = 11;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // BRET_ID
            // 
            this.BRET_ID.Location = new System.Drawing.Point(12, 179);
            this.BRET_ID.MaxLength = 6;
            this.BRET_ID.Name = "BRET_ID";
            this.BRET_ID.Size = new System.Drawing.Size(207, 22);
            this.BRET_ID.TabIndex = 12;
            this.BRET_ID.TextChanged += new System.EventHandler(this.BRET_ID_TextChanged);
            // 
            // BRET_ID_text
            // 
            this.BRET_ID_text.AutoSize = true;
            this.BRET_ID_text.Location = new System.Drawing.Point(12, 159);
            this.BRET_ID_text.Name = "BRET_ID_text";
            this.BRET_ID_text.Size = new System.Drawing.Size(193, 17);
            this.BRET_ID_text.TabIndex = 13;
            this.BRET_ID_text.Text = "Please provide valid BRET ID";
            // 
            // wfnUsername
            // 
            this.wfnUsername.Location = new System.Drawing.Point(272, 48);
            this.wfnUsername.Name = "wfnUsername";
            this.wfnUsername.Size = new System.Drawing.Size(213, 22);
            this.wfnUsername.TabIndex = 14;
            this.wfnUsername.TextChanged += new System.EventHandler(this.wfnUsername_TextChanged);
            // 
            // wfnPassword
            // 
            this.wfnPassword.Location = new System.Drawing.Point(272, 116);
            this.wfnPassword.Name = "wfnPassword";
            this.wfnPassword.Size = new System.Drawing.Size(213, 22);
            this.wfnPassword.TabIndex = 15;
            this.wfnPassword.TextChanged += new System.EventHandler(this.wfnPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "WFN. Please provide username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "WFN. Please provide password";
            // 
            // WFN_SubmissionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wfnPassword);
            this.Controls.Add(this.wfnUsername);
            this.Controls.Add(this.BRET_ID_text);
            this.Controls.Add(this.BRET_ID);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.env_dropDown);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.username_field);
            this.Name = "WFN_SubmissionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFN_SubmissionWindow";
            this.Load += new System.EventHandler(this.WFN_SubmissionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.ComboBox env_dropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.TextBox BRET_ID;
        private System.Windows.Forms.Label BRET_ID_text;
        private System.Windows.Forms.TextBox wfnUsername;
        private System.Windows.Forms.TextBox wfnPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}