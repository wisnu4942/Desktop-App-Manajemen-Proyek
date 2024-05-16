using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek.Views
{
    public partial class FormKaryawan : Form
    {
        #region
        public string Manajer
        {
            get { return lblJumlahManajer.Text; }
            set { lblJumlahManajer.Text = value; }
        }
        public string SiteEngineer
        {
            get { return lblJumlahSiteE.Text; }
            set { lblJumlahSiteE.Text = value; }
        }
        public string StructureEngineer
        {
            get { return lblJumlahStructureE.Text; }
            set { lblJumlahStructureE.Text = value; }
        }
        public string Architect
        {
            get { return lblJumlahArchitectE.Text; }
            set { lblJumlahArchitectE.Text = value; }
        }
        public string QC
        {
            get { return lblJumlahQC.Text; }
            set { lblJumlahQC.Text = value; }
        }
        public string AdminUmum
        {
            get { return lblJumlahAU.Text; }
            set { lblJumlahAU.Text = value; }
        }
        public string Chief
        {
            get { return lblJumlahCI.Text; }
            set { lblJumlahCI.Text = value; }
        }
        public string Supervisor
        {
            get { return lblJumlahSP.Text; }
            set { lblJumlahSP.Text = value; }
        }
        public string Surveyor
        {
            get { return lblJumlahSV.Text; }
            set { lblJumlahSV.Text = value; }
        }
        #endregion

        private KaryawanController _controller;
        private UserRepository userRepository;
        public FormKaryawan()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            _controller = new KaryawanController(this, userRepository);
            _controller.UpdateBerandaLabels();
        }

        public void GenerateDynamicUserControl(string projectStatusFilter = null)
        {
            List<User> users = userRepository.GetUserKaryawan(projectStatusFilter);

            flowLayoutPanel1.Controls.Clear();

            foreach (User user in users)
            {
                UserControl item = new UserControl
                {
                    IDUserControl = user.UserId.ToString(),
                    NamaUserControl = user.Nama,
                    StatusUserControl = user.Jabatan,
                    lebihBanyak = false
                };

                flowLayoutPanel1.Controls.Add(item);
            }
        }
        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Project Manager");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Site Engineer");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Structure Engineering");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Architect Engineering");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Quality Control");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Administrasi Umum");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Chief Inspector");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Supervisor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl("Surveyor");
        }
    }
}
