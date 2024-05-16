using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models.Repository;
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
    public partial class FormTugas : Form
    {
        private readonly TaskController _taskController;
        private readonly TaskRepository _taskRepository;
        private readonly ProjectController _projectController;
        private readonly ProjectRepository _projectRepository;

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

        public string ProjectID2
        {
            get { return label11.Text; }
            set { label11.Text = value; }
        }
        public string NamaProject
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public FormTugas()
        {
            InitializeComponent();
            _taskRepository = new TaskRepository();
            _taskController = new TaskController(this, _taskRepository);
            _projectRepository = new ProjectRepository();
            _projectController = new ProjectController(this, _projectRepository);
            hidepanel();
            hidepanel2();
        }
        public void GenerateDynamicUserControl(int userId, string taskStatusFilter = null)
        {
            List<Models.Task> tasks = _taskRepository.GetTasksByUserId(userId, taskStatusFilter);

            flowLayoutPanel2.Controls.Clear();

            foreach (Models.Task task in tasks)
            {
                UserControl item = new UserControl
                {
                    IDUserControl = task.TaskId.ToString(),
                    NamaUserControl = task.TaskNama,
                    StatusUserControl = task.TaskStatus
                };

                flowLayoutPanel2.Controls.Add(item);
                item.Click += new System.EventHandler(this.UserControl_Click);
            }
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            UserControl obj = (UserControl)sender;
            string taskId = obj.IDUserControl;
            _taskController.ShowProjectDetails2(taskId);
        }
        public void GenerateDynamicUserControl2(int userId, string projectStatusFilter = null)
        {
            List<Project> projects = _projectRepository.GetProjectsbyId(userId, projectStatusFilter);

            flowLayoutPanel2.Controls.Clear();

            foreach (Project project in projects)
            {
                UserControl item = new UserControl
                {
                    IDUserControl = project.ProjectId.ToString(),
                    NamaUserControl = project.ProjectNama,
                    StatusUserControl = project.ProjectStatus
                };

                flowLayoutPanel2.Controls.Add(item);
                item.Click += new System.EventHandler(this.UserControl_Click2);
            }
        }
        private void UserControl_Click2(object sender, EventArgs e)
        {
            UserControl obj = (UserControl)sender;
            string projectId = obj.IDUserControl;
            _projectController.ShowProjectDetails2(projectId);
        }
        public void showpanel()
        {
            panel1.Visible = true;
        }
        public void hidepanel()
        {
            panel1.Visible = false;
        }
        public void showpanel2()
        {
            panel2.Visible = true;
        }
        public void hidepanel2()
        {
            panel2.Visible = false;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {            
            if (txtIDAnda.Text == "")
            {
                MessageBox.Show("Kolom Masih Kosong");
            }
            else
            {
                int userId = int.Parse(txtIDAnda.Text);
                GenerateDynamicUserControl(userId, "Sedang Berlangsung");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string taskId = KegiatanID;

            _taskController.UpdateProject2(taskId);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kolom Masih Kosong");
            }
            else
            {
                int userId = int.Parse(textBox1.Text);
                GenerateDynamicUserControl2(userId, "Sedang Berlangsung");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string projectId = ProjectID2;

            _projectController.UpdateProject2(projectId);
        }
    }
}
