namespace Coursework
{
    partial class frmJobActions
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
            this.lstVJobActions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpJobActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAction1 = new System.Windows.Forms.Button();
            this.btnAction2 = new System.Windows.Forms.Button();
            this.btnAction3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVJobActions
            // 
            this.lstVJobActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstVJobActions.HideSelection = false;
            this.lstVJobActions.Location = new System.Drawing.Point(12, 12);
            this.lstVJobActions.Name = "lstVJobActions";
            this.lstVJobActions.Size = new System.Drawing.Size(191, 414);
            this.lstVJobActions.TabIndex = 0;
            this.lstVJobActions.UseCompatibleStateImageBehavior = false;
            this.lstVJobActions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JobActionID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JobID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ActionID";
            // 
            // flpJobActions
            // 
            this.flpJobActions.Location = new System.Drawing.Point(209, 12);
            this.flpJobActions.Name = "flpJobActions";
            this.flpJobActions.Size = new System.Drawing.Size(579, 385);
            this.flpJobActions.TabIndex = 2;
            // 
            // btnAction1
            // 
            this.btnAction1.Location = new System.Drawing.Point(209, 403);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(190, 23);
            this.btnAction1.TabIndex = 3;
            this.btnAction1.Text = "Action1";
            this.btnAction1.UseVisualStyleBackColor = true;
            this.btnAction1.Click += new System.EventHandler(this.btnAction1_Click);
            // 
            // btnAction2
            // 
            this.btnAction2.Location = new System.Drawing.Point(405, 403);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(190, 23);
            this.btnAction2.TabIndex = 4;
            this.btnAction2.Text = "Action2";
            this.btnAction2.UseVisualStyleBackColor = true;
            this.btnAction2.Click += new System.EventHandler(this.btnAction2_Click);
            // 
            // btnAction3
            // 
            this.btnAction3.Location = new System.Drawing.Point(601, 403);
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Size = new System.Drawing.Size(187, 23);
            this.btnAction3.TabIndex = 5;
            this.btnAction3.Text = "Action3";
            this.btnAction3.UseVisualStyleBackColor = true;
            this.btnAction3.Click += new System.EventHandler(this.btnAction3_Click);
            // 
            // frmJobActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAction3);
            this.Controls.Add(this.btnAction2);
            this.Controls.Add(this.btnAction1);
            this.Controls.Add(this.flpJobActions);
            this.Controls.Add(this.lstVJobActions);
            this.Name = "frmJobActions";
            this.Text = "frmJobActions";
            this.Load += new System.EventHandler(this.frmJobActions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVJobActions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.FlowLayoutPanel flpJobActions;
        private System.Windows.Forms.Button btnAction1;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnAction3;
    }
}