using SistemOperasiProyek.Models;
using SistemOperasiProyek.Models.Repository;
using SistemOperasiProyek.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek.Controllers
{
    public class DashboardController
    {
        private FormTampilanAwal _formTA;
        private FormBeranda _formB;
        private UserRepository _userRepository;

        public DashboardController(FormTampilanAwal form)
        {
            _formTA = form;
        }
        public DashboardController(FormBeranda form)
        {
            _formB = form;
            _userRepository = new UserRepository();
        }

        #region Tampilan Awal
        private void ButtonColorReset(Button activeButton)
        {
            Color activeColor = Color.FromArgb(26, 23, 40);
            Color btnColor = Color.FromArgb(18, 18, 32);

            _formTA.Beranda.BackColor = btnColor;
            _formTA.Proyek.BackColor = btnColor;
            _formTA.Kegiatan.BackColor = btnColor;
            _formTA.Tugas.BackColor = btnColor;
            _formTA.Karyawan.BackColor = btnColor;
            _formTA.Profil.BackColor = btnColor;

            activeButton.BackColor = activeColor;
        }
        public void ShowBeranda()
        {
            _formTA.Navigasi.Height = _formTA.Beranda.Height;
            _formTA.Navigasi.Top = _formTA.Beranda.Top;
            _formTA.Navigasi.Left = _formTA.Beranda.Left;
            ButtonColorReset(_formTA.Beranda);
            _formTA.lblTA = "Beranda";

            _formTA.Content.Controls.Clear();
            FormBeranda FrmDashboard_Vrb = new FormBeranda() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();            
        }
        public void ShowProyek()
        {
            _formTA.Navigasi.Height = _formTA.Proyek.Height;
            _formTA.Navigasi.Top = _formTA.Proyek.Top;
            _formTA.Navigasi.Left = _formTA.Proyek.Left;
            ButtonColorReset(_formTA.Proyek);
            _formTA.lblTA = "Proyek";

            _formTA.Content.Controls.Clear();
            FormProyek FrmProyek_Vrb = new FormProyek() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmProyek_Vrb);
            FrmProyek_Vrb.Show();
        }
        public void ShowKegiatan()
        {
            _formTA.Navigasi.Height = _formTA.Kegiatan.Height;
            _formTA.Navigasi.Top = _formTA.Kegiatan.Top;
            _formTA.Navigasi.Left = _formTA.Kegiatan.Left;
            ButtonColorReset(_formTA.Kegiatan);
            _formTA.lblTA = "Kegiatan";

            _formTA.Content.Controls.Clear();
            FormKegiatan FrmKegiatan_Vrb = new FormKegiatan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmKegiatan_Vrb);
            FrmKegiatan_Vrb.Show();
        }
        public void ShowTugas()
        {
            _formTA.Navigasi.Height = _formTA.Tugas.Height;
            _formTA.Navigasi.Top = _formTA.Tugas.Top;
            _formTA.Navigasi.Left = _formTA.Tugas.Left;
            ButtonColorReset(_formTA.Tugas);
            _formTA.lblTA = "Tugas";

            _formTA.Content.Controls.Clear();
            FormTugas FrmTugas_Vrb = new FormTugas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmTugas_Vrb);
            FrmTugas_Vrb.Show();
        }
        public void ShowKaryawan()
        {
            _formTA.Navigasi.Height = _formTA.Karyawan.Height;
            _formTA.Navigasi.Top = _formTA.Karyawan.Top;
            _formTA.Navigasi.Left = _formTA.Karyawan.Left;
            ButtonColorReset(_formTA.Karyawan);
            _formTA.lblTA = "Karyawan";

            _formTA.Content.Controls.Clear();
            FormKaryawan FrmKaryawan_Vrb = new FormKaryawan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmKaryawan_Vrb);
            FrmKaryawan_Vrb.Show();
        }
        public void ShowProfil()
        {
            _formTA.Navigasi.Height = _formTA.Profil.Height;
            _formTA.Navigasi.Top = _formTA.Profil.Top;
            _formTA.Navigasi.Left = _formTA.Profil.Left;
            ButtonColorReset(_formTA.Profil);
            _formTA.lblTA = "Profil Anda";

            _formTA.Content.Controls.Clear();
            FormProfil FrmProfil_Vrb = new FormProfil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmProfil_Vrb);
            FrmProfil_Vrb.SetUpdateProfil(_formTA.UserID);

            FrmProfil_Vrb.Show();
        }
        public void TidakWewenang()
        {
            _formTA.Navigasi.Height = _formTA.Proyek.Height;
            _formTA.Navigasi.Top = _formTA.Proyek.Top;
            _formTA.Navigasi.Left = _formTA.Proyek.Left;
            ButtonColorReset(_formTA.Proyek);

            _formTA.Content.Controls.Clear();
            FormTidakMemilikiWewenang FrmTMW_Vrb = new FormTidakMemilikiWewenang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            _formTA.Content.Controls.Add(FrmTMW_Vrb);
            FrmTMW_Vrb.Show();
        }
        #endregion

        #region Beranda
        public void UpdateBerandaLabels()
        {
            try
            {
                _formB.Manajer = _userRepository.GetCountByJabatan("Project Manager").ToString();
                _formB.SiteEngineer = _userRepository.GetCountByJabatan("Site Engineer").ToString();
                _formB.StructureEngineer = _userRepository.GetCountByJabatan("Structure Engineering").ToString();
                _formB.Architect = _userRepository.GetCountByJabatan("Architect Engineering").ToString();
                _formB.QC = _userRepository.GetCountByJabatan("Quality Control").ToString();

                _formB.Proyek = ProjectRepository.GetTotalProjects().ToString();
                _formB.Kegiatan = TaskRepository.GetTotalTasks().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
