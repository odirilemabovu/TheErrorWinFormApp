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
    public partial class StudentAddError : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        //DataTable dt;
        static DataTable dt = Login.dtinfo;
        public int StudentID = int.Parse(dt.Rows[0]["UserID"].ToString());
        DataAccessLayer dal = new DataAccessLayer();

        public StudentAddError()
        {
            InitializeComponent();
        }

        private void StudentAddError_Load(object sender, EventArgs e)
        {
            txtErrorDescription.Focus();
            CMBLoad();
            Refresh3();
            Clear3();

        }
        public void CMBLoad()
        {
            //cmbModuleTopic.DataSource = dal.GetModuleTopicData();
            //cmbModuleTopic.DisplayMember = "Module And Topic";
            //cmbModuleTopic.ValueMember = "ModuleTopicID";

            cmbProgLang.DataSource = dal.GetProgLanguageData();
            cmbProgLang.DisplayMember = "ProgLanguageDesc";
            cmbProgLang.ValueMember = "ProgLanguageID";
        }
        public void Refresh3()
        {
            dgvError.DataSource = dal.GetErrorData();
        }
        public void Clear3()
        {
            cmbErrorStatus.SelectedIndex = -1;
            //cmbModuleTopic.SelectedIndex = -1;
            cmbProgLang.SelectedIndex = -1;
            txtErrorDescription.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvError_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvError.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetErrorDataByID(int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString()));
                txtErrorDescription.Text = dt.Rows[0]["ErrorDescription"].ToString();
                cmbProgLang.Text = dt.Rows[0]["ProgLanguageDesc"].ToString();
                //cmbModuleTopic.Text = dt.Rows[0]["Module And Topic"].ToString();
                cmbErrorStatus.Text = dt.Rows[0]["ErrorStatus"].ToString();
               // cmbModuleTopic.Visible = false;
            }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtErrorDescription.Text) && string.IsNullOrEmpty(cmbErrorStatus.Text) && string.IsNullOrEmpty(cmbProgLang.Text))
            {
                errorProvider1.SetError(txtErrorDescription, "Please do not leave field empty.");
            }
            //int StudentID;
            string ErrorDate = DateTime.Today.ToString();
                int x = dal.InsertErrorData(StudentID, txtErrorDescription.Text, int.Parse(cmbProgLang.SelectedValue.ToString()), cmbErrorStatus.SelectedItem.ToString(),ErrorDate);
                if (x > 0)
                {
                    MessageBox.Show("Error Added.");
                }
                else
                {
                    MessageBox.Show("Error Not Added .");
                }
                Refresh3();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ErrorDate = DateTime.Today.ToString();
            int ErrorID;

            
            ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            int x = (int)dal.UpdateErrorData(ErrorID,StudentID, txtErrorDescription.Text, int.Parse(cmbProgLang.SelectedValue.ToString()), cmbErrorStatus.SelectedItem.ToString(), ErrorDate);
            if (x > 0)
            {
                MessageBox.Show("Error Info Updated.");
            }
            else
            {
                MessageBox.Show("Error Not Updated .");
            }
            Refresh3();
            Clear3();
        }

            private void btnDelete_Click(object sender, EventArgs e)
        {
            int ErrorID;
            ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            int x = dal.DeleteErrorData(ErrorID);
            if (x > 0)
            {
                MessageBox.Show("Error Info Deleted.");
                
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
            Refresh3();
            Clear3();
        }
    }
}
