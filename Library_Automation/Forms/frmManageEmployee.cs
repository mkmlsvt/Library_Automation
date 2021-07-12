using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Library_Automation.Business;
using Library_Automation.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace Library_Automation.Forms
{
    public partial class frmManageEmployee : Form
    {
        int silenecekId;
        int duzenlenecekId;
        Calisan calisan;
        CalisanBusiness calisanBusiness;
        public frmManageEmployee()
        {
            calisanBusiness = new CalisanBusiness();
            InitializeComponent();           
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (ControlsIsNull())
            {
                UpdateEmployee();
                FillGridview();
            }
            else
            {
                MessageBox.Show("boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmManageEmployee_Load(object sender, EventArgs e)
        {
            FillGridview();
            gridView1.OptionsBehavior.Editable = false;
            btnDuzenle.Enabled = false;
        }
        private List<CalisanListDTO> GetAllCalisanDTO()
        {
            var calisanlar = calisanBusiness.GetAllCalisanListDTO();
            return calisanlar;
        }
        private void FillGridview()
        {
            
            gridControl1.DataSource = GetAllCalisanDTO();
            gridView1.Columns["CinsiyetE"].Visible = false;
        }
        private void AddEmployee()
        {
            calisan = new Calisan();
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Username = txtUsername.Text;
            calisan.Yas = int.Parse(txtYas.Text);
            calisan.Password = txtParola.Text;
            if(cmbCinsiyet.SelectedItem.ToString()=="Erkek")
            {
                calisan.CinsiyetE = true;
            }
            else if(cmbCinsiyet.SelectedItem.ToString() == "Kadin")
            {
                calisan.CinsiyetE = false;
            }
            calisanBusiness.AddEmployee(calisan);

        }
        private bool ControlsIsNull()
        {
            if(string.IsNullOrEmpty(txtAd.Text)|| string.IsNullOrEmpty(txtParola.Text)||string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtYas.Text)||cmbCinsiyet.SelectedIndex<0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(ControlsIsNull())
            {
                AddEmployee();
                FillGridview();
            }
            else
            {
                MessageBox.Show("boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FillControlsForUpdate();
            //Calisan calisan = new Calisan();
            //calisan.Ad=gridView1.GetFocusedRowCellValue("Ad").ToString();
            //calisan.Soyad = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            //if(gridView1.GetFocusedRowCellValue("Cinsiyet").ToString() == "Erkek")
            //{
            //    calisan.CinsiyetE = true;
            //}
            //else if(gridView1.GetFocusedRowCellValue("Cinsiyet").ToString() == "Kadın")

        }
        private void FillControlsForUpdate()
        {
            duzenlenecekId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            cmbCinsiyet.SelectedItem = gridView1.GetFocusedRowCellValue("Cinsiyet").ToString();
            txtYas.Text = gridView1.GetFocusedRowCellValue("Yas").ToString();
            txtUsername.Text = gridView1.GetFocusedRowCellValue("Username").ToString();
            txtParola.Text = gridView1.GetFocusedRowCellValue("Password").ToString();
            btnDuzenle.Enabled = true;
            txtDuzenlencekId.Text = duzenlenecekId.ToString();
        }
        private void UpdateEmployee()
        {
            calisan = new Calisan();
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Password = txtParola.Text;
            calisan.Username = txtUsername.Text;
            calisan.Yas = int.Parse(txtYas.Text);
            if (cmbCinsiyet.SelectedItem.ToString() == "Erkek")
            {
                calisan.CinsiyetE = true;
            }
            else if(cmbCinsiyet.SelectedItem.ToString() == "Kadın")
            {
                calisan.CinsiyetE = false;
            }
             calisanBusiness.UpdateEmployee(duzenlenecekId, calisan);
        }
        private void DeleteEmployee()
        {
            silenecekId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            calisanBusiness.DeleteEmployee(silenecekId);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(gridView1.GetFocusedRowCellValue("Ad").ToString() + " Adlı çalışanı Silmek istedğinizden emin misiniz", "Emin misiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteEmployee();
                FillGridview();
                
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düzenlemek için tablodan düzenleyeceğiniz kişiye çift tıkladıktan sonra soldaki textboxlara yeni" +
                "değerleri girin ve düzenle butonuna basın , Silmek için tablodan seçtiğiniz kişiye tıklayıp daha sonra sil butonuna" +
                "basabilirsiniz...", "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


