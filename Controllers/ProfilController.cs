using SistemOperasiProyek.Models;
using SistemOperasiProyek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek.Controllers
{
    public class ProfilController
    {
        private UserRepository userRepository = new UserRepository();
        private FormProfil _formP;

        public ProfilController(FormProfil form)
        {
            _formP = form;
        }
        public User GetUser(string userId)
        {
            return userRepository.GetUser(userId);
        }

        public void UpdateUser()
        {
            if (_formP.Password == "" || _formP.ConfirmPassword == "" || _formP.Email == "" || _formP.Nama == "" || _formP.JabatanUpdate == "" || _formP.Nama == "")
            {
                MessageBox.Show("Terdapat kolom yang masih kosong", "Update Profil Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!UserRepository.IsValidEmail(_formP.Email))
            {
                MessageBox.Show("Format email salah, harap masukan yang benar (@gmail.com)", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _formP.Email = "";
            }
            else if (_formP.Password == _formP.ConfirmPassword)
            {
                User user = new User
                {
                    UserId = int.Parse(_formP.ID),
                    Nama = _formP.Nama,
                    Email = _formP.Email,
                    Jabatan = _formP.JabatanUpdate,
                    Password = _formP.Password

                };
                userRepository.UpdateUser(user);
                MessageBox.Show("Akun anda berhasil di update", "Update Profil berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password tidak cocok, Silahkan diisi kembali", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _formP.Password = "";
                _formP.ConfirmPassword = "";
               
            }
        }
        public User GetJobDescription(string jabatan)
        {
            return userRepository.GetJobDescription(jabatan);
        }
    }
}
