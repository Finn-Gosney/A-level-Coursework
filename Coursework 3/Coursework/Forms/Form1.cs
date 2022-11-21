using System;
using System.Data.OleDb;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coursework
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClients frmClients = new frmClients();
            frmClients.Show();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            frmJobs frmJobs = new frmJobs();
            frmJobs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGear frmGear = new frmGear();
            frmGear.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmActions frmActions = new frmActions();
            frmActions.Show();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            string password = "";

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string sql = "SELECT passwordText FROM tblPassword";
            dr = dbConnector.DoSQL(sql);
            dr.Read();
            
                password = password + dr[0].ToString();
            dbConnector.Close();
            


            if (txtPassWord.Text == password)
            {
                this.BackColor = Color.Black;
                lblWelcome.Show();
                this.Invalidate();


                lblPassword.Hide();
                btnPassword.Hide();
                txtPassWord.Hide();


                await Task.Delay(2500);  //write about this horrific thing in the write up


                lblWelcome.Hide();
                this.BackColor = Color.White;


                ShowButtons();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void ShowButtons()
        {
            btnActions.Show();
            btnClient.Show();
            btnGear.Show();
            label1.Show();
            btnJobs.Show();
            btnChangePassword.Show();
            btnJobActions.Show();
            btnJobGear.Show();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            //    string input = txtPassWord.Text;
            //    string secureInput = Encode(input);
            //    label1.Text = secureInput;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmPassword frmPassword = new frmPassword();
            frmPassword.Show();
        }

        private void btnJobActions_Click(object sender, EventArgs e)
        {
            frmJobActions frmJobActions = new frmJobActions();
            frmJobActions.Show();  
        }

        private void btnJobGear_Click(object sender, EventArgs e)
        {
            frmJobGear frmJobGear = new frmJobGear();
            frmJobGear.Show(); 
        }


        //private string Encode(string input)
        //{
        //    string Test = "";
        //    Encoding enc = Encoding.UTF8;
        //    SHA256Managed hash = new SHA256Managed();
        //    byte[] result = hash.ComputeHash(enc.GetBytes(input));
        //    foreach (byte item in result)
        //    {
        //        Test = Test + item.ToString();
        //    }
        //
        //    return Test;
        //}


    }
}
