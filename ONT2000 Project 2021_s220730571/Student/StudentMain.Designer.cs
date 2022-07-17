
namespace ONT2000_Project_2021_s220730571
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.panelHide = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnManageErrors = new System.Windows.Forms.Button();
            this.btnaddErrors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHide.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHide.Controls.Add(this.btnExit);
            this.panelHide.Controls.Add(this.panelUser);
            this.panelHide.Controls.Add(this.btnManageErrors);
            this.panelHide.Controls.Add(this.btnaddErrors);
            this.panelHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHide.Location = new System.Drawing.Point(0, 30);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(200, 733);
            this.panelHide.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.Location = new System.Drawing.Point(0, 693);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.lblUsername);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(200, 168);
            this.panelUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(56, 93);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 18);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // btnManageErrors
            // 
            this.btnManageErrors.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnManageErrors.FlatAppearance.BorderSize = 0;
            this.btnManageErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageErrors.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageErrors.ForeColor = System.Drawing.Color.White;
            this.btnManageErrors.Location = new System.Drawing.Point(0, 261);
            this.btnManageErrors.Name = "btnManageErrors";
            this.btnManageErrors.Size = new System.Drawing.Size(200, 40);
            this.btnManageErrors.TabIndex = 1;
            this.btnManageErrors.Text = "Reports";
            this.btnManageErrors.UseVisualStyleBackColor = false;
            this.btnManageErrors.Click += new System.EventHandler(this.btnManageErrors_Click);
            // 
            // btnaddErrors
            // 
            this.btnaddErrors.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddErrors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddErrors.FlatAppearance.BorderSize = 0;
            this.btnaddErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddErrors.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddErrors.ForeColor = System.Drawing.Color.White;
            this.btnaddErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddErrors.Location = new System.Drawing.Point(0, 193);
            this.btnaddErrors.Name = "btnaddErrors";
            this.btnaddErrors.Size = new System.Drawing.Size(200, 40);
            this.btnaddErrors.TabIndex = 0;
            this.btnaddErrors.Text = "Add Errors";
            this.btnaddErrors.UseVisualStyleBackColor = false;
            this.btnaddErrors.Click += new System.EventHandler(this.btnaddErrors_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1384, 30);
            this.panelHeader.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1184, 733);
            this.panelMain.TabIndex = 2;
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1384, 763);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.panelHide.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnManageErrors;
        private System.Windows.Forms.Button btnaddErrors;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
    }
}

