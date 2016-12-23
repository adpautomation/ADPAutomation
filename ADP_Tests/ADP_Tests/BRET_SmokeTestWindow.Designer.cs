namespace ADP_Tests
{
    partial class BRET_SmokeTestWindow
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
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // BRET_ID
            // 
            this.BRET_ID.Location = new System.Drawing.Point(15, 178);
            this.BRET_ID.MaxLength = 6;
            this.BRET_ID.Name = "BRET_ID";
            this.BRET_ID.Size = new System.Drawing.Size(190, 22);
            this.BRET_ID.TabIndex = 2;
            this.BRET_ID.TextChanged += new System.EventHandler(this.BRET_ID_TextChanged);
            // 
            // BRET_ID_text
            // 
            this.BRET_ID_text.AutoSize = true;
            this.BRET_ID_text.Location = new System.Drawing.Point(12, 158);
            this.BRET_ID_text.Name = "BRET_ID_text";
            this.BRET_ID_text.Size = new System.Drawing.Size(193, 17);
            this.BRET_ID_text.TabIndex = 1;
            this.BRET_ID_text.Text = "Please provide valid BRET ID";
            // 
            // StartTest
            // 
            this.StartTest.BackColor = System.Drawing.SystemColors.Info;
            this.StartTest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartTest.Location = new System.Drawing.Point(261, 242);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(141, 61);
            this.StartTest.TabIndex = 4;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(12, 114);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(190, 22);
            this.password_field.TabIndex = 1;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // username_field
            // 
            this.username_field.Location = new System.Drawing.Point(12, 48);
            this.username_field.MaxLength = 20;
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(190, 22);
            this.username_field.TabIndex = 0;
            this.username_field.TextChanged += new System.EventHandler(this.username_field_TextChanged);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Location = new System.Drawing.Point(12, 28);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(197, 17);
            this.username_text.TabIndex = 5;
            this.username_text.Text = "Please provide the username ";
            this.username_text.Click += new System.EventHandler(this.username_text_Click);
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(12, 94);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(190, 17);
            this.password_text.TabIndex = 6;
            this.password_text.Text = "Please provide the password";
            // 
            // env_dropDown
            // 
            this.env_dropDown.FormattingEnabled = true;
            this.env_dropDown.Location = new System.Drawing.Point(15, 242);
            this.env_dropDown.MaxDropDownItems = 2;
            this.env_dropDown.Name = "env_dropDown";
            this.env_dropDown.Size = new System.Drawing.Size(187, 24);
            this.env_dropDown.TabIndex = 3;
            this.env_dropDown.SelectedIndexChanged += new System.EventHandler(this.env_dropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please choose the environment";
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // BRET_SmokeTestWindow
            // 
            this.AcceptButton = this.StartTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.env_dropDown);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.username_field);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.BRET_ID_text);
            this.Controls.Add(this.BRET_ID);
            this.Name = "BRET_SmokeTestWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRET Smoke Test Parameters";
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
    }
}