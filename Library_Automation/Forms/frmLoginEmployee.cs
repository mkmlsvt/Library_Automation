using Library_Automation.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation.Forms
{
    public partial class frmLoginEmployee : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public static int aktifCalisanIdsi;
        CalisanBusiness calisanBusiness;
        public frmLoginEmployee()
        {
            InitializeComponent();
            calisanBusiness = new CalisanBusiness();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(LoginEmployee())
            {
                calisanBusiness.aktifId = aktifCalisanIdsi;
                frmEmployeeHomepage form = new frmEmployeeHomepage();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("basarisiz");
            }
        }
        private bool LoginEmployee()
        {
            Calisan calisan = new Calisan();
            calisan.Password = txtPassword.Text;
            calisan.Username = txtUsername.Text;
            var girisKontrol  = calisanBusiness.LoginEmployee(calisan);
            aktifCalisanIdsi = calisanBusiness.FindId(calisan);
            return girisKontrol;
        }
    }
}
