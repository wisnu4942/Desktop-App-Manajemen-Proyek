using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using SistemOperasiProyek.Models.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemOperasiProyek.Views
{
    public partial class FormTambahKegiatan : Form
    {
        private TaskController controller;

        #region Referensi
        public string IDProyek
        {
            get { return cmbIDProyek.Text; }
            set { cmbIDProyek.Text = value; }
        }
        public string IDKegiatan
        {
            get { return txtIDKegiatan.Text; }
            set { txtIDKegiatan.Text = value; }
        }
        public string NamaKegiatan
        {
            get { return txtNamaKegiatan.Text; }
            set { txtNamaKegiatan.Text = value; }
        }
        public DateTime Deadline
        {
            get { return dtDeadline.Value; }
            set { dtDeadline.Value = value; }
        }
        #endregion

        public FormTambahKegiatan()
        {
            InitializeComponent();
            controller = new TaskController(this, cmbIDProyek, new TaskRepository());
            controller.PopulateComboBox();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            controller.HandleButtonClick();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region Focus
        public void FocusID()
        {
            txtIDKegiatan.Focus();
        }
        public void HideForm()
        {
            this.Hide();
        }
        #endregion

    }
}
