using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Coursework
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }
    
        private void frmPassword_Load(object sender, EventArgs e)
        {
            DisplayData();

        }

        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT PasswordText FROM tblPassword";


            dr = dbConnector.DoSQL(sqlStr);
            lstVPassword.Items.Clear();
            while (dr.Read())
            {
                lstVPassword.Items.Add(dr[0].ToString());
            }
            dbConnector.Close();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "UPDATE tblPassword " +
                            $"SET passwordText = '{txtPassword.Text}'" +
                            $"WHERE (PasswordID = {1})";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmPassword"] as frmPassword).DisplayData();
        }
    }
}
