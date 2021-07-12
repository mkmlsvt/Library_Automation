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
    public partial class frmEmployeeHomepage : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmEmployeeHomepage()
        {
            InitializeComponent();
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            frmKıtapIslemlerı form = new frmKıtapIslemlerı();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriVeKirala form = new frmMusteriVeKirala();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
