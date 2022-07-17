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

namespace ONT2000_Project_2021_s220730571.Lecturer
{
    public partial class LectureAddTopic : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public LectureAddTopic()
        {
            InitializeComponent();
        }

        private void LectureAddTopic_Load(object sender, EventArgs e)
        {
            Refresh1();
            
        }
        public void Refresh1()
        {
            dgvAddTopics.DataSource = dal.GetTopicData();
        }
        public void Clear()
        {
            txtTopic.Clear();
        }

        private void btnaddTopic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTopic.Text))
            {
                errorProvider1.SetError(txtTopic, "Please do not leave field empty.");
            }
            dal.InsertTopicData(txtTopic.Text);
            Refresh();
            Clear();
        }

        private void btnUpdateTopic_Click(object sender, EventArgs e)
        {
            int TopicID;
            TopicID = int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString());
            int x = dal.UpdateTopicData(TopicID,txtTopic.Text);
            if (x > 0)
            {
                MessageBox.Show("Topic info Updated.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void dgvAddTopics_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAddTopics.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetTopicDataByID(int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString()));
                txtTopic.Text = dt.Rows[0]["YearDescription"].ToString();

            }
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            int TopicID;
            TopicID = int.Parse(dgvAddTopics.SelectedRows[0].Cells["TopicID"].Value.ToString());
            int x = dal.DeleteTopicData(TopicID);
            if (x > 0)
            {
                MessageBox.Show("Topic info Deleted.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }
    }
}
