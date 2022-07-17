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
    
    public partial class AdminManageStudents : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public AdminManageStudents()
        {
            InitializeComponent();
        }

        private void AdminManageStudents_Load(object sender, EventArgs e)
        {
            Refresh();
            LoadStudents();
        }
        private void Refresh()
        {
            dgvManageSModules.DataSource = dal.GetModuleData();
            dgvManageSYear.DataSource = dal.GetYearData();

        }
        public void Clear()
        {
            
            txtModule.Clear();
            txtYear.Clear();
            
        }
        public void LoadStudents()
        {
            /*
            cmbRoles.DataSource = dal.GetStudentData();
            cmbRoles.DisplayMember ="Username";
            cmbRoles.ValueMember = "UserID";
            */
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                errorProvider1.SetError(txtYear, "Please do not leave field empty.");
            }

            dal.InsertYearData(txtYear.Text);
            Refresh();
            Clear();
        }

        private void btnAssignModule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModule.Text))
            {
                errorProvider2.SetError(txtYear, "Please do not leave field empty.");
            }
            dal.InsertModuleData(txtModule.Text);
            Refresh();
            Clear();
        }

        private void dgvManageSModules_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvManageSModules.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetModuleDataByID(int.Parse(dgvManageSModules.SelectedRows[0].Cells["ModuleID"].Value.ToString()));
                txtModule.Text = dt.Rows[0]["ModuleDescription"].ToString();
            }
        }


        private void dgvManageSYear_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManageSYear.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetYearDataByID(int.Parse(dgvManageSYear.SelectedRows[0].Cells["YearID"].Value.ToString()));
                txtYear.Text = dt.Rows[0]["YearDescription"].ToString();
            }
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            int ModuleID;
            ModuleID = int.Parse(dgvManageSModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            int x = dal.UpdateModuleData(ModuleID, txtModule.Text);
            if (x > 0)
            {
                MessageBox.Show("Module Info Updated.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show(" Updated.");
            }
        }

        private void btnUpdateYear_Click(object sender, EventArgs e)
        {
            int YearID;
            YearID = int.Parse(dgvManageSYear.SelectedRows[0].Cells["YearID"].Value.ToString());
            int x = dal.UpdateYearData(YearID, txtYear.Text);
            if (x > 0)
            {
                MessageBox.Show("Year Info Updated.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Not Updated.");
            }
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            int ModuleID;
            ModuleID = int.Parse(dgvManageSModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            int x = dal.DeleteModuleData(ModuleID);
            if (x > 0)
            {
                MessageBox.Show("Module info Deleted.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void btnDeleteYear_Click(object sender, EventArgs e)
        {
            int YearID;
            YearID = int.Parse(dgvManageSYear.SelectedRows[0].Cells["YearID"].Value.ToString());
            int x = dal.DeleteYearData(YearID);
            if (x > 0)
            {
                MessageBox.Show("Year info Deleted.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void dgvManageSYear_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvManageSYear.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetYearDataByID(int.Parse(dgvManageSYear.SelectedRows[0].Cells["YearID"].Value.ToString()));
                txtYear.Text = dt.Rows[0]["YearDescription"].ToString();
            }
        }
    }
}
