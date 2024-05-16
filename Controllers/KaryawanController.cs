using SistemOperasiProyek.Models.Repository;
using SistemOperasiProyek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemOperasiProyek.Views;
using System.Data;

namespace SistemOperasiProyek.Controllers
{
    public class KaryawanController
    {
        private FormKaryawan _formK;
        private UserRepository _userRepository;
        public KaryawanController(FormKaryawan form, UserRepository userRepository)
        {
            _formK = form;
            _userRepository = userRepository;
        }
        #region Beranda
        public void UpdateBerandaLabels()
        {
            try
            {
                _formK.Manajer = _userRepository.GetCountByJabatan("Project Manager").ToString();
                _formK.SiteEngineer = _userRepository.GetCountByJabatan("Site Engineer").ToString();
                _formK.StructureEngineer = _userRepository.GetCountByJabatan("Structure Engineering").ToString();
                _formK.Architect = _userRepository.GetCountByJabatan("Architect Engineering").ToString();
                _formK.QC = _userRepository.GetCountByJabatan("Quality Control").ToString();
                _formK.AdminUmum = _userRepository.GetCountByJabatan("Administrasi Umum").ToString();
                _formK.Chief = _userRepository.GetCountByJabatan("Chief Inspector").ToString();
                _formK.Supervisor = _userRepository.GetCountByJabatan("Supervisor").ToString();
                _formK.Surveyor = _userRepository.GetCountByJabatan("Surveyor").ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
