using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_Project_2021_s220730571
{
    public partial class LecturerAddTopic : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public LecturerAddTopic()
        {
            InitializeComponent();
        }
        private void LecturerAddTopic_Load(object sender, EventArgs e)
        {
            Refresh1();

        }
        public void Refresh1()
        {
            dgvAddTopics.DataSource = dal.GetTopicData();
        }
        public void Clear1()
        {
            txtTopics.Clear();
        }


        private void btnaddTopic_Click_1(object sender, EventArgs e)
        {
            int x = dal.InsertTopicData(txtTopics.Text);
            if (x > 0)
            {
                MessageBox.Show("Topic info Added.");
                Refresh();
                Clear1();
            }
            else
            {
                MessageBox.Show("Not Added.");
            }
            Refresh1();
            Clear1();
        }

        private void btnUpdateTopic_Click_1(object sender, EventArgs e)
        {
            int TopicID;
            TopicID = int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString());
            int x = dal.UpdateTopicData(TopicID, txtTopics.Text);
            if (x > 0)
            {
                MessageBox.Show("Topic info Updated.");
                Refresh1();
                Clear1();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void dgvAddTopics_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAddTopics.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetTopicDataByID(int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString()));
                txtTopics.Text = dt.Rows[0]["TopicDescription"].ToString();

            }
        }

        private void btnDeleteTopic_Click_1(object sender, EventArgs e)
        {
            int TopicID;
            TopicID = int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString());
            int x = dal.DeleteTopicData(TopicID);
            if (x > 0)
            {
                MessageBox.Show("Topic info Deleted.");
                Refresh1();
                Clear1();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void LecturerAddTopic_Load_1(object sender, EventArgs e)
        {
            Refresh1();
            Clear1();
            txtTopics.Focus();
        }
    }
}

