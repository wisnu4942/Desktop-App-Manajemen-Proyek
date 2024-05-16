using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using SistemOperasiProyek.Models.Repository;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemOperasiProyek.Views
{
    public partial class FormProfil : Form
    {
        private readonly UserRepository profilrepository;
        private ProfilController profilController;

        #region Referensi TextBox Agar Bisa Dipanggil di Form lain
        public string Jabatan
        {
            get { return lblJabatan.Text; }
            set { lblJabatan.Text = value; }
        }
        public string JabatanUpdate
        {
            get { return cmbJabatan.Text; }
            set { cmbJabatan.Text = value; }
        }
        public string ID
        {
            get { return txtUserID.Text; }
            set { txtUserID.Text = value; }
        }
        public string Nama
        {
            get { return txtNama.Text; }
            set { txtNama.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string ConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }
        #endregion
       
        public FormProfil()
        {
            InitializeComponent();
            profilrepository = new UserRepository();
            profilController = new ProfilController(this);
            hidepanel();
        }
        public void FocusPassword()
        {
            txtPassword.Focus();
        }
        private void hidepanel()
        {
            panel2.Visible = false;
        }

        private void showpanel()
        {
            panel2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showpanel();
            txtNama.Enabled = true;
            txtUserID.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidepanel();
            txtNama.Enabled = false;
            txtUserID.Enabled = false;
            txtEmail.Enabled = false;
        }
        public void SetUpdateProfil(string IDlabel)
        {      
            User user = profilController.GetUser(IDlabel);

            if (user != null)
            {
                txtUserID.Text = user.UserId.ToString();
                txtNama.Text = user.Nama;
                txtEmail.Text = user.Email;
                lblJabatan.Text = user.Jabatan;
            }
            else
            {
                MessageBox.Show("User tidak ditemukan", "Error");
            } 
            
            User jobDescription = profilController.GetJobDescription(lblJabatan.Text);
            lblDeskripsi.Text = jobDescription.Keterangan;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            profilController.UpdateUser();    
            hidepanel();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
