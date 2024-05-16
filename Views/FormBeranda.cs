using SistemOperasiProyek.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemOperasiProyek
{
    public partial class FormBeranda : Form
    {        
        private DashboardController _dashboardController;
        public FormBeranda()
        {
            InitializeComponent();
            _dashboardController = new DashboardController(this);
            _dashboardController.UpdateBerandaLabels();
        }

        #region Referensi 
        public string Manajer
        {
            get { return lblJumlahManajer.Text; }
            set { lblJumlahManajer.Text = value; }
        }
        public string SiteEngineer
        {
            get { return lblJumlahSiteE.Text; }
            set { lblJumlahSiteE.Text = value; }
        }
        public string StructureEngineer
        {
            get { return lblJumlahStructureE.Text; }
            set { lblJumlahStructureE.Text = value; }
        }
        public string Architect
        {
            get { return lblJumlahArchitectE.Text; }
            set { lblJumlahArchitectE.Text = value; }
        }
        public string QC
        {
            get { return lblJumlahQC.Text; }
            set { lblJumlahQC.Text = value; }
        }
        public string Proyek
        {
            get { return lblJumlahProyek.Text; }
            set { lblJumlahProyek.Text = value; }
        }
        public string Kegiatan
        {
            get { return lblJumlahKegiatan.Text; }
            set { lblJumlahKegiatan.Text = value; }
        }
        #endregion
    }
}
