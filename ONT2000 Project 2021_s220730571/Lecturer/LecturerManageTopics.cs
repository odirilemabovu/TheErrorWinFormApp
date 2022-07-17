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
    public partial class LecturerManageTopics : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        int TopicID;
        public LecturerManageTopics()
        {
            InitializeComponent();
        }

        private void LecturerManageTopics_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            Refresh2();

        }
        public void Refresh2()
        {
            DataTable dt = new DataTable();
            int ModuleTopicID;

            dgvManageTopics.DataSource = dal.GetModuleTopicData();




        }
        public void LoadComboBox()
        {
            cmbModules.DataSource = dal.GetModuleData();
            cmbModules.DisplayMember = "ModuleDescription";
            cmbModules.ValueMember = "ModuleID";

            cmbTopics.DataSource = dal.GetTopicData();
            cmbTopics.DisplayMember = "TopicDescription";
            cmbTopics.ValueMember = "TopicID";
        }
        public void Clear2()
        {
            cmbTopics.SelectedIndex = -1;
            cmbModules.SelectedIndex = -1;
            

        }

        private void btnaddTopic_Click(object sender, EventArgs e)
        {

            /*if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtDescription, "Please do not leave field empty.");
            }
            else
            {}
            */
          
            int x = dal.InsertModuleTopicData(int.Parse(cmbModules.SelectedValue.ToString()), int.Parse(cmbTopics.SelectedValue.ToString()));//,TopicDescription,ModuleDescription);
                if (x > 0)
                {
                    MessageBox.Show("Topic Assigned.");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                Refresh2();
                Clear2();
                //Close connection to the database.
            


        }

        private void dgvManageTopics_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvManageTopics.SelectedRows.Count > 0)
                {
                    
                        DataTable dt = new DataTable();
                        dt = dal.GetModuleTopicDataByID(int.Parse(dgvManageTopics.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString()));
                        cmbTopics.Text = dt.Rows[0]["TopicDescription"].ToString();
                        cmbModules.Text = dt.Rows[0]["ModuleDescription"].ToString();
                        //txtTopicDescription.Text = dt.Rows[0]["TopicDescription"].ToString();
                        //cmbRoles.Enabled = false;
                }
            }
            catch
            { 
            }
            
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            int ModuleTopicID;
            ModuleTopicID = int.Parse(dgvManageTopics.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());
            int x = dal.DeleteModuleTopicData(ModuleTopicID);
            if (x > 0)
            {
                MessageBox.Show("User Info Deleted.");
                Refresh();
                Clear2();
            }
            else
            {
                MessageBox.Show(x + " Deleted.");
            }
            Clear2();
            Refresh2();
            
        }

        private void btnUpdateTopic_Click(object sender, EventArgs e)
        {
            int ModuleTopicID;
            int ModuleID;
            int TopicID;
          //TopicID = int.Parse(dgvManageTopics.SelectedRows[0].Cells["TopicID"].Value.ToString());
           //ModuleID = int.Parse(dgvManageTopics.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            ModuleTopicID = int.Parse(dgvManageTopics.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());
            int x = dal.UpdateModuleTopicData(int.Parse(cmbModules.SelectedValue.ToString()), int.Parse(cmbTopics.SelectedValue.ToString()),ModuleTopicID);
            if (x > 0)
            {
                MessageBox.Show("User Info Updated.");
                Refresh();
                Clear2();
            }
            else
            {
                MessageBox.Show(x + " Not Updated.");
            }
            Clear2();
            Refresh2();
        }
    }
}
