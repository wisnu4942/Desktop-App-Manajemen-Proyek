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
    public class ProjectController
    {
        private FormProyek _formP;
        private FormTugas _formT;
        private FormTambahProyek _formTP;
        private ProjectRepository _projectRepository;

        public ProjectController(FormProyek form, ProjectRepository repository)
        {
            _formP = form;
            _projectRepository = repository;
        }
        public ProjectController(FormTugas form, ProjectRepository repository)
        {
            _formT = form;
            _projectRepository = repository;
        }
        public ProjectController(FormTambahProyek view, ProjectRepository projectRepository)
        {
            _formTP = view;
            _projectRepository = projectRepository;
        }
        public void ShowProjects(string projectStatusFilter = null)
        {
            _formP.GenerateDynamicUserControl(projectStatusFilter);
        }

        public void ShowProjectDetails(string projectId)
        {
            DataTable data = _projectRepository.GetProjectData(projectId);

            if (data.Rows.Count > 0)
            {
                _formP.ProjectID = data.Rows[0]["project_id"].ToString();
                _formP.NamaProyek = data.Rows[0]["project_nama"].ToString();
                _formP.DeskripsiProyek = data.Rows[0]["project_deskripsi"].ToString();
                _formP.TanggalMulai = data.Rows[0]["project_waktu_mulai"].ToString();
                _formP.TanggalSelesai = data.Rows[0]["project_waktu_selesai"].ToString();
                _formP.Anggaran = data.Rows[0]["project_anggaran"].ToString();
                _formP.StatusProject = data.Rows[0]["project_status"].ToString();
                _formP.Petugas = data.Rows[0]["user_id"].ToString();
            }

            if (_formP.StatusProject == "Sedang Berlangsung" || _formP.StatusProject == "Selesai")
            {
                _formP.Panel3.Visible = false;
            }
            else
            {
                _formP.Panel3.Visible = true;
            }

            _formP.showpanel();
        }
        public void ShowProjectDetails2(string projectId)
        {
            DataTable data = _projectRepository.GetProjectData(projectId);

            if (data.Rows.Count > 0)
            {
                _formT.ProjectID2 = data.Rows[0]["project_id"].ToString();
                _formT.NamaProject = data.Rows[0]["project_nama"].ToString();
            }

            _formT.showpanel2();
        }
        public void UpdateProject(string userId, string projectId)
        {
            bool success = _projectRepository.UpdateProject(userId, projectId);

            if (success)
            {
                MessageBox.Show("Project Berhasil di Ambil!");
                _formP.ID = "";
            }
            else
            {
                MessageBox.Show("Project gagal di Ambil.");
                _formP.ID = "";
            }

            _formP.hidepanel();
        }
        public void UpdateProject2(string projectId)
        {
            bool success = _projectRepository.UpdateProject2(projectId);

            if (success)
            {
                MessageBox.Show("Project Berhasil di Selesaikan!");
            }
            else
            {
                MessageBox.Show("Project gagal di Selesaikan.");
            }

            _formT.hidepanel2();
        }
        public void DeleteProject(string projectId)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin menghapus project ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _projectRepository.DeleteProject(projectId);

                if (success)
                {
                    ShowProjects();
                    MessageBox.Show("Project berhasil di Hapus!");
                }
                else
                {
                    MessageBox.Show("Project gagal di Hapus.");
                }
            }
        }

        #region Tambah Project
        public void HandleButtonClick()
        {
            try
            {
                Project project = new Project
                {
                    ProjectId = int.Parse(_formTP.IDProyek),
                    ProjectNama = _formTP.NamaProyek,
                    ProjectLokasi = _formTP.Lokasi,
                    ProjectWaktuMulai = _formTP.WaktuMulai,
                    ProjectWaktuSelesai = _formTP.WaktuSelesai,
                    ProjectStatus = _formTP.Status,
                    ProjectDeskripsi = _formTP.DeskripsiProyek,
                    ProjectAnggaran = int.Parse(_formTP.Anggaran)
                };

                if (_formTP.IDProyek == "" || _formTP.NamaProyek == "" || _formTP.Lokasi == "" || _formTP.Status == "" || _formTP.DeskripsiProyek == "")
                {
                    MessageBox.Show("Terdapat kolom yang masih kosong", "Tambah Proyek Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_projectRepository.ProjectIdExists(project.ProjectId))
                {
                    MessageBox.Show("Project ID telah ada. Silahkan pilih ID lain.");
                    _formTP.IDProyek = "";
                    _formTP.FocusID();
                }
                else
                {
                    bool success = _projectRepository.InsertProject(project);

                    if (success)
                    {
                        MessageBox.Show("Project berhasil ditambahakan!");
                        _formTP.HideForm();
                    }
                    else
                    {
                        MessageBox.Show("Project gagal ditambahakan.");
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
