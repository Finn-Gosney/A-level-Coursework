﻿namespace Coursework
{
    partial class frmGear
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
            this.lstVGear = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNameOfGear = new System.Windows.Forms.TextBox();
            this.cmbGearID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVGear
            // 
            this.lstVGear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstVGear.HideSelection = false;
            this.lstVGear.Location = new System.Drawing.Point(33, 12);
            this.lstVGear.Name = "lstVGear";
            this.lstVGear.Size = new System.Drawing.Size(446, 252);
            this.lstVGear.TabIndex = 0;
            this.lstVGear.UseCompatibleStateImageBehavior = false;
            this.lstVGear.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GearID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NameOfGear";
            this.columnHeader2.Width = 134;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNameOfGear
            // 
            this.txtNameOfGear.Location = new System.Drawing.Point(301, 270);
            this.txtNameOfGear.Name = "txtNameOfGear";
            this.txtNameOfGear.Size = new System.Drawing.Size(121, 20);
            this.txtNameOfGear.TabIndex = 5;
            // 
            // cmbGearID
            // 
            this.cmbGearID.FormattingEnabled = true;
            this.cmbGearID.Location = new System.Drawing.Point(301, 299);
            this.cmbGearID.Name = "cmbGearID";
            this.cmbGearID.Size = new System.Drawing.Size(121, 21);
            this.cmbGearID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name Of Gear";
            // 
            // frmGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGearID);
            this.Controls.Add(this.txtNameOfGear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstVGear);
            this.Name = "frmGear";
            this.Text = "frmGear";
            this.Load += new System.EventHandler(this.frmGear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVGear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNameOfGear;
        private System.Windows.Forms.ComboBox cmbGearID;
        private System.Windows.Forms.Label label1;
    }
}