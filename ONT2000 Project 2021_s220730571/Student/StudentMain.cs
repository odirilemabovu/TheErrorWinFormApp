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
    public partial class StudentMain : Form
    {
        static DataTable dt = Login.dtinfo;
        public StudentMain()
        {
            InitializeComponent();
        }

        private void btnaddErrors_Click(object sender, EventArgs e)
        {
            loadform(new StudentAddError());
        }

        private void btnManageErrors_Click(object sender, EventArgs e)
        {
            loadform(new Reports());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = null;
            Login form = new Login();
            form.Show();
            this.Hide();
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

        private void StudentMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = dt.Rows[0]["Username"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            loadform(new StudentAddError());
        }
    }
}
