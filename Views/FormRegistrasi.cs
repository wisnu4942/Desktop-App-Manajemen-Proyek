using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using SistemOperasiProyek.Controllers;

namespace SistemOperasiProyek
{
    public partial class FormRegistrasi : Form
    {
        public Point mouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

        );
        private RegistrationController _userController;

        #region Referensi TextBox Agar Bisa Dipanggil di Form lain
        public string UserID
        {
            get { return txtUserID.Text; }
            set { txtUserID.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Jabatan
        {
            get { return cmbJabatan.Text; }
            set { cmbJabatan.Text = value; }
        }
        public string Nama
        {
            get { return txtNama.Text; }
            set { txtNama.Text = value; }
        }

        public string ConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }
        public bool ShowPasswordChecked
        {
            get { return checkbxShowPassword.Checked; }
            set { checkbxShowPassword.Checked = value; }
        }
        public char PasswordCharacter
        {
            get { return txtPassword.PasswordChar; }
            set { txtPassword.PasswordChar = value; }
        }
        public char ConfirmPasswordCharacter
        {
            get { return txtConfirmPassword.PasswordChar; }
            set { txtConfirmPassword.PasswordChar = value; }
        }
        #endregion

        public FormRegistrasi()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _userController = new RegistrationController(this);
        }

        #region User Klik
        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            _userController.sembunyikanPassword();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            _userController.RegisterUser();
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion

        #region Focus & Clear
        public void ClearFields()
        {
            txtNama.Text = "";
            txtEmail.Text = "";
            cmbJabatan.Text = "";
            txtUserID.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        public void FocusPassword()
        {
            txtPassword.Focus();
        }
        public void FocusNama()
        {
            txtNama.Focus();
        }
        #endregion

        #region Minimize Maximize Close
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void SetFormRegion()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            SetFormRegion();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);

                // Batasi perpindahan form sesuai kebutuhan
                if (WindowState != FormWindowState.Maximized)
                {
                    Location = mousePose;
                }
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);

                // Batasi perpindahan form sesuai kebutuhan
                if (WindowState != FormWindowState.Maximized)
                {
                    Location = mousePose;
                }
            }
        }

       
    }
}
