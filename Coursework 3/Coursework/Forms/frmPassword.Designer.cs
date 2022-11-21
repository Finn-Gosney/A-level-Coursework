namespace Coursework
{
    partial class frmPassword
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
            this.lstVPassword = new System.Windows.Forms.ListView();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstVPassword
            // 
            this.lstVPassword.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Password});
            this.lstVPassword.HideSelection = false;
            this.lstVPassword.Location = new System.Drawing.Point(178, 46);
            this.lstVPassword.Name = "lstVPassword";
            this.lstVPassword.Size = new System.Drawing.Size(215, 58);
            this.lstVPassword.TabIndex = 0;
            this.lstVPassword.UseCompatibleStateImageBehavior = false;
            this.lstVPassword.View = System.Windows.Forms.View.Details;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(178, 133);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(109, 33);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Update Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(293, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 206;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lstVPassword);
            this.Name = "frmPassword";
            this.Text = "frmPassword";
            this.Load += new System.EventHandler(this.frmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.TextBox txtPassword;
    }
}