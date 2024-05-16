using SistemOperasiProyek.Models;
using SistemOperasiProyek.Models.Repository;
using SistemOperasiProyek.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek.Controllers
{
    public class TaskController
    {
        private FormKegiatan _formK;
        private FormTambahKegiatan _formTK;
        private FormTugas _formT;
        private ComboBox _comboBox;
        private TaskRepository _taskRepository;

        public TaskController(FormKegiatan form, TaskRepository repository)
        {
            _formK = form;
            _taskRepository = repository;
        }
        public TaskController(FormTugas form, TaskRepository repository)
        {
            _formT = form;
            _taskRepository = repository;
        }
        public TaskController(FormTambahKegiatan form, ComboBox comboBox, TaskRepository repository)
        {
            _formTK = form;
            _comboBox = comboBox;
            _taskRepository = repository;
        }
        public void PopulateComboBox()
        {
            var projects = _taskRepository.GetProjects();

            foreach (var project in projects)
            {
                _comboBox.Items.Add(project.ProjectId);
            }
        }
        public void ShowProjects(string taskStatusFilter = null)
        {
            _formK.GenerateDynamicUserControl(taskStatusFilter);
        }

        public void ShowProjectDetails(string taskId)
        {
            DataTable data = _taskRepository.GetTaskData(taskId);

            if (data.Rows.Count > 0)
            {
                _formK.ProjectID = data.Rows[0]["project_id"].ToString();
                _formK.NamaKegiatan = data.Rows[0]["task_nama"].ToString();
                _formK.Deadline = data.Rows[0]["task_tenggat_waktu"].ToString();
                _formK.KegiatanID = data.Rows[0]["task_id"].ToString();
                _formK.StatusKegiatan = data.Rows[0]["task_status"].ToString();
                _formK.Petugas = data.Rows[0]["user_id"].ToString();
            }

            if (_formK.StatusKegiatan == "Sedang Berlangsung" || _formK.StatusKegiatan == "Selesai")
            {
                _formK.Panel3.Visible = false;
            }
            else
            {
                _formK.Panel3.Visible = true;
            }

            _formK.showpanel();
        }
        public void ShowProjectDetails2(string taskId)
        {
            DataTable data = _taskRepository.GetTaskData(taskId);

            if (data.Rows.Count > 0)
            {
                _formT.ProjectID = data.Rows[0]["project_id"].ToString();
                _formT.NamaKegiatan = data.Rows[0]["task_nama"].ToString();
                _formT.KegiatanID = data.Rows[0]["task_id"].ToString();
            }

            _formT.showpanel();
        }
        public void UpdateProject(string userId, string taskId)
        {
            bool success = _taskRepository.UpdateProject(userId, taskId);

            if (success)
            {
                MessageBox.Show("Kegiatan Berhasil di Ambil!");
                _formK.ID = "";
            }
            else
            {
                MessageBox.Show("Kegiatan gagal di Ambil.");
                _formK.ID = "";
            }

            _formK.hidepanel();
        }
        public void UpdateProject2(string taskId)
        {
            bool success = _taskRepository.UpdateProject2(taskId);

            if (success)
            {
                MessageBox.Show("Kegiatan Berhasil di Selesaikan!");
            }
            else
            {
                MessageBox.Show("Kegiatan Gagal di Selesaikan.");
            }

            _formT.hidepanel();
        }
        public void DeleteProject(string taskId)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin menghapus Tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _taskRepository.DeleteProject(taskId);

                if (success)
                {
                    ShowProjects();
                    MessageBox.Show("Kegiatan berhasil di Hapus!");
                }
                else
                {
                    MessageBox.Show("Kegiatan gagal di Hapus.");
                }
            }
        }
        #region Tambah Project
        public void HandleButtonClick()
        {
            try
            {
                Models.Task task = new Models.Task
                {
                    TaskId = int.Parse(_formTK.IDKegiatan),
                    TaskNama = _formTK.NamaKegiatan,
                    ProjectId = int.Parse(_formTK.IDProyek),
                    TaskDeadline = _formTK.Deadline,
                };

                if (_formTK.IDProyek == "" || _formTK.NamaKegiatan == "" || _formTK.IDKegiatan == "")
                {
                    MessageBox.Show("Terdapat kolom yang masih kosong", "Tambah Task Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_taskRepository.TaskIdExists(task.TaskId))
                {
                    MessageBox.Show("ID Kegiatan telah ada. Silahkan pilih ID lain.");
                    _formTK.IDKegiatan = "";
                    _formTK.FocusID();
                }
                else
                {
                    bool success = _taskRepository.InsertProject(task);

                    if (success)
                    {
                        MessageBox.Show("Kegiatan berhasil ditamabahkan!");
                        _formTK.HideForm();
                    }
                    else
                    {
                        MessageBox.Show("Kegiatan gagal ditamabahkan.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        #endregion
    }
}
