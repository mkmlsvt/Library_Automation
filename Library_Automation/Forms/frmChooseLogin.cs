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
    public partial class frmChooseLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmChooseLogin()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmLoginAdmin form = new frmLoginAdmin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnPersonalGiris_Click(object sender, EventArgs e)
        {
            frmLoginEmployee form = new frmLoginEmployee();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
