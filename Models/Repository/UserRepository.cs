using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public class UserRepository
    {
        #region Registrasi
        public static bool IsUsernameExists(int userId)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM tbl_users WHERE user_id = {userId}";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public static bool IsValidEmail(string email)
        {
            Regex check = new Regex(@"^(?i)[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            bool valid = true;
            valid = check.IsMatch(email);

            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void RegisterUser(User user)
        {
            try
            {
                using (OleDbConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string register = $"INSERT INTO tbl_users VALUES ('{user.UserId}','{user.Password}','{user.Nama}','{user.Email}','{user.Jabatan}')";
                    using (OleDbCommand cmd = new OleDbCommand(register, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
        #endregion

        #region Login
        public static User GetUser(string userId, string password)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_users WHERE user_id = @UserID AND user_password = @Password";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new User
                            {
                                UserId = Convert.ToInt32(dr["user_id"]),
                                Password = dr["user_password"].ToString(),
                                Nama = dr["user_nama"].ToString(),
                                Email = dr["user_email"].ToString(),
                                Jabatan = dr["user_jabatan"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
        #endregion

        #region Beranda
        public int GetCountByJabatan(string jabatan)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM tbl_users WHERE user_jabatan = '{jabatan}'";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        #endregion

        #region Profil
        public User GetUser(string userId)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_users WHERE user_id = @UserID";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new User
                            {
                                UserId = Convert.ToInt32(dr["user_id"]),
                                Nama = dr["user_nama"].ToString(),
                                Email = dr["user_email"].ToString(),
                                Jabatan = dr["user_jabatan"].ToString(),
                                Password = dr["user_password"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
        public void UpdateUser(User user)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tbl_users SET user_nama = @NewName, user_email = @NewEmail, user_jabatan = @NewJabatan, user_password = @NewPassword WHERE user_id = @UserID";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewName", user.Nama);
                    cmd.Parameters.AddWithValue("@NewEmail", user.Email);
                    cmd.Parameters.AddWithValue("@NewJabatan", user.Jabatan);
                    cmd.Parameters.AddWithValue("@NewPassword", user.Password);
                    cmd.Parameters.AddWithValue("@UserID", user.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public User GetJobDescription(string jabatan)
        {
            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT des_keterangan FROM tbl_descriptions WHERE des_jabatan = @Jabatan";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Jabatan", jabatan);

                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new User
                            {
                                Keterangan = dr["des_keterangan"].ToString()
                            };
                        }
                    }
                }
            }
            return new User { Keterangan = "Job description not available." };
        }
        #endregion

        //public User GetUser2(string jabatan)
        //{
        //    using (OleDbConnection conn = DbConnection.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM tbl_users WHERE user_jabatan = @Jabatan";
        //        using (OleDbCommand cmd = new OleDbCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@Jabatan", jabatan);

        //            using (OleDbDataReader dr = cmd.ExecuteReader())
        //            {
        //                if (dr.Read())
        //                {
        //                    return new User
        //                    {
        //                        UserId = Convert.ToInt32(dr["user_id"]),
        //                        Nama = dr["user_nama"].ToString(),
        //                        Email = dr["user_email"].ToString(),
        //                        Jabatan = dr["user_jabatan"].ToString(),
        //                        Password = dr["user_password"].ToString()
        //                    };
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}
        public List<User> GetUserKaryawan(string jabatanFilter = null)
        {
            List<User> userAdd = new List<User>();

            using (OleDbConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tbl_users";

                if (!string.IsNullOrEmpty(jabatanFilter))
                {
                    query += $" WHERE user_jabatan = '{jabatanFilter}'";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User user = new User
                        {
                            UserId = Convert.ToInt32(dr["user_id"]),
                            Nama = dr["user_nama"].ToString(),
                            Email = dr["user_email"].ToString(),
                            Jabatan = dr["user_jabatan"].ToString(),
                            Password = dr["user_password"].ToString()
                        };
                        userAdd.Add(user);
                    }
                }
            }

            return userAdd;
        }
    }
}
