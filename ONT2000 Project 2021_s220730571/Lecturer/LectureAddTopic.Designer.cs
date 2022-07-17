
namespace ONT2000_Project_2021_s220730571.Lecturer
{
    partial class LectureAddTopic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.btnUpdateTopic = new System.Windows.Forms.Button();
            this.btnaddTopic = new System.Windows.Forms.Button();
            this.dgvAddTopics = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTopics)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Topics";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(181, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Topic Description:";
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTopic.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteTopic.FlatAppearance.BorderSize = 0;
            this.btnDeleteTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTopic.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTopic.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTopic.Location = new System.Drawing.Point(551, 255);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(169, 40);
            this.btnDeleteTopic.TabIndex = 30;
            this.btnDeleteTopic.Text = "Delete";
            this.btnDeleteTopic.UseVisualStyleBackColor = false;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // btnUpdateTopic
            // 
            this.btnUpdateTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateTopic.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateTopic.FlatAppearance.BorderSize = 0;
            this.btnUpdateTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTopic.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTopic.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateTopic.Location = new System.Drawing.Point(376, 255);
            this.btnUpdateTopic.Name = "btnUpdateTopic";
            this.btnUpdateTopic.Size = new System.Drawing.Size(169, 40);
            this.btnUpdateTopic.TabIndex = 29;
            this.btnUpdateTopic.Text = "Update";
            this.btnUpdateTopic.UseVisualStyleBackColor = false;
            this.btnUpdateTopic.Click += new System.EventHandler(this.btnUpdateTopic_Click);
            // 
            // btnaddTopic
            // 
            this.btnaddTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddTopic.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnaddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddTopic.FlatAppearance.BorderSize = 0;
            this.btnaddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddTopic.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddTopic.ForeColor = System.Drawing.Color.White;
            this.btnaddTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddTopic.Location = new System.Drawing.Point(201, 255);
            this.btnaddTopic.Name = "btnaddTopic";
            this.btnaddTopic.Size = new System.Drawing.Size(169, 40);
            this.btnaddTopic.TabIndex = 28;
            this.btnaddTopic.Text = "Add";
            this.btnaddTopic.UseVisualStyleBackColor = false;
            this.btnaddTopic.Click += new System.EventHandler(this.btnaddTopic_Click);
            // 
            // dgvAddTopics
            // 
            this.dgvAddTopics.AllowUserToOrderColumns = true;
            this.dgvAddTopics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAddTopics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddTopics.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAddTopics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddTopics.GridColor = System.Drawing.Color.Teal;
            this.dgvAddTopics.Location = new System.Drawing.Point(166, 314);
            this.dgvAddTopics.Name = "dgvAddTopics";
            this.dgvAddTopics.RowHeadersWidth = 51;
            this.dgvAddTopics.RowTemplate.Height = 24;
            this.dgvAddTopics.Size = new System.Drawing.Size(584, 140);
            this.dgvAddTopics.TabIndex = 25;
            this.dgvAddTopics.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddTopics_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 66);
            this.panel1.TabIndex = 23;
            // 
            // txtTopic
            // 
            this.txtTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTopic.BackColor = System.Drawing.SystemColors.Window;
            this.txtTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTopic.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtTopic.Location = new System.Drawing.Point(527, 173);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(212, 16);
            this.txtTopic.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LectureAddTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.btnUpdateTopic);
            this.Controls.Add(this.btnaddTopic);
            this.Controls.Add(this.dgvAddTopics);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureAddTopic";
            this.Text = "LectureAddTopic";
            this.Load += new System.EventHandler(this.LectureAddTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTopics)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTopic;
        private System.Windows.Forms.Button btnUpdateTopic;
        private System.Windows.Forms.Button btnaddTopic;
        private System.Windows.Forms.DataGridView dgvAddTopics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}