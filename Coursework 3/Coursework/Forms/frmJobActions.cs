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
    public partial class frmJobActions : Form
    {


        public frmJobActions()
        {
            InitializeComponent();
        }

        private void frmJobActions_Load(object sender, EventArgs e)
        {
            //The job will already be scheduled in frmJob - this code should allow the user to add actions to that job
            //idealy through the use of something like a flow control - each button is a jobid and when clicked it opens something to add different actions

            int i = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblJob.jobID, (firstName & " + " " +  "surName) as ClientName FROM(tblJob INNER JOIN tblClient ON tblJob.ClientID = tblClient.clientID)";


               // "SELECT studentID, (firstName & " + " " + "surName) as studentName FROM tblStudent";

            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Button btn = new Button();
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(50, 45);
                btn.Visible = true;
                btn.Tag = dr[0].ToString();
                btn.Text = dr[1].ToString();
                btn.Name = "btn_ " + i;
                i++;
                btn.Click +=Btn_Click;
                flpJobActions.Controls.Add(btn);


            }
            dbConnector.Close();



        }

        private void Btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show((sender as Button).Tag.ToString());
            int jobID = Convert.ToInt32((sender as Button).Tag);

            clsDBConnector dbConnector = new clsDBConnector();

            int ClientID = 0;
            int Price = 0;
            int Chimney = 0;
            DateTime Date = DateTime.Today;

            OleDbDataReader dr;
            dbConnector.Connect();
            string sql = "SELECT DateOfJob, ClientID, Price, TypeOfChimney FROM tblJob";
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {
                Date = Convert.ToDateTime(dr[0]);


                //if (dr[1] is DateTime)    //this code is the problem
                //{
                //    Date = (DateTime)dr[1];
                //}
                //else
                //{
                //    MessageBox.Show("You Suck");
                //    break;
                //}
                ClientID = Convert.ToInt32(dr[1]);
                Price = Convert.ToInt32(dr[2]);
                Chimney = Convert.ToInt32(dr[3]);
            }
            dbConnector.Close();

            clsDBConnector dBConnector = new clsDBConnector();

            string cmdStr = "UPDATE tblJob " +
                            $"SET clientID = '{ClientID}'," +
                            $"DateOfJob = '{Date}'," +
                            $"price = '{Price}'," +
                            $"TypeOfChimney = '{Chimney}'," +
                            $"Selected = '{1}'" +
                            $"WHERE (JobID = {jobID})";
            dBConnector.Connect();
            dBConnector.DoDML(cmdStr);
            dBConnector.Close();

        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            int selected = 0;
            int jobID = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            clsDBConnector dbConnector2 = new clsDBConnector();
            OleDbDataReader dr2;
            dbConnector.Connect();
            string sql = "SELECT JobID, Selected FROM tblJob";
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {
                jobID = Convert.ToInt32(dr[0]);
                selected = Convert.ToInt32(dr[1]);
                if (selected == 1)
                {
                    dbConnector.Close();
                   
                    string sql2 = $"INSERT INTO tblJobActions (ActionID, JobID) " +
                    $"VALUES ('{1}' , '{jobID}')";
                    dr2 = dbConnector2.DoSQL(sql2);
                    break;
                }
            }
            dbConnector2.Close();

        }

        private void btnAction2_Click(object sender, EventArgs e)
        {

        }

        private void btnAction3_Click(object sender, EventArgs e)
        {

        }
    }

}

