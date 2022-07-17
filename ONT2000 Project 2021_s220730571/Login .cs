using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ONT2000_Project_2021_s220730571
{
    public partial class Login : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public static DataTable dtinfo;
        public Login()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtUsername, "Please do not leave username empty.");
                errorProvider2.SetError(txtPassword, "Please do not password empty.");
            }
            try
            {
                dtinfo = dal.GetLoginInfo(txtUsername.Text, txtPassword.Text);
                int role = int.Parse(dtinfo.Rows[0]["RoleID"].ToString());


                if (dtinfo.Rows.Count > 0)
                {
                    try
                    {
                        if (role == 1)
                        {
                            AdminMain form = new AdminMain();
                            form.Show();
                            this.Hide();

                        }
                        else if (role == 3)
                        {
                            StudentMain form = new StudentMain();
                            form.Show();
                            this.Hide();
                        }
                        else if (role == 2)
                        {
                            LecturerMain form = new LecturerMain();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect Username or Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Username or Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
            
           
     

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {

            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
