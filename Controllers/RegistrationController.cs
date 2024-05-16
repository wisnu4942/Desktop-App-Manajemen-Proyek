using SistemOperasiProyek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek.Controllers
{
    public class RegistrationController
    {
        private FormRegistrasi _formR;

        public RegistrationController(FormRegistrasi form)
        {
            _formR = form;
        }
        public void RegisterUser()
        {
            try
            {
                if (_formR.UserID == "" || _formR.Password == "" || _formR.ConfirmPassword == "" || _formR.Email == "" || _formR.Jabatan == "")
                {
                    MessageBox.Show("Terdapat kolom yang masih kosong", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UserRepository.IsUsernameExists(Convert.ToInt32(_formR.UserID)))
                {
                    MessageBox.Show("UserID sudah ada, harap masukan yang benar", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _formR.UserID = "";
                    _formR.Password = "";
                    _formR.ConfirmPassword = "";
                    _formR.FocusNama();
                }
                else if (!UserRepository.IsValidEmail(_formR.Email))
                {
                    MessageBox.Show("Format email salah, harap masukan yang benar", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _formR.Email = "";
                }
                else if (_formR.Password == _formR.ConfirmPassword)
                {                    
                    User newUser = new User
                    {
                        UserId = int.Parse(_formR.UserID),
                        Password = _formR.Password,
                        Nama = _formR.Nama,
                        Email = _formR.Email,
                        Jabatan = _formR.Jabatan
                    };

                    UserRepository.RegisterUser(newUser);

                    _formR.Nama = "";
                    _formR.Email = "";
                    _formR.Jabatan = "";
                    _formR.UserID = "";
                    _formR.Password = "";
                    _formR.ConfirmPassword = "";

                    MessageBox.Show("Akun anda berhasil dibuat", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password tidak cocok, Silahkan diisi kembali", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _formR.Password = "";
                    _formR.ConfirmPassword = "";
                    _formR.FocusPassword();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sembunyikanPassword()
        {
            _formR.PasswordCharacter = _formR.ShowPasswordChecked ? '\0' : '*';
            _formR.ConfirmPasswordCharacter = _formR.ShowPasswordChecked ? '\0' : '*';
        }

    }
}
