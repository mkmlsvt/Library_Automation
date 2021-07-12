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
    public partial class frmLoginAdmin : Form
    {
        AdminBusiness adminBusiness;
        public frmLoginAdmin()
        {
            InitializeComponent();
            adminBusiness = new AdminBusiness();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (LoginAdmin())
            {
                frmManageEmployee form = new frmManageEmployee();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("giriş başarısız","Tekrar Deneyin",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private bool LoginAdmin()
        {
            Admin admin = new Admin();
            admin.Username = txtUsername.Text;
            admin.Password = txtPassword.Text;
            return adminBusiness.LoginAdmin(admin);          
        }
    }
}
