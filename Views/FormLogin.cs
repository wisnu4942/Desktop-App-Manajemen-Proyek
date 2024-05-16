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
using SistemOperasiProyek;
using SistemOperasiProyek.Controllers;
using System.Runtime.InteropServices;

namespace SistemOperasiProyek
{
    public partial class FormLogin : Form
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
        private LoginController _loginController;

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
        #endregion

        public FormLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _loginController = new LoginController(this);
        }

        #region User Klik
        private void button1_Click(object sender, EventArgs e)
        {
            _loginController.AuthenticateUser();
        }
        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            _loginController.sembunyikanPassword();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            new FormRegistrasi().Show();
            this.Hide();
        }
        #endregion

        #region FocusBox
        public void FocusNama()
        {
            txtUserID.Focus();
        }
        #endregion

        #region Minimize Maximize Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

                if (WindowState != FormWindowState.Maximized)
                {
                    Location = mousePose;
                }
            }
        }
    }
}
