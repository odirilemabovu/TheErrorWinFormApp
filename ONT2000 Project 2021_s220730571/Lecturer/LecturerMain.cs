using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_Project_2021_s220730571
{
    public partial class LecturerMain : Form
    {
        static DataTable dt = Login.dtinfo;

        public LecturerMain()
        {
            InitializeComponent();
        }
        private void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnManageTopics_Click(object sender, EventArgs e)
        {
            loadform(new LecturerManageTopics());
        }

        private void btnManageSolutions_Click(object sender, EventArgs e)
        {
            loadform(new LecturerManageSolutions());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new LecturerAddTopic());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LecturerMain_Load(object sender, EventArgs e)
        {
            label3.Text = dt.Rows[0]["Username"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            loadform(new Reports());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new LecturerAssignError());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dt = null;
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnLecturerHome_Click(object sender, EventArgs e)
        {
            loadform(new Reports());
        }
    }
}
