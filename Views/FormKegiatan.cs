using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
using SistemOperasiProyek.Models.Repository;
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
    public partial class FormKegiatan : Form
    {
        private readonly TaskController _taskController;
        private readonly TaskRepository _taskRepository;

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
        public string KegiatanID
        {
            get { return lblIDKegiatan.Text; }
            set { lblIDKegiatan.Text = value; }
        }
        public string NamaKegiatan
        {
            get { return lblNamaKegiatan.Text; }
            set { lblNamaKegiatan.Text = value; }
        }
        public string Deadline
        {
            get { return lblDeadline.Text; }
            set { lblDeadline.Text = value; }
        }
        public string StatusKegiatan
        {
            get { return lblStatusKegiatan.Text; }
            set { lblStatusKegiatan.Text = value; }
        }
        public string Petugas
        {
            get { return lblPetugas.Text; }
            set { lblPetugas.Text = value; }
        }
        #endregion

        public FormKegiatan()
        {
            InitializeComponent();
            _taskRepository = new TaskRepository();
            _taskController = new TaskController(this, _taskRepository);
            GenerateDynamicUserControl();
            hidepanel();
        }
        public void GenerateDynamicUserControl(string taskStatusFilter = null)
        {
            List<Models.Task> tasks = _taskRepository.GetTasks(taskStatusFilter);

            flowLayoutPanel1.Controls.Clear();

            foreach (Models.Task task in tasks)
            {
                UserControl item = new UserControl
                {
                    IDUserControl = task.TaskId.ToString(),
                    NamaUserControl = task.TaskNama,
                    StatusUserControl = task.TaskStatus
                };

                flowLayoutPanel1.Controls.Add(item);
                item.Click += new System.EventHandler(this.UserControl_Click);
            }
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            UserControl obj = (UserControl)sender;
            string taskId = obj.IDUserControl;
            _taskController.ShowProjectDetails(taskId);
        }
        private void btnBerlangsung_Click(object sender, EventArgs e)
        {
            _taskController.ShowProjects("Sedang Berlangsung");
        }
        private void btnTersedia_Click(object sender, EventArgs e)
        {
            _taskController.ShowProjects("Tersedia");
        }
        private void btnSelesai_Click(object sender, EventArgs e)
        {
            _taskController.ShowProjects("Selesai");
        }

        public void showpanel()
        {
            panel1.Visible = true;
        }
        public void hidepanel()
        {
            panel1.Visible = false;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string userId = ID;
            string taskId = KegiatanID;

            _taskController.UpdateProject(userId, taskId);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string taskIdToDelete = KegiatanID;
            _taskController.DeleteProject(taskIdToDelete);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new FormTambahKegiatan().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
