using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public class ProjectRepository
    {
        #region Proyek
        public List<Project> GetProjects(string projectStatusFilter = null)
        {
            List<Project> projects = new List<Project>();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_projects";

                if (!string.IsNullOrEmpty(projectStatusFilter))
                {
                    query += $" WHERE project_status = '{projectStatusFilter}'";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Project project = new Project
                        {
                            ProjectId = Convert.ToInt32(reader["project_id"]),
                            ProjectNama = reader["project_nama"].ToString(),
                            ProjectDeskripsi = reader["project_deskripsi"].ToString(),
                            ProjectWaktuMulai = Convert.ToDateTime(reader["project_waktu_mulai"]),
                            ProjectWaktuSelesai = Convert.ToDateTime(reader["project_waktu_selesai"]),
                            ProjectAnggaran = Convert.ToInt32(reader["project_anggaran"]),
                            ProjectStatus = reader["project_status"].ToString(),
                            UserId = reader["user_id"].ToString()
                        };
                        projects.Add(project);
                    }
                }
            }

            return projects;
        }
        public DataTable GetProjectData(string projectId)
        {
            DataTable data = new DataTable();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_projects WHERE project_id = @idProyek";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProyek", projectId);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
        public bool UpdateProject(string userId, string projectId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE tbl_projects SET user_id = @UserId, project_status = 'Sedang Berlangsung' WHERE project_id = @ProjectId;";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateProject2(string projectId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE tbl_projects SET project_status = 'Selesai' WHERE project_id = @ProjectId;";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteProject(string projectId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM tbl_projects WHERE project_id = @ProjectId";

                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Beranda
        public static int GetTotalProjects()
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbl_projects";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        #endregion

        #region Tambah Proyek
        public bool ProjectIdExists(int projectId)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM tbl_projects WHERE project_id = @ProjectId";

                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProjectId", projectId);

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool InsertProject(Project project)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    string insertQuery = "INSERT INTO tbl_projects (project_id, project_nama, project_lokasi, project_waktu_mulai, project_waktu_selesai, project_status, project_deskripsi, project_anggaran, user_id) " +
                                         "VALUES (@id, @nama, @lokasi, @mulai, @selesai, @status, @deskripsi, @anggaran, 0)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", project.ProjectId);
                        cmd.Parameters.AddWithValue("@nama", project.ProjectNama);
                        cmd.Parameters.AddWithValue("@lokasi", project.ProjectLokasi);
                        cmd.Parameters.AddWithValue("@mulai", project.ProjectWaktuMulai);
                        cmd.Parameters.AddWithValue("@selesai", project.ProjectWaktuSelesai);
                        cmd.Parameters.AddWithValue("@status", project.ProjectStatus);
                        cmd.Parameters.AddWithValue("@deskripsi", project.ProjectDeskripsi);
                        cmd.Parameters.AddWithValue("@anggaran", project.ProjectAnggaran);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        public List<Project> GetProjectsbyId(int userId, string projectStatusFilter = null)
        {
            List<Project> projects = new List<Project>();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_projects WHERE user_id = @UserId";

                if (!string.IsNullOrEmpty(projectStatusFilter))
                {
                    query += $" AND project_status = @ProjectStatus";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    if (!string.IsNullOrEmpty(projectStatusFilter))
                    {
                        cmd.Parameters.AddWithValue("@ProjectStatus", projectStatusFilter);
                    }
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Project project = new Project
                            {
                                ProjectId = Convert.ToInt32(reader["project_id"]),
                                ProjectNama = reader["project_nama"].ToString(),
                                ProjectDeskripsi = reader["project_deskripsi"].ToString(),
                                ProjectWaktuMulai = Convert.ToDateTime(reader["project_waktu_mulai"]),
                                ProjectWaktuSelesai = Convert.ToDateTime(reader["project_waktu_selesai"]),
                                ProjectAnggaran = Convert.ToInt32(reader["project_anggaran"]),
                                ProjectStatus = reader["project_status"].ToString(),
                                UserId = reader["user_id"].ToString()
                            };
                            projects.Add(project);
                        }
                    }
                }

            }

            return projects;
        }
    }
}
