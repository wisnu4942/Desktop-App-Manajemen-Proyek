using SistemOperasiProyek.Controllers;
using SistemOperasiProyek.Models;
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
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

        );
        public string IDUserControl
        {
            get => lblID.Text;
            set => lblID.Text = value;
        }
        public string NamaUserControl
        {
            get => lblNama.Text;
            set => lblNama.Text = value;
        }
        public string StatusUserControl
        {
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }
        public bool lebihBanyak
        {
            get { return btnLebihBanyak.Visible; }
            set { btnLebihBanyak.Visible = value; }        
        }

        public UserControl()
        {
            InitializeComponent();
            LebihBanyakUserControl();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }       
        public void LebihBanyakUserControl()
        {
            btnLebihBanyak.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        }
    }
}
