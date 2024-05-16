namespace SistemOperasiProyek.Views
{
    partial class FormTambahKegiatan
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDKegiatan = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamaKegiatan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIDProyek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(209, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 87;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtDeadline
            // 
            this.dtDeadline.CustomFormat = "dd/MM/yyyy";
            this.dtDeadline.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeadline.Location = new System.Drawing.Point(140, 145);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.Size = new System.Drawing.Size(200, 25);
            this.dtDeadline.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(119, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Rencana Kegiatan";
            // 
            // txtIDKegiatan
            // 
            this.txtIDKegiatan.BackColor = System.Drawing.Color.DarkGray;
            this.txtIDKegiatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDKegiatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKegiatan.Location = new System.Drawing.Point(140, 95);
            this.txtIDKegiatan.Multiline = true;
            this.txtIDKegiatan.Name = "txtIDKegiatan";
            this.txtIDKegiatan.Size = new System.Drawing.Size(200, 20);
            this.txtIDKegiatan.TabIndex = 70;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.White;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClick.Location = new System.Drawing.Point(29, 196);
            this.btnClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(131, 27);
            this.btnClick.TabIndex = 73;
            this.btnClick.Text = "Tambah Kegiatan";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(11, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "ID Kegiatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "ID Proyek";
            // 
            // txtNamaKegiatan
            // 
            this.txtNamaKegiatan.BackColor = System.Drawing.Color.DarkGray;
            this.txtNamaKegiatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaKegiatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKegiatan.Location = new System.Drawing.Point(140, 120);
            this.txtNamaKegiatan.Multiline = true;
            this.txtNamaKegiatan.Name = "txtNamaKegiatan";
            this.txtNamaKegiatan.Size = new System.Drawing.Size(200, 20);
            this.txtNamaKegiatan.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Nama Kegiatan";
            // 
            // cmbIDProyek
            // 
            this.cmbIDProyek.BackColor = System.Drawing.Color.DarkGray;
            this.cmbIDProyek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIDProyek.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDProyek.FormattingEnabled = true;
            this.cmbIDProyek.Location = new System.Drawing.Point(140, 65);
            this.cmbIDProyek.Name = "cmbIDProyek";
            this.cmbIDProyek.Size = new System.Drawing.Size(200, 25);
            this.cmbIDProyek.TabIndex = 90;
            // 
            // FormTambahKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(370, 244);
            this.Controls.Add(this.cmbIDProyek);
            this.Controls.Add(this.txtNamaKegiatan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtDeadline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDKegiatan);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahKegiatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahKegiatan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDKegiatan;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamaKegiatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIDProyek;
    }
}