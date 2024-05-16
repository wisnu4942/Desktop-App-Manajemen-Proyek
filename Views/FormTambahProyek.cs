using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek
{
    public partial class FormTambahProyek : Form
    {
        private ProjectController controller;

        #region Referensi
        public string IDProyek
        {
            get { return txtIDProyek.Text; }
            set { txtIDProyek.Text = value; }
        }

        public string NamaProyek
        {
            get { return txtNamaProyek.Text; }
            set { txtNamaProyek.Text = value; }
        }

        public string Lokasi
        {
            get { return txtLokasi.Text; }
            set { txtLokasi.Text = value; }
        }

        public DateTime WaktuMulai
        {
            get { return dtMulai.Value; }
            set { dtMulai.Value = value; }
        }

        public DateTime WaktuSelesai
        {
            get { return dtSelesai.Value; }
            set { dtSelesai.Value = value; }
        }

        public string Status
        {
            get { return cmbStatus.Text; }
            set { cmbStatus.Text = value; }
        }

        public string DeskripsiProyek
        {
            get { return txtDeskripsiProyek.Text; }
            set { txtDeskripsiProyek.Text = value; }
        }

        public string Anggaran
        {
            get { return txtAnggaran.Text; }
            set { txtAnggaran.Text = value; }
        }

        #endregion
        public FormTambahProyek()
        {
            InitializeComponent();
            controller = new ProjectController(this, new ProjectRepository());
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            controller.HandleButtonClick();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void FocusID()
        {
            txtIDProyek.Focus();
        }
        public void HideForm()
        {
            this.Hide();
        }
    }
}
