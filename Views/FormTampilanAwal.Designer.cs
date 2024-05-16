namespace SistemOperasiProyek
{
    partial class FormTampilanAwal
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnTugas = new System.Windows.Forms.Button();
            this.btnKegiatan = new System.Windows.Forms.Button();
            this.btnProyek = new System.Windows.Forms.Button();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(650, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SistemOperasiProyek.Properties.Resources.icons8_close_window_25;
            this.btnClose.Location = new System.Drawing.Point(48, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::SistemOperasiProyek.Properties.Resources.icons8_maximize_25;
            this.btnMax.Location = new System.Drawing.Point(24, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(24, 46);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::SistemOperasiProyek.Properties.Resources.icons8_minimize_25__1_;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 46);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pnlNavIndicator);
            this.panel2.Controls.Add(this.btnProfil);
            this.panel2.Controls.Add(this.btnKaryawan);
            this.panel2.Controls.Add(this.btnTugas);
            this.panel2.Controls.Add(this.btnKegiatan);
            this.panel2.Controls.Add(this.btnProyek);
            this.panel2.Controls.Add(this.btnBeranda);
            this.panel2.Controls.Add(this.lblJabatan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 675);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(19, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserID :";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogout.Image = global::SistemOperasiProyek.Properties.Resources.exit__2_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "     Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserID.Location = new System.Drawing.Point(19, 640);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 17);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "UserID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(22, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(22, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 1);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemOperasiProyek.Properties.Resources.simprobiru;
            this.pictureBox2.Location = new System.Drawing.Point(50, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.pnlNavIndicator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlNavIndicator.Location = new System.Drawing.Point(-27, 344);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(2, 100);
            this.pnlNavIndicator.TabIndex = 5;
            // 
            // btnProfil
            // 
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.Color.LightGray;
            this.btnProfil.Image = global::SistemOperasiProyek.Properties.Resources.user__1_;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(-3, 333);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProfil.Size = new System.Drawing.Size(200, 42);
            this.btnProfil.TabIndex = 4;
            this.btnProfil.Text = "    Profil ";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.FlatAppearance.BorderSize = 0;
            this.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaryawan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.ForeColor = System.Drawing.Color.LightGray;
            this.btnKaryawan.Image = global::SistemOperasiProyek.Properties.Resources.value__1_;
            this.btnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaryawan.Location = new System.Drawing.Point(0, 285);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKaryawan.Size = new System.Drawing.Size(200, 42);
            this.btnKaryawan.TabIndex = 4;
            this.btnKaryawan.Text = "     Karyawan";
            this.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnTugas
            // 
            this.btnTugas.FlatAppearance.BorderSize = 0;
            this.btnTugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTugas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTugas.ForeColor = System.Drawing.Color.LightGray;
            this.btnTugas.Image = global::SistemOperasiProyek.Properties.Resources.clipboard;
            this.btnTugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTugas.Location = new System.Drawing.Point(0, 243);
            this.btnTugas.Name = "btnTugas";
            this.btnTugas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTugas.Size = new System.Drawing.Size(200, 42);
            this.btnTugas.TabIndex = 4;
            this.btnTugas.Text = "     Tugas     ";
            this.btnTugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTugas.UseVisualStyleBackColor = true;
            this.btnTugas.Click += new System.EventHandler(this.btnTugas_Click);
            // 
            // btnKegiatan
            // 
            this.btnKegiatan.FlatAppearance.BorderSize = 0;
            this.btnKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKegiatan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKegiatan.ForeColor = System.Drawing.Color.LightGray;
            this.btnKegiatan.Image = global::SistemOperasiProyek.Properties.Resources.employee;
            this.btnKegiatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKegiatan.Location = new System.Drawing.Point(0, 195);
            this.btnKegiatan.Name = "btnKegiatan";
            this.btnKegiatan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKegiatan.Size = new System.Drawing.Size(200, 42);
            this.btnKegiatan.TabIndex = 4;
            this.btnKegiatan.Text = "     Kegiatan ";
            this.btnKegiatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKegiatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKegiatan.UseVisualStyleBackColor = true;
            this.btnKegiatan.Click += new System.EventHandler(this.btnKegiatan_Click);
            // 
            // btnProyek
            // 
            this.btnProyek.FlatAppearance.BorderSize = 0;
            this.btnProyek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyek.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyek.ForeColor = System.Drawing.Color.LightGray;
            this.btnProyek.Image = global::SistemOperasiProyek.Properties.Resources.data_analytics;
            this.btnProyek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyek.Location = new System.Drawing.Point(0, 147);
            this.btnProyek.Name = "btnProyek";
            this.btnProyek.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProyek.Size = new System.Drawing.Size(200, 42);
            this.btnProyek.TabIndex = 4;
            this.btnProyek.Text = "     Proyek   ";
            this.btnProyek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProyek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyek.UseVisualStyleBackColor = true;
            this.btnProyek.Click += new System.EventHandler(this.btnProyek_Click);
            // 
            // btnBeranda
            // 
            this.btnBeranda.FlatAppearance.BorderSize = 0;
            this.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeranda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeranda.ForeColor = System.Drawing.Color.LightGray;
            this.btnBeranda.Image = global::SistemOperasiProyek.Properties.Resources.home;
            this.btnBeranda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeranda.Location = new System.Drawing.Point(0, 99);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBeranda.Size = new System.Drawing.Size(200, 42);
            this.btnBeranda.TabIndex = 4;
            this.btnBeranda.Text = "     Beranda";
            this.btnBeranda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeranda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBeranda.UseVisualStyleBackColor = false;
            this.btnBeranda.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.BackColor = System.Drawing.Color.Transparent;
            this.lblJabatan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.ForeColor = System.Drawing.Color.LightGray;
            this.lblJabatan.Location = new System.Drawing.Point(124, 404);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(41, 17);
            this.lblJabatan.TabIndex = 9;
            this.lblJabatan.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.lblTop);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(203, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 675);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_move);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.LightGray;
            this.lblTop.Location = new System.Drawing.Point(22, 21);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(93, 30);
            this.lblTop.TabIndex = 11;
            this.lblTop.Text = "Beranda";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnlContent.Location = new System.Drawing.Point(206, 74);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(734, 601);
            this.pnlContent.TabIndex = 3;
            // 
            // FormTampilanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTampilanAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnTugas;
        private System.Windows.Forms.Button btnKegiatan;
        private System.Windows.Forms.Button btnProyek;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTop;
    }
}

