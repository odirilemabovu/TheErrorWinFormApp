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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        static DataTable dt = Login.dtinfo;

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


            //Login Info
            //lblusername.Text = "(" + dt.Rows[0]["Username"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            loadform(new AdminManageUsers());
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            loadform(new AdminManageStudents());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new AdminManageYM());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dt = null;
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            lblusername.Text = dt.Rows[0]["Username"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            loadform(new Reports());
        }

        private void btnLecturerHome_Click(object sender, EventArgs e)
        {
            loadform(new Reports());
        }
    }
}
