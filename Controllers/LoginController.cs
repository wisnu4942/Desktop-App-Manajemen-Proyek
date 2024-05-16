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
    public class LoginController
    {
        private FormLogin _formL;

        public LoginController(FormLogin form)
        {
            _formL = form;
        }

        public void AuthenticateUser()
        {
            try
            {
                if (_formL.UserID == "" || _formL.Password == "")
                {
                    MessageBox.Show("UserID dan Password kosong", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User authenticatedUser = UserRepository.GetUser(_formL.UserID, _formL.Password);
                    
                    if (authenticatedUser != null)
                    {
                        FormTampilanAwal formTA = new FormTampilanAwal();
                        formTA.UserInfo(authenticatedUser);

                        formTA.Show();
                        _formL.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User ID atau Password Salah, Silahkan Coba Kembali", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _formL.UserID = "";
                        _formL.Password = "";
                        _formL.FocusNama();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sembunyikanPassword()
        {
            _formL.PasswordCharacter = _formL.ShowPasswordChecked ? '\0' : '*';
        }
    }
}
