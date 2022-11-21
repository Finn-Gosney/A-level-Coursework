namespace Coursework
{
    partial class frmJobs
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
            this.lstVJob = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCurrentJob = new System.Windows.Forms.DateTimePicker();
            this.cmbClientID = new System.Windows.Forms.ComboBox();
            this.txtChimney = new System.Windows.Forms.TextBox();
            this.cmbJobID = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVJob
            // 
            this.lstVJob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVJob.HideSelection = false;
            this.lstVJob.Location = new System.Drawing.Point(15, -1);
            this.lstVJob.Name = "lstVJob";
            this.lstVJob.Size = new System.Drawing.Size(776, 217);
            this.lstVJob.TabIndex = 0;
            this.lstVJob.UseCompatibleStateImageBehavior = false;
            this.lstVJob.View = System.Windows.Forms.View.Details;
            this.lstVJob.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JobID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ClientID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DateOfScheduledJob";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TypeOfChimney";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NextSweepTime";
            this.columnHeader6.Width = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ClientID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DateOfScheduledJob";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TypeOfChimney";
            // 
            // dtpCurrentJob
            // 
            this.dtpCurrentJob.Location = new System.Drawing.Point(110, 256);
            this.dtpCurrentJob.Name = "dtpCurrentJob";
            this.dtpCurrentJob.Size = new System.Drawing.Size(200, 20);
            this.dtpCurrentJob.TabIndex = 4;
            // 
            // cmbClientID
            // 
            this.cmbClientID.FormattingEnabled = true;
            this.cmbClientID.Location = new System.Drawing.Point(110, 229);
            this.cmbClientID.Name = "cmbClientID";
            this.cmbClientID.Size = new System.Drawing.Size(121, 21);
            this.cmbClientID.TabIndex = 5;
            // 
            // txtChimney
            // 
            this.txtChimney.Location = new System.Drawing.Point(110, 283);
            this.txtChimney.Name = "txtChimney";
            this.txtChimney.Size = new System.Drawing.Size(100, 20);
            this.txtChimney.TabIndex = 6;
            // 
            // cmbJobID
            // 
            this.cmbJobID.FormattingEnabled = true;
            this.cmbJobID.Location = new System.Drawing.Point(428, 232);
            this.cmbJobID.Name = "cmbJobID";
            this.cmbJobID.Size = new System.Drawing.Size(121, 21);
            this.cmbJobID.TabIndex = 7;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(378, 232);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 13);
            this.Label.TabIndex = 8;
            this.Label.Text = "JobID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(19, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.cmbJobID);
            this.Controls.Add(this.txtChimney);
            this.Controls.Add(this.cmbClientID);
            this.Controls.Add(this.dtpCurrentJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVJob);
            this.Name = "frmJobs";
            this.Text = "frmJobs";
            this.Load += new System.EventHandler(this.frmJobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVJob;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCurrentJob;
        private System.Windows.Forms.ComboBox cmbClientID;
        private System.Windows.Forms.TextBox txtChimney;
        private System.Windows.Forms.ComboBox cmbJobID;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}