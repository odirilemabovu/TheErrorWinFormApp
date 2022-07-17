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
    public partial class AdminManageYM : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public AdminManageYM()
        {
            InitializeComponent();
        }

        private void AdminManageYM_Load(object sender, EventArgs e)
        {
            Refresh6();
        }
        public void Refresh6()
        {
            
            dgvManageProgLang.DataSource = dal.GetProgLanguageData();
        }
        public void Clear6()
        {
            txtProgLang.Clear();
        }

        private void btnassignStudents_Click(object sender, EventArgs e)
        {
            dal.InsertProgLangData(txtProgLang.Text);
            Clear6();
            Refresh6();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ProgLanguageID;
            ProgLanguageID = int.Parse(dgvManageProgLang.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString());
            int x = dal.UpdateProgLangData(ProgLanguageID, txtProgLang.Text);
            if (x > 0)
            {
                MessageBox.Show("Programming Language Info Updated.");
                Refresh6();
                Clear6();
            }
            else
            {
                MessageBox.Show("Not Updated.");
            }
            Clear6();
            Refresh6();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ProgLanguageID;
            ProgLanguageID = int.Parse(dgvManageProgLang.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString());
            int x = dal.DeleteProgLangData(ProgLanguageID);
            if (x > 0)
            {
                MessageBox.Show("Programming Language info Deleted.");
                Refresh6();
                Clear6();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
            Clear6();
            Refresh6();

        }

        private void dgvManageProgLang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvManageProgLang.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetProgLanguageDataByID(int.Parse(dgvManageProgLang.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString()));
                txtProgLang.Text = dt.Rows[0]["ProgLanguageDesc"].ToString();
            }
        }
    }
}
