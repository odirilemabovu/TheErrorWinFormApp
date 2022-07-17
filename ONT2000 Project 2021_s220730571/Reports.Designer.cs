
namespace ONT2000_Project_2021_s220730571
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoAdmin = new System.Windows.Forms.Label();
            this.lblNoLecturer = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.lblNoOFSTudents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSolvedErrors = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProgLang2 = new System.Windows.Forms.Label();
            this.lblProgLang = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvUnsolved = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProgLang = new System.Windows.Forms.ComboBox();
            this.dgvSsearchError = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvedErrors)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsolved)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSsearchError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 74);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(224, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analytical Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNoAdmin);
            this.groupBox2.Controls.Add(this.lblNoLecturer);
            this.groupBox2.Controls.Add(this.lblr);
            this.groupBox2.Controls.Add(this.lblNoOFSTudents);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Location = new System.Drawing.Point(52, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 184);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number Of Active Users";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administrator:";
            // 
            // lblNoAdmin
            // 
            this.lblNoAdmin.AutoSize = true;
            this.lblNoAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAdmin.Location = new System.Drawing.Point(194, 132);
            this.lblNoAdmin.Name = "lblNoAdmin";
            this.lblNoAdmin.Size = new System.Drawing.Size(22, 22);
            this.lblNoAdmin.TabIndex = 4;
            this.lblNoAdmin.Text = "_";
            // 
            // lblNoLecturer
            // 
            this.lblNoLecturer.AutoSize = true;
            this.lblNoLecturer.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLecturer.Location = new System.Drawing.Point(194, 88);
            this.lblNoLecturer.Name = "lblNoLecturer";
            this.lblNoLecturer.Size = new System.Drawing.Size(22, 22);
            this.lblNoLecturer.TabIndex = 3;
            this.lblNoLecturer.Text = "_";
            this.lblNoLecturer.Click += new System.EventHandler(this.lblNoLecturer_Click);
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(6, 93);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(81, 18);
            this.lblr.TabIndex = 2;
            this.lblr.Text = "Lecturer:";
            // 
            // lblNoOFSTudents
            // 
            this.lblNoOFSTudents.AutoSize = true;
            this.lblNoOFSTudents.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOFSTudents.Location = new System.Drawing.Point(194, 43);
            this.lblNoOFSTudents.Name = "lblNoOFSTudents";
            this.lblNoOFSTudents.Size = new System.Drawing.Size(22, 22);
            this.lblNoOFSTudents.TabIndex = 1;
            this.lblNoOFSTudents.Text = "_";
            this.lblNoOFSTudents.Click += new System.EventHandler(this.lblNoOFSTudents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Students:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgvSolvedErrors);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox3.Location = new System.Drawing.Point(735, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 184);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Of Solved Errors";
            // 
            // dgvSolvedErrors
            // 
            this.dgvSolvedErrors.AllowUserToOrderColumns = true;
            this.dgvSolvedErrors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSolvedErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolvedErrors.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvSolvedErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolvedErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolvedErrors.GridColor = System.Drawing.Color.Teal;
            this.dgvSolvedErrors.Location = new System.Drawing.Point(6, 43);
            this.dgvSolvedErrors.Name = "dgvSolvedErrors";
            this.dgvSolvedErrors.RowHeadersWidth = 51;
            this.dgvSolvedErrors.RowTemplate.Height = 24;
            this.dgvSolvedErrors.Size = new System.Drawing.Size(413, 133);
            this.dgvSolvedErrors.TabIndex = 52;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblProgLang2);
            this.groupBox4.Controls.Add(this.lblProgLang);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox4.Location = new System.Drawing.Point(397, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 179);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Programming Language With The:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Least Errors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Most Errors";
            // 
            // lblProgLang2
            // 
            this.lblProgLang2.AutoSize = true;
            this.lblProgLang2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgLang2.Location = new System.Drawing.Point(157, 100);
            this.lblProgLang2.Name = "lblProgLang2";
            this.lblProgLang2.Size = new System.Drawing.Size(38, 18);
            this.lblProgLang2.TabIndex = 3;
            this.lblProgLang2.Text = "___";
            // 
            // lblProgLang
            // 
            this.lblProgLang.AutoSize = true;
            this.lblProgLang.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgLang.Location = new System.Drawing.Point(17, 100);
            this.lblProgLang.Name = "lblProgLang";
            this.lblProgLang.Size = new System.Drawing.Size(38, 18);
            this.lblProgLang.TabIndex = 2;
            this.lblProgLang.Text = "___";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.dgvUnsolved);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox5.Location = new System.Drawing.Point(741, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 227);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List Of Unsolved Errors";
            // 
            // dgvUnsolved
            // 
            this.dgvUnsolved.AllowUserToOrderColumns = true;
            this.dgvUnsolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUnsolved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnsolved.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvUnsolved.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnsolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsolved.GridColor = System.Drawing.Color.Teal;
            this.dgvUnsolved.Location = new System.Drawing.Point(6, 87);
            this.dgvUnsolved.Name = "dgvUnsolved";
            this.dgvUnsolved.RowHeadersWidth = 51;
            this.dgvUnsolved.RowTemplate.Height = 24;
            this.dgvUnsolved.Size = new System.Drawing.Size(413, 133);
            this.dgvUnsolved.TabIndex = 52;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.btnadd);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.cmbProgLang);
            this.groupBox6.Controls.Add(this.dgvSsearchError);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox6.Location = new System.Drawing.Point(52, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(621, 238);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Error By Prog Language";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(463, 45);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 26);
            this.btnadd.TabIndex = 55;
            this.btnadd.Text = "Search";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Programming Langauge:";
            // 
            // cmbProgLang
            // 
            this.cmbProgLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProgLang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProgLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgLang.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.cmbProgLang.FormattingEnabled = true;
            this.cmbProgLang.Location = new System.Drawing.Point(282, 45);
            this.cmbProgLang.Name = "cmbProgLang";
            this.cmbProgLang.Size = new System.Drawing.Size(175, 24);
            this.cmbProgLang.TabIndex = 53;
            // 
            // dgvSsearchError
            // 
            this.dgvSsearchError.AllowUserToOrderColumns = true;
            this.dgvSsearchError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSsearchError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSsearchError.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvSsearchError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSsearchError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSsearchError.GridColor = System.Drawing.Color.Teal;
            this.dgvSsearchError.Location = new System.Drawing.Point(12, 87);
            this.dgvSsearchError.Name = "dgvSsearchError";
            this.dgvSsearchError.RowHeadersWidth = 51;
            this.dgvSsearchError.RowTemplate.Height = 24;
            this.dgvSsearchError.Size = new System.Drawing.Size(603, 133);
            this.dgvSsearchError.TabIndex = 52;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 635);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvedErrors)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsolved)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSsearchError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoAdmin;
        private System.Windows.Forms.Label lblNoLecturer;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label lblNoOFSTudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvSolvedErrors;
        private System.Windows.Forms.DataGridView dgvUnsolved;
        private System.Windows.Forms.DataGridView dgvSsearchError;
        private System.Windows.Forms.Label lblProgLang;
        private System.Windows.Forms.ComboBox cmbProgLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProgLang2;
    }
}