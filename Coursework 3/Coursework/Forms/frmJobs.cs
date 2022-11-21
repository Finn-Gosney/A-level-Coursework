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
using System.Text.RegularExpressions;

namespace Coursework
{
    public partial class frmJobs : Form
    {


        public frmJobs()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            DisplayData();

            List<JobClients> ClientList = new List<JobClients>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT clientID, (surName & " + "', '" + "& firstName) as ClientName From tblClient ORDER BY ClientID";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                ClientList.Add(new JobClients { JobClientID = Convert.ToInt32(dr[0]), JobClientName = dr[1].ToString() });
            }
            cmbClientID.DisplayMember = "JobClientName";
            cmbClientID.ValueMember = "JobClientID";
            cmbClientID.DataSource = ClientList;
            dbConnector.Close();

            List<Jobs> JobsList = new List<Jobs>();
            string sqlStr2;
            dbConnector.Connect();
            sqlStr2 = "SELECT tblJob.jobID, (surName & " + "', '" + "& firstName) as ClientName FROM(tblJob INNER JOIN tblClient ON tblJob.ClientID = tblClient.clientID) ORDER BY tblJob.jobID";
            dr = dbConnector.DoSQL(sqlStr2);
            while (dr.Read())
            {
                JobsList.Add(new Jobs { JobID = Convert.ToInt32(dr[0]), ClientName = (dr[1].ToString()) });
            }
            cmbJobID.DisplayMember = "ClientName";
            cmbJobID.ValueMember = "JobID";
            cmbJobID.DataSource = JobsList;


            dbConnector.Close();
        }
        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblJob.jobID, tblJob.ClientID, tblJob.DateOfJob, tblJob.Price, tblJob.TypeOfChimney FROM(tblClient INNER JOIN tblJob ON tblClient.clientID = tblJob.ClientID)";


            dr = dbConnector.DoSQL(sqlStr);
            lstVJob.Items.Clear();
            while (dr.Read())
            {
                lstVJob.Items.Add(dr[0].ToString());
                lstVJob.Items[lstVJob.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVJob.Items[lstVJob.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVJob.Items[lstVJob.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstVJob.Items[lstVJob.Items.Count - 1].SubItems.Add(dr[4].ToString());
            }
            dbConnector.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ChimneyDetails = txtChimney.Text;
            string TestString = @"^(0|1)$";
            Match Validation = Regex.Match(ChimneyDetails, TestString);
            if (Validation.Success)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = $"INSERT INTO tblJob (ClientID, DateOfJob, Price, TypeOfChimney) " +
                    $"VALUES ('{cmbClientID.SelectedValue}' , '{dtpCurrentJob.Value.Date}', '{0}', '{txtChimney.Text}')";

                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmJobs"] as frmJobs).DisplayData();

                frmJobs_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Chimney has to be 0 or 1");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this job?", "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblJob " +
                                    $"WHERE (JobID = {cmbJobID.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmJobs"] as frmJobs).DisplayData();
                frmJobs_Load(sender, e);


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Chimney = txtChimney.Text;
            string TestString = @"^(0|1)$";
            Match Validation = Regex.Match(Chimney, TestString);
            if (Validation.Success)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE tblJob " +
                                $"SET clientID = '{cmbClientID.SelectedValue}'," +
                                $"DateOfJob = '{dtpCurrentJob.Value.Date}'," +
                                $"price = '{0}'," +
                                $"TypeOfChimney = '{txtChimney.Text}'" +
                                $"WHERE (JobID = {cmbJobID.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmJobs"] as frmJobs).DisplayData();
                frmJobs_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Chimney has to be 0 or 1");
            }
        }
    }
}
