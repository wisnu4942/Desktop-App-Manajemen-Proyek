using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models.Repository
{
    public class TaskRepository
    {
        #region Kegiatan
        public List<Task> GetTasks(string taskStatusFilter = null)
        {
            List<Task> tasks = new List<Task>();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_tasks";

                if (!string.IsNullOrEmpty(taskStatusFilter))
                {
                    query += $" WHERE task_status = '{taskStatusFilter}'";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Task task = new Task
                        {
                            TaskId = Convert.ToInt32(reader["task_id"]),
                            TaskNama = reader["task_nama"].ToString(),
                            ProjectId = Convert.ToInt32(reader["project_id"]),
                            TaskDeadline = Convert.ToDateTime(reader["task_tenggat_waktu"]),
                            TaskStatus = reader["task_status"].ToString(),
                            UserId = Convert.ToInt32(reader["user_id"])
                        };
                        tasks.Add(task);
                    }
                }
            }
            return tasks;
        }
        public DataTable GetTaskData(string taskId)
        {
            DataTable data = new DataTable();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_tasks WHERE task_id = @idTask";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTask", taskId);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
        public bool UpdateProject(string userId, string taskId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE tbl_tasks SET user_id = @UserId, task_status = 'Sedang Berlangsung' WHERE task_id = @TaskId;";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@TaskId", taskId);

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
        public bool UpdateProject2(string taskId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE tbl_tasks SET task_status = 'Selesai' WHERE task_id = @TaskId;";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskId", taskId);

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
        public bool DeleteProject(string taskId)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM tbl_tasks WHERE task_id = @TaskId";

                    using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskId", taskId);

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
        public static int GetTotalTasks()
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tbl_tasks";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        #endregion

        #region Tambah Kegiatan
        public bool TaskIdExists(int taskId)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM tbl_tasks WHERE task_id = @TaskId";

                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@TaskId", taskId);

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool InsertProject(Task task)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    string insertQuery = "INSERT INTO tbl_tasks (task_id, task_nama, task_tenggat_waktu, task_status, user_id, project_id) " +
                                         "VALUES (@taskId, @nama, @waktu, 'Tersedia', 0, @projectId)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskId", task.TaskId);
                        cmd.Parameters.AddWithValue("@nama", task.TaskNama);
                        cmd.Parameters.AddWithValue("@waktu", task.TaskDeadline);
                        cmd.Parameters.AddWithValue("@projectId", task.ProjectId);

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
        public List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT project_id FROM tbl_projects";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int projectId = Convert.ToInt32(reader["project_id"]);
                            projects.Add(new Project { ProjectId = projectId });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in ProjectRepository: {ex.Message}");
            }
            return projects;
        }

        #endregion

        public List<Task> GetTasksByUserId(int userId, string taskStatusFilter = null)
        {
            List<Task> tasks = new List<Task>();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_tasks WHERE user_id = @UserId";

                if (!string.IsNullOrEmpty(taskStatusFilter))
                {
                    query += " AND task_status = @TaskStatus";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    if (!string.IsNullOrEmpty(taskStatusFilter))
                    {
                        cmd.Parameters.AddWithValue("@TaskStatus", taskStatusFilter);
                    }

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task
                            {
                                TaskId = Convert.ToInt32(reader["task_id"]),
                                TaskNama = reader["task_nama"].ToString(),
                                ProjectId = Convert.ToInt32(reader["project_id"]),
                                TaskDeadline = Convert.ToDateTime(reader["task_tenggat_waktu"]),
                                TaskStatus = reader["task_status"].ToString(),
                                UserId = Convert.ToInt32(reader["user_id"])
                            };
                            tasks.Add(task);
                        }
                    }
                }
            }
            return tasks;
        }

    }
}
