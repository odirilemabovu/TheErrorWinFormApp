
namespace ONT2000_Project_2021_s220730571
{
    partial class LecturerAssignError
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAssignSolutions = new System.Windows.Forms.DataGridView();
            this.btnDeleteASolution = new System.Windows.Forms.Button();
            this.btnUpdateASolution = new System.Windows.Forms.Button();
            this.btnassignSolution = new System.Windows.Forms.Button();
            this.cmbStudentError = new System.Windows.Forms.ComboBox();
            this.cmbSolutions = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignSolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(153, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Solutions:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(153, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Student Errors:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 66);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(271, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Solutions";
            // 
            // dgvAssignSolutions
            // 
            this.dgvAssignSolutions.AllowUserToOrderColumns = true;
            this.dgvAssignSolutions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAssignSolutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignSolutions.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAssignSolutions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignSolutions.GridColor = System.Drawing.Color.Teal;
            this.dgvAssignSolutions.Location = new System.Drawing.Point(157, 327);
            this.dgvAssignSolutions.Name = "dgvAssignSolutions";
            this.dgvAssignSolutions.RowHeadersWidth = 51;
            this.dgvAssignSolutions.RowTemplate.Height = 24;
            this.dgvAssignSolutions.Size = new System.Drawing.Size(584, 140);
            this.dgvAssignSolutions.TabIndex = 34;
            this.dgvAssignSolutions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAssignSolutions_CellMouseClick);
            // 
            // btnDeleteASolution
            // 
            this.btnDeleteASolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteASolution.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteASolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteASolution.FlatAppearance.BorderSize = 0;
            this.btnDeleteASolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteASolution.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteASolution.ForeColor = System.Drawing.Color.White;
            this.btnDeleteASolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteASolution.Location = new System.Drawing.Point(542, 268);
            this.btnDeleteASolution.Name = "btnDeleteASolution";
            this.btnDeleteASolution.Size = new System.Drawing.Size(169, 40);
            this.btnDeleteASolution.TabIndex = 39;
            this.btnDeleteASolution.Text = "Delete";
            this.btnDeleteASolution.UseVisualStyleBackColor = false;
            this.btnDeleteASolution.Click += new System.EventHandler(this.btnDeleteASolution_Click);
            // 
            // btnUpdateASolution
            // 
            this.btnUpdateASolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateASolution.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateASolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateASolution.FlatAppearance.BorderSize = 0;
            this.btnUpdateASolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateASolution.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateASolution.ForeColor = System.Drawing.Color.White;
            this.btnUpdateASolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateASolution.Location = new System.Drawing.Point(367, 268);
            this.btnUpdateASolution.Name = "btnUpdateASolution";
            this.btnUpdateASolution.Size = new System.Drawing.Size(169, 40);
            this.btnUpdateASolution.TabIndex = 38;
            this.btnUpdateASolution.Text = "Update";
            this.btnUpdateASolution.UseVisualStyleBackColor = false;
            this.btnUpdateASolution.Click += new System.EventHandler(this.btnUpdateASolution_Click);
            // 
            // btnassignSolution
            // 
            this.btnassignSolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnassignSolution.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnassignSolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnassignSolution.FlatAppearance.BorderSize = 0;
            this.btnassignSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassignSolution.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassignSolution.ForeColor = System.Drawing.Color.White;
            this.btnassignSolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassignSolution.Location = new System.Drawing.Point(192, 268);
            this.btnassignSolution.Name = "btnassignSolution";
            this.btnassignSolution.Size = new System.Drawing.Size(169, 40);
            this.btnassignSolution.TabIndex = 37;
            this.btnassignSolution.Text = "Assign";
            this.btnassignSolution.UseVisualStyleBackColor = false;
            this.btnassignSolution.Click += new System.EventHandler(this.btnassignSolution_Click);
            // 
            // cmbStudentError
            // 
            this.cmbStudentError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStudentError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStudentError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudentError.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbStudentError.FormattingEnabled = true;
            this.cmbStudentError.Location = new System.Drawing.Point(481, 150);
            this.cmbStudentError.Name = "cmbStudentError";
            this.cmbStudentError.Size = new System.Drawing.Size(260, 24);
            this.cmbStudentError.TabIndex = 33;
            // 
            // cmbSolutions
            // 
            this.cmbSolutions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSolutions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSolutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSolutions.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbSolutions.FormattingEnabled = true;
            this.cmbSolutions.Location = new System.Drawing.Point(481, 203);
            this.cmbSolutions.Name = "cmbSolutions";
            this.cmbSolutions.Size = new System.Drawing.Size(260, 24);
            this.cmbSolutions.TabIndex = 40;
            // 
            // LecturerAssignError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.cmbSolutions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAssignSolutions);
            this.Controls.Add(this.btnDeleteASolution);
            this.Controls.Add(this.btnUpdateASolution);
            this.Controls.Add(this.btnassignSolution);
            this.Controls.Add(this.cmbStudentError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerAssignError";
            this.Text = "LecturerAssignError";
            this.Load += new System.EventHandler(this.LecturerAssignError_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignSolutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAssignSolutions;
        private System.Windows.Forms.Button btnDeleteASolution;
        private System.Windows.Forms.Button btnUpdateASolution;
        private System.Windows.Forms.Button btnassignSolution;
        private System.Windows.Forms.ComboBox cmbStudentError;
        private System.Windows.Forms.ComboBox cmbSolutions;
    }
}