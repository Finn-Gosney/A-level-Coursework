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
    public partial class frmClients : Form
    {

        public frmClients()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT clientID, firstName, surName, contactDetails, Address FROM tblClient";


            dr = dbConnector.DoSQL(sqlStr);
            lstVClients.Items.Clear();
            while (dr.Read())
            {
                lstVClients.Items.Add(dr[0].ToString());
                //lstVClients.Items[lstVClients.Items.Count - 1].SubItems.Add(dr[0].ToString());
                lstVClients.Items[lstVClients.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVClients.Items[lstVClients.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVClients.Items[lstVClients.Items.Count - 1].SubItems.Add(dr[3].ToString());
                lstVClients.Items[lstVClients.Items.Count - 1].SubItems.Add(dr[4].ToString());
            } 
            dbConnector.Close();


        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            DisplayData();

           List<Clients> ClientList = new List<Clients>();
           clsDBConnector dbConnector = new clsDBConnector();
           OleDbDataReader dr;
           string sqlStr;
           dbConnector.Connect();
           sqlStr = "SELECT clientID, (surName & " + "', '" + "& firstName) as ClientName From tblClient ORDER BY ClientID";
           dr = dbConnector.DoSQL(sqlStr);
           while (dr.Read())
           {
               ClientList.Add(new Clients { ClientID = Convert.ToInt32(dr[0]), ClientName = dr[1].ToString() });
           }
           cmbClients.DisplayMember = "ClientName";
           cmbClients.ValueMember = "ClientID";
           cmbClients.DataSource = ClientList;
           dbConnector.Close();
             
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ContactDetails = txtContactDetails.Text;
            string TestString = @"^(.+@.+|^(?:0|\+?44)(?:\d\s?){9,10}$)$";
            Match Validation = Regex.Match(ContactDetails, TestString);
            if (Validation.Success)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = $"INSERT INTO tblClient  (firstName,surName, contactDetails, Address) " +
                    $"VALUES ('{txtFirstName.Text}' , '{txtSurName.Text}', '{txtContactDetails.Text}', '{txtAddress.Text}')";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmClients"] as frmClients).DisplayData();

                frmClients_Load(sender, e);
            }    
            else
            {
                MessageBox.Show("Invalid Details");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblClient " +
                                    $"WHERE (ClientID = {cmbClients.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmClients"] as frmClients).DisplayData();
                frmClients_Load(sender, e);


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ContactDetails = txtContactDetails.Text;
            string TestString = @"^(.+@.+|^(?:0|\+?44)(?:\d\s?){9,10}$)$";
            Match Validation = Regex.Match(ContactDetails, TestString);
            if (Validation.Success)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE tblClient " +
                                $"SET firstName = '{txtFirstName.Text}'," +
                                $"surName = '{txtSurName.Text}'," +
                                $"contactDetails = '{txtContactDetails.Text}'," +
                                $"Address = '{txtAddress.Text}'" +
                                $"WHERE (ClientID = {cmbClients.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmClients"] as frmClients).DisplayData();
                frmClients_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }
        } 
    }
}
