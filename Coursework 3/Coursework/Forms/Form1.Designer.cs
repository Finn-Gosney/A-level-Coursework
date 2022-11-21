namespace Coursework
{
    partial class Form1
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnGear = new System.Windows.Forms.Button();
            this.btnActions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnJobActions = new System.Windows.Forms.Button();
            this.btnJobGear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(44, 414);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(80, 24);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Visible = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(130, 415);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(75, 23);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Visible = false;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnGear
            // 
            this.btnGear.Location = new System.Drawing.Point(708, 12);
            this.btnGear.Name = "btnGear";
            this.btnGear.Size = new System.Drawing.Size(80, 23);
            this.btnGear.TabIndex = 3;
            this.btnGear.Text = "Gear";
            this.btnGear.UseVisualStyleBackColor = true;
            this.btnGear.Visible = false;
            this.btnGear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActions
            // 
            this.btnActions.Location = new System.Drawing.Point(708, 41);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(80, 23);
            this.btnActions.TabIndex = 4;
            this.btnActions.Text = "Actions";
            this.btnActions.UseVisualStyleBackColor = true;
            this.btnActions.Visible = false;
            this.btnActions.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(505, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shouldn\'t be important, just here to make sure you can add to these tables";
            this.label1.Visible = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(71, 17);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 20);
            this.txtPassWord.TabIndex = 6;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password ";
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(177, 15);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 8;
            this.btnPassword.Text = "Enter";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Black;
            this.lblWelcome.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(149, 152);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(516, 59);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome to your chimney sweeping database!";
            this.lblWelcome.Visible = false;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(15, 43);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(109, 23);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnJobActions
            // 
            this.btnJobActions.Location = new System.Drawing.Point(211, 415);
            this.btnJobActions.Name = "btnJobActions";
            this.btnJobActions.Size = new System.Drawing.Size(75, 23);
            this.btnJobActions.TabIndex = 11;
            this.btnJobActions.Text = "Job Actions";
            this.btnJobActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJobActions.UseVisualStyleBackColor = true;
            this.btnJobActions.Visible = false;
            this.btnJobActions.Click += new System.EventHandler(this.btnJobActions_Click);
            // 
            // btnJobGear
            // 
            this.btnJobGear.Location = new System.Drawing.Point(292, 415);
            this.btnJobGear.Name = "btnJobGear";
            this.btnJobGear.Size = new System.Drawing.Size(75, 23);
            this.btnJobGear.TabIndex = 12;
            this.btnJobGear.Text = "Job Gear";
            this.btnJobGear.UseVisualStyleBackColor = true;
            this.btnJobGear.Visible = false;
            this.btnJobGear.Click += new System.EventHandler(this.btnJobGear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJobGear);
            this.Controls.Add(this.btnJobActions);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActions);
            this.Controls.Add(this.btnGear);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnClient);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnGear;
        private System.Windows.Forms.Button btnActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnJobActions;
        private System.Windows.Forms.Button btnJobGear;
    }
}