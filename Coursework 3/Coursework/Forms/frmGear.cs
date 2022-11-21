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
    public partial class frmGear : Form
    {
        public frmGear()
        {
            InitializeComponent();
        }


        private void frmGear_Load(object sender, EventArgs e)
        {
            DisplayData();

            List<Gear> GearList = new List<Gear>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT GearID, NameOfGear FROM tblGear";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                GearList.Add(new Gear { GearID = Convert.ToInt32(dr[0]), GearName = dr[1].ToString() });
            }
            cmbGearID.DisplayMember = "GearName";
            cmbGearID.ValueMember = "GearID";
            cmbGearID.DataSource = GearList;
            dbConnector.Close();
        }
        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT GearID, NameOfGear FROM tblGear ORDER BY GearID";
            

            dr = dbConnector.DoSQL(sqlStr);
            lstVGear.Items.Clear();
            while (dr.Read())
            {
                lstVGear.Items.Add(dr[0].ToString());
                lstVGear.Items[lstVGear.Items.Count - 1].SubItems.Add(dr[1].ToString());
            }
            dbConnector.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblGear  (NameOfGear) " +
                $"VALUES ('{txtNameOfGear.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["frmGear"] as frmGear).DisplayData();

            frmGear_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this bit of equipment?", "Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "DELETE FROM tblGear " +
                                    $"WHERE (GearID = {cmbGearID.SelectedValue})";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                (Application.OpenForms["frmGear"] as frmGear).DisplayData();

                frmGear_Load(sender, e);



            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
