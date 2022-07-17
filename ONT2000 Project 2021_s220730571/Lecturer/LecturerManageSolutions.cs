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
    public partial class LecturerManageSolutions : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        //DataTable dt;
        static DataTable dt = Login.dtinfo;
        public int LecturerID = int.Parse(dt.Rows[0]["UserID"].ToString());
        DataAccessLayer dal = new DataAccessLayer();

        public LecturerManageSolutions()
        {
            InitializeComponent();
        }

        private void LecturerManageSolutions_Load(object sender, EventArgs e)
        {
            LoadError();
            Refresh4();
            Clear4();

        }
        public void LoadError()
        {
            

           
        }
        public void Refresh4()
        {
            dgvManageSolutions.DataSource = dal.GetSolutionData();
        }
        public void Clear4()
        {
            //cmbStudentError.SelectedIndex = -1;
            txtSolutionsDescription.Clear();

        }

        private void btnaddSolution_Click(object sender, EventArgs e)
        {

            string ErrorDate = DateTime.Today.ToString();
            int x = dal.InsertSolutionData(LecturerID, txtSolutionsDescription.Text);// ,int.Parse(cmbStudentError.SelectedValue.ToString()));
            if (x > 0)
            {
                MessageBox.Show("Solution Added.");
            }
            else
            {
                MessageBox.Show("Error Not Added .");
            }
            Refresh4();
        }

        private void btnUpdateSolution_Click(object sender, EventArgs e)
        {
            string ErrorDate = DateTime.Today.ToString();
            int SolutionID;


            SolutionID = int.Parse(dgvManageSolutions.SelectedRows[0].Cells["SolutionID"].Value.ToString());
            int x = (int)dal.UpdateSolutionData(SolutionID, LecturerID, txtSolutionsDescription.Text);//, int.Parse(cmbStudentError.SelectedValue.ToString()));
            if (x > 0)
            {
                MessageBox.Show("Solution Updated.");
            }
            else
            {
                MessageBox.Show("Solution Not Updated .");
            }
            Refresh4();
            Clear4();
        }

        private void btnDeleteSolution_Click(object sender, EventArgs e)
        {
            int SolutionID;
            SolutionID = int.Parse(dgvManageSolutions.SelectedRows[0].Cells["SolutionID"].Value.ToString());

            int x = dal.DeleteSolutionData(SolutionID);
            if (x > 0)
            {
                MessageBox.Show("Solution Info Deleted.");

            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
            Refresh4();
            Clear4();
        }

        private void dgvManageSolutions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvManageSolutions.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetSolutionDataByID(int.Parse(dgvManageSolutions.SelectedRows[0].Cells["SolutionID"].Value.ToString()));
                txtSolutionsDescription.Text = dt.Rows[0]["SolutionDescription"].ToString();

            }
        }
    }
}
