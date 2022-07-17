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
using System.Drawing.Imaging;

namespace ONT2000_Project_2021_s220730571
{
    public partial class Reports : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public Reports()
        {
            InitializeComponent();
        }

        private void lblNoOFSTudents_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            CountAdmin();
            CountLecturer();
            CountStudent();
            CountMostProgLang();
            List();
            SolvedError();
            UnSolvedError();
            CountLeastProgLang();
            //int.Parse(lblNoOFSTudents.Text) = dal.CountUserAdmin;
        }
        private void CountAdmin()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dbAdapter = new SqlDataAdapter("SELECT COUNT(*) as AdminCount FROM tblUser WHERE RoleID = 1 AND UserStatus ='Active'", connString);
                dbAdapter.Fill(dt);
                lblNoAdmin.Text = dt.Rows[0][0].ToString();
                dbConn.Close();
            }
            catch
            {
            }
        }
        private void CountLecturer()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dbAdapter = new SqlDataAdapter("SELECT COUNT(*) as AdminCount FROM tblUser WHERE RoleID = 2 AND UserStatus ='Active'", connString);
                dbAdapter.Fill(dt);
                lblNoLecturer.Text = dt.Rows[0][0].ToString();
                dbConn.Close();
            }
            catch
            {
            }
        }
        private void CountStudent()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dbAdapter = new SqlDataAdapter("SELECT COUNT(*) as AdminCount FROM tblUser WHERE RoleID = 3 AND UserStatus ='Active' ", connString);
                dbAdapter.Fill(dt);
                lblNoOFSTudents.Text = dt.Rows[0][0].ToString();
                dbConn.Close();
            }
            catch
            {
            }
        }
        private void CountMostProgLang()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dbAdapter = new SqlDataAdapter("SELECT ProgLanguageDesc, COUNT(e.ProgLanguageID) AS PLCount FROM tblError e, tblProgLanguage p WHERE e.ProgLanguageID = p.ProgLanguageID GROUP BY e.ProgLanguageID, ProgLanguageDesc ORDER BY e.ProgLanguageID DESC", connString);
                dbAdapter.Fill(dt);
                lblProgLang.Text = dt.Rows[0][0].ToString();
                dbConn.Close();
            }
            catch 
            {
            }
        }
        private void CountLeastProgLang()
        {
            try
            {



                dbConn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dbAdapter = new SqlDataAdapter("SELECT ProgLanguageDesc, COUNT(e.ProgLanguageID) AS PLCount FROM tblError e, tblProgLanguage p WHERE e.ProgLanguageID = p.ProgLanguageID GROUP BY e.ProgLanguageID, ProgLanguageDesc ORDER BY e.ProgLanguageID ASC", connString);
                dbAdapter.Fill(dt);
                lblProgLang2.Text = dt.Rows[0][0].ToString();
                dbConn.Close();
            }
            catch
            {
            }
        }
        private void List()
        {
            cmbProgLang.DataSource = dal.GetProgLanguageData();
            cmbProgLang.DisplayMember = "ProgLanguageDesc";
            cmbProgLang.ValueMember = "ProgLanguageID";
        }
        private void SolvedError()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                string qry = "Select DISTINCT ErrorDescription From tblError e,tblErrorSolution s WHere s.ErrorID = e.ErrorID AND s.ErrorSolutionID > 0   ";
                SqlDataAdapter dbAdapter = new SqlDataAdapter(qry, connString);
                dbAdapter.Fill(dt);
                dgvSolvedErrors.DataSource = dt;
                dbConn.Close();
            }
            catch 
            {
            }
        }
        private void UnSolvedError()
        {
            try
            {
                dbConn.Open();
                DataTable dt = new DataTable();
                string qry = "Select DISTINCT ErrorDescription From tblError e,tblErrorSolution s WHere s.ErrorID = e.ErrorID AND s.ErrorSolutionID < 0 OR ErrorDescription = 'Unsolved' ";
                SqlDataAdapter dbAdapter = new SqlDataAdapter(qry, connString);
                dbAdapter.Fill(dt);
                dgvUnsolved.DataSource = dt;
                dbConn.Close();
            }
            catch
            {
            }
        }




        private void lblNoLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try 
            {
            dbConn.Open();
            DataTable dt = new DataTable();
            string qry = "Select DISTINCT ErrorDescription,ErrorStatus From tblError e,tblProgLanguage p WHere e.ProgLanguageID = '" + cmbProgLang.SelectedValue.ToString() + "'  ";
            SqlDataAdapter dbAdapter = new SqlDataAdapter(qry, connString);
            dbAdapter.Fill(dt);
            dgvSsearchError.DataSource = dt;
            dbConn.Close();
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
