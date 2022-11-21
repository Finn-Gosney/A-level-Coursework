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
    public partial class frmActions : Form
    {
        public frmActions()
        {
            InitializeComponent();
        }


        private void lstVActions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmActions_Load(object sender, EventArgs e)
        {
            DisplayData();

            List<Actions> ActionList = new List<Actions>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ActionID, Description, CostOfAction FROM tblActions ORDER BY ActionID";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                ActionList.Add(new Actions { actionID = Convert.ToInt32(dr[0]), actionDescription = dr[1].ToString() });
            }
            cmbActions.DisplayMember = "actionDescription";
            cmbActions.ValueMember = "actionID";
            cmbActions.DataSource = ActionList;
            dbConnector.Close();

        }

        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT ActionID, Description, CostOfAction FROM tblActions";


            dr = dbConnector.DoSQL(sqlStr);
            lstVActions.Items.Clear();
            while (dr.Read())
            {
                lstVActions.Items.Add(dr[0].ToString());
                lstVActions.Items[lstVActions.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVActions.Items[lstVActions.Items.Count - 1].SubItems.Add(dr[2].ToString());
            }
            dbConnector.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblActions  (Description, CostOfAction) " +
                $"VALUES ('{txtDescription.Text}' , '{txtPrice.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmActions"] as frmActions).DisplayData();

            frmActions_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this action?", "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblActions " +
                                    $"WHERE (ActionID = {cmbActions.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmActions"] as frmActions).DisplayData();
                frmActions_Load(sender, e);




            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
