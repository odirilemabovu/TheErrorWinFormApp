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
    public partial class StudentManageError : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public StudentManageError()
        {
            InitializeComponent();
        }

        private void StudentManageError_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvError_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateError_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbProgLang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtErrorDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbProgLang_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            DataTable dt = new DataTable();
            string qry = "Select DISTINCT ErrorDescription,ErrorStatus From tblError e WHere ErrorDescription Like '%'" + txtSearchError.Text + "'%'  ";
            SqlDataAdapter dbAdapter = new SqlDataAdapter(qry, connString);
            dbAdapter.Fill(dt);
            dgvError.DataSource = dt;
            dbConn.Close();
        }
    }
}
