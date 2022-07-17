
namespace ONT2000_Project_2021_s220730571
{
    partial class StudentAddError
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErrorDescription = new System.Windows.Forms.TextBox();
            this.cmbProgLang = new System.Windows.Forms.ComboBox();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbErrorStatus = new System.Windows.Forms.ComboBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(154, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(357, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Error";
            // 
            // txtErrorDescription
            // 
            this.txtErrorDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtErrorDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtErrorDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorDescription.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtErrorDescription.Location = new System.Drawing.Point(634, 202);
            this.txtErrorDescription.Multiline = true;
            this.txtErrorDescription.Name = "txtErrorDescription";
            this.txtErrorDescription.Size = new System.Drawing.Size(260, 80);
            this.txtErrorDescription.TabIndex = 1;
            // 
            // cmbProgLang
            // 
            this.cmbProgLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProgLang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProgLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgLang.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbProgLang.FormattingEnabled = true;
            this.cmbProgLang.Location = new System.Drawing.Point(634, 288);
            this.cmbProgLang.Name = "cmbProgLang";
            this.cmbProgLang.Size = new System.Drawing.Size(260, 24);
            this.cmbProgLang.TabIndex = 2;
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToOrderColumns = true;
            this.dgvError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvError.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvError.Location = new System.Drawing.Point(12, 434);
            this.dgvError.Name = "dgvError";
            this.dgvError.RowHeadersWidth = 51;
            this.dgvError.RowTemplate.Height = 24;
            this.dgvError.Size = new System.Drawing.Size(1190, 140);
            this.dgvError.TabIndex = 4;
            this.dgvError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvError.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvError_CellMouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(306, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Error Description:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(306, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Programming Langauge:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(306, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Error Status:";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(345, 378);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(169, 40);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(520, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(695, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbErrorStatus
            // 
            this.cmbErrorStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbErrorStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbErrorStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbErrorStatus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbErrorStatus.FormattingEnabled = true;
            this.cmbErrorStatus.Items.AddRange(new object[] {
            "New",
            "Pending",
            "Solved",
            "Unsolved"});
            this.cmbErrorStatus.Location = new System.Drawing.Point(634, 338);
            this.cmbErrorStatus.Name = "cmbErrorStatus";
            this.cmbErrorStatus.Size = new System.Drawing.Size(260, 24);
            this.cmbErrorStatus.TabIndex = 13;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(1033, 597);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(169, 32);
            this.btnPDF.TabIndex = 46;
            this.btnPDF.Text = "Export To PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentAddError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 672);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.cmbErrorStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvError);
            this.Controls.Add(this.cmbProgLang);
            this.Controls.Add(this.txtErrorDescription);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAddError";
            this.Text = "StudentAddError";
            this.Load += new System.EventHandler(this.StudentAddError_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErrorDescription;
        private System.Windows.Forms.ComboBox cmbProgLang;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbErrorStatus;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}