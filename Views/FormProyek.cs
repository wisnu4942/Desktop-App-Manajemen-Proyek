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
using static WinFormAnimation.AnimationFunctions;

namespace SistemOperasiProyek
{
    public partial class FormProyek : Form
    {
        private readonly ProjectController _projectController;
        private readonly ProjectRepository _projectRepository;

        #region Referensi
        public Panel Panel3
        {
            get { return panel3; }
            set { panel3 = value; }
        }
        public string ID
        {
            get { return txtIDAnda.Text; }
            set { txtIDAnda.Text = value; }
        }
        public string ProjectID
        {
            get { return lblIDProject.Text; }
            set { lblIDProject.Text = value; }
        }
        public string NamaProyek
        {
            get { return lblNamaProyek.Text; }
            set { lblNamaProyek.Text = value; }
        }
        public string DeskripsiProyek
        {
            get { return lblDeskripsi.Text; }
            set { lblDeskripsi.Text = value; }
        }
        public string TanggalMulai
        {
            get { return lblTglMulai.Text; }
            set { lblTglMulai.Text = value; }
        }
        public string TanggalSelesai
        {
            get { return lblTglSelesai.Text; }
            set { lblTglSelesai.Text = value; }
        }
        public string Anggaran
        {
            get { return lblAnggaran.Text; }
            set { lblAnggaran.Text = value; }
        }
        public string StatusProject
        {
            get { return lblStatusProject.Text; }
            set { lblStatusProject.Text = value; }
        }
        public string Petugas
        {
            get { return lblPetugas.Text; }
            set { lblPetugas.Text = value; }
        }
        #endregion

        public FormProyek()
        {
            InitializeComponent();
            _projectRepository = new ProjectRepository();
            _projectController = new ProjectController(this, _projectRepository);
            GenerateDynamicUserControl();
            hidepanel();
        }
        public void GenerateDynamicUserControl(string projectStatusFilter = null)
        {
            List<Project> projects = _projectRepository.GetProjects(projectStatusFilter);

            flowLayoutPanel1.Controls.Clear();

            foreach (Project project in projects)
            {
                UserControl item = new UserControl
                {
                    IDUserControl = project.ProjectId.ToString(),
                    NamaUserControl = project.ProjectNama,
                    StatusUserControl = project.ProjectStatus
                };

                flowLayoutPanel1.Controls.Add(item);
                item.Click += new System.EventHandler(this.UserControl_Click);
            }
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            UserControl obj = (UserControl)sender;
            string projectId = obj.IDUserControl;
            _projectController.ShowProjectDetails(projectId);
        }
        #region User Klik
        private void btnBerlangsung_Click(object sender, EventArgs e)
        {
            _projectController.ShowProjects("Sedang Berlangsung");
        }
        private void btnTersedia_Click(object sender, EventArgs e)
        {
            _projectController.ShowProjects("Tersedia");
        }
        private void btnSelesai_Click(object sender, EventArgs e)
        {
            _projectController.ShowProjects("Selesai");
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            string projectIdToDelete = ProjectID;
            _projectController.DeleteProject(projectIdToDelete);
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            string userId = ID;
            string projectId = ProjectID;

            _projectController.UpdateProject(userId, projectId);
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            new FormTambahProyek().Show();
        }
        #endregion

        public void showpanel()
        {
            panel1.Visible = true;
        }
        public void hidepanel()
        {
            panel1.Visible = false;
        }        
    }
}
