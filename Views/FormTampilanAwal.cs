using SistemOperasiProyek;
using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using SistemOperasiProyek.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek
{
    public partial class FormTampilanAwal : Form
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

        private DashboardController _dashboardController;

        #region Button Color
        public string lblTA
        {
            get { return lblTop.Text; }
            set { lblTop.Text = value; }
        }
        public string UserID
        {
            get { return lblUserID.Text; }
            set { lblUserID.Text = value; }
        }
        public Button Beranda
        {
            get { return btnBeranda; }
            set { btnBeranda = value; }
        }
        public Button Proyek
        {
            get { return btnProyek; }
            set { btnProyek = value; }
        }
        public Button Kegiatan
        {
            get { return btnKegiatan; }
            set { btnKegiatan = value; }
        }
        public Button Tugas
        {
            get { return btnTugas; }
            set { btnTugas = value; }
        }
        public Button Karyawan
        {
            get { return btnKaryawan; }
            set { btnKaryawan = value; }
        }
        public Button Profil
        {
            get { return btnProfil; }
            set { btnProfil = value; }
        }
        public Panel Navigasi
        {
            get { return pnlNavIndicator; }
            set { pnlNavIndicator = value; }
        }
        public Panel Content
        {
            get { return pnlContent; }
            set { pnlContent = value; }
        }
        #endregion

        public FormTampilanAwal()
        {
            InitializeComponent();
            this.Resize += formResize;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _dashboardController = new DashboardController(this);
            _dashboardController.ShowBeranda();
        }
        private void formResize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region User Klik
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            _dashboardController.ShowBeranda();
        }
        private void btnProyek_Click(object sender, EventArgs e)
        {
            if (lblJabatan.Text == "Project Manager" || lblJabatan.Text == "Jabatan")
            {
                _dashboardController.ShowProyek();
            }
            else
            {
                _dashboardController.TidakWewenang();
            }
        }
        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            _dashboardController.ShowKegiatan();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
        private void btnTugas_Click(object sender, EventArgs e)
        {
            _dashboardController.ShowTugas();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            _dashboardController.ShowKaryawan();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            _dashboardController.ShowProfil();
        }
        #endregion

        public void UserInfo(User user)
        {
            UserID = user.UserId.ToString();
            lblJabatan.Text = user.Jabatan;
        }
        
        #region Minimize Maximize Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
