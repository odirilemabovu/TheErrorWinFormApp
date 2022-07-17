using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ONT2000_Project_2021_s220730571
{
    public partial class AdminManageUsers : Form
    {
        static string connString = "Data Source=Michael;Initial Catalog=ErrorDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        DataAccessLayer dal = new DataAccessLayer();
        public AdminManageUsers()
        {
            InitializeComponent();
        }

        private void AdminManageUsers_Load(object sender, EventArgs e)
        {
            Refresh();
            LoadRoles();

        }
        public void Refresh()
        {
            dgvManageUsers.DataSource = dal.GetUserData();




        }
        public void LoadRoles()
        {

            cmbRoles.DataSource = dal.GetRoleData();
            cmbRoles.DisplayMember = "RoleDescription";
            cmbRoles.ValueMember = "RoleID";
        }

        private void btnaddUsers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtUsername,"Please do not leave field empty.");
            }
            else
            {}
            int x = dal.InsertUser(int.Parse(cmbRoles.SelectedValue.ToString()), txtUsername.Text, txtSurname.Text, cmbGender.SelectedItem.ToString(), txtEmail.Text, txtPassword.Text, cmbUserStatus.SelectedItem.ToString());
            if (x > 0)
            {
                MessageBox.Show("User Added.");
            }
            else
            {
                MessageBox.Show(x + " Inserted.");
            }
            Refresh();
            //Close connection to the database.

        }
        public void Clear()
        {
            cmbRoles.SelectedIndex = -1;
            txtUsername.Clear();
            txtSurname.Clear();
            cmbGender.SelectedIndex = -1;
            txtPassword.Clear();
            txtEmail.Clear();
            
        }

        private void dgvManageUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dgvManageUsers.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = dal.GetUserDataByID(int.Parse(dgvManageUsers.SelectedRows[0].Cells["UserID"].Value.ToString()));
                cmbRoles.Text = dt.Rows[0]["RoleDescription"].ToString();
                txtUsername.Text = dt.Rows[0]["Username"].ToString();              
                txtSurname.Text = dt.Rows[0]["Surname"].ToString();
                cmbGender.Text = dt.Rows[0]["Gender"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                cmbUserStatus.Text = dt.Rows[0]["UserStatus"].ToString();
                cmbRoles.Enabled = false;
            }
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            int UserID;
            UserID = int.Parse(dgvManageUsers.SelectedRows[0].Cells["UserID"].Value.ToString());
            int x = dal.UpdateUserData(UserID,txtUsername.Text, txtSurname.Text, cmbGender.SelectedItem.ToString(), txtEmail.Text, txtPassword.Text, cmbUserStatus.SelectedItem.ToString());
            if (x > 0)
            {
                MessageBox.Show("User Info Updated.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show(x + " Updated.");
            }
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            int UserID;
            UserID = int.Parse(dgvManageUsers.SelectedRows[0].Cells["UserID"].Value.ToString());
            int x = dal.DeleteUserData(UserID);
            if (x > 0)
            {
                MessageBox.Show("User Info Deleted.");
                Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show(x + " Deleted.");
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            Clear();
            cmbRoles.Enabled = true;

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
           
                if (dgvManageUsers.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Output.pdf";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dgvManageUsers.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgvManageUsers.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgvManageUsers.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                    //pdfTable.AddCell(cell.Value.ToString());
                                     pdfTable.AddCell(!string.IsNullOrEmpty(cell.Value.ToString()) ? Convert.ToString(cell.Value) : "");

                                }
                                
                            }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }
            
            


        }
    }
}
