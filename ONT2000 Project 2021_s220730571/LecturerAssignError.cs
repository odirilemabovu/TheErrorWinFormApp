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
    public partial class LecturerAssignError : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        //DataTable dt;
        static DataTable dt = Login.dtinfo;
        public int StudentID = int.Parse(dt.Rows[0]["UserID"].ToString());
        DataAccessLayer dal = new DataAccessLayer();
        public LecturerAssignError()
        {
            InitializeComponent();
        }

        private void LecturerAssignError_Load(object sender, EventArgs e)
        {
            LoadErrorAndSolution();
            Refresh5();
            Clear5();

        }
        public void LoadErrorAndSolution()
        {
            cmbStudentError.DataSource = dal.GetErrorData();
            cmbStudentError.DisplayMember = "ErrorDescription";
            cmbStudentError.ValueMember = "ErrorID";

            cmbSolutions.DataSource = dal.GetSolutionData();
            cmbSolutions.DisplayMember = "SolutionDescription";
            cmbSolutions.ValueMember = "SolutionID";
        }
        public void Refresh5()
        {
            dgvAssignSolutions.DataSource = dal.GetErrorSolutionData();
        }
        public void Clear5()
        {
            cmbStudentError.SelectedIndex = -1;
            cmbSolutions.SelectedIndex = -1;

        }

        private void btnassignSolution_Click(object sender, EventArgs e)
        {
            string SolutionDate = DateTime.Today.ToString();

            int x = (int)dal.InsertErrorSolutionData(int.Parse(cmbSolutions.SelectedValue.ToString()), int.Parse(cmbStudentError.SelectedValue.ToString()), SolutionDate);
            if (x > 0)
            {
                MessageBox.Show("Assigned.");
            }
            else
            {
                MessageBox.Show("Not Assigned.");
            }
            Refresh5();
            Clear5();

        }

        private void btnUpdateASolution_Click(object sender, EventArgs e)
        {
            
            string SolutionDate = DateTime.Today.ToString();
            int ErrorSolutionID;


            ErrorSolutionID = int.Parse(dgvAssignSolutions.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());
            int x = (int)dal.UpdateErrorSolutionData(int.Parse(cmbSolutions.SelectedValue.ToString()), int.Parse(cmbStudentError.SelectedValue.ToString()),ErrorSolutionID ,SolutionDate);
            if (x > 0)
            {
                MessageBox.Show("Update Successful.");
            }
            else
            {
                MessageBox.Show("Update Not Successful.");
            }
            Refresh5();
            Clear5();
        }

        private void btnDeleteASolution_Click(object sender, EventArgs e)
        {
            int ErrorSolutionID;
            ErrorSolutionID = int.Parse(dgvAssignSolutions.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());

            int x = dal.DeleteErrorSolutionData(ErrorSolutionID);
            if (x > 0)
            {
                MessageBox.Show("Info Deleted.");

            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
            Refresh5();
            Clear5();
        }

        private void dgvAssignSolutions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAssignSolutions.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetErrorSolutionDataByID(int.Parse(dgvAssignSolutions.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString()));
                cmbSolutions.Text = dt.Rows[0]["SolutionDescription"].ToString();
                cmbStudentError.Text = dt.Rows[0]["ErrorDescription"].ToString();

            }
        }
    }
}
