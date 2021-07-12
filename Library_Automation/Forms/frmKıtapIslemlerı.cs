using DevExpress.XtraEditors.Controls;
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
using System.Windows.Forms;

namespace Library_Automation.Forms
{
    public partial class frmKıtapIslemlerı : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        KitapTurBusiness kitapTurBusiness;
        KitapBusiness kitapBusiness;
        public frmKıtapIslemlerı()
        {
            InitializeComponent();
            kitapTurBusiness = new KitapTurBusiness();
            kitapBusiness = new KitapBusiness();
        }

        private void barbtnKitapEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKitapEkle;
        }

        private void barbtnKitapDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKitapDuzenle;

        }

        private void barbtnKitapSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKitapSil;
        }

        private void barbtnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageStok;
            fillStokCmb();
        }

        private void barbtnAllList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageAllList;
            FillAllKitapGridView();
        }

        private void barbtnMevcutListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageMevcutList;
            FillMevcutAllKitapGridView();
        }

        private void frmKıtapIslemlerı_Load(object sender, EventArgs e)
        {
            FillCombobox();
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            
            if(AddKitapControlsNullControl())
            {
                AddKitap();
            }
            else
            {
                MessageBox.Show("boş alanları doldurun", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<KitapTur> GetAllKitapTur ()
        {
            var kitapTurleri = kitapTurBusiness.GetAllKitapTur();
            return kitapTurleri;
        }
        private void FillCombobox()
        {
            imageCmbTur.Properties.Items.Clear();
            imagecmbDuzenleTur.Properties.Items.Clear();
            imageCmbSilKitapTur.Properties.Items.Clear();
            var kitapTurleri = GetAllKitapTur();
            foreach(var kitapTuru in kitapTurleri)
            {                
                imageCmbTur.Properties.Items.Add(new ImageComboBoxItem(kitapTuru.Ad, kitapTuru.Id));
                imagecmbDuzenleTur.Properties.Items.Add(new ImageComboBoxItem(kitapTuru.Ad, kitapTuru.Id));
                imageCmbSilKitapTur.Properties.Items.Add(new ImageComboBoxItem(kitapTuru.Ad, kitapTuru.Id));

            }
        }
        private void AddKitap()
        {
            Kitap kitap;
            try
            {
                kitap = new Kitap();
                kitap.Ad = txtKitapAdi.Text;
                kitap.BasimTarihi = DateTime.Parse(dateEdit1.SelectedText);
                kitap.BaskiSayisi = int.Parse(txtBaskiSayisi.Text);
                kitap.MusaitStok = 0;
                kitap.Stok = 0;
                kitap.Yazar = txtKitapYazari.Text;
                kitap.TurId = imageCmbTur.SelectedIndex + 1;
                kitapBusiness.AddKitap(kitap);
            }
            catch(Exception e )
            {
                kitap = new Kitap();
                MessageBox.Show("Girdiğiniz değerler yanlış lütfen düzeltiniz", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                dateEdit1.EditValue = DBNull.Value;
            }
            
        }
        private bool AddKitapControlsNullControl()
        {
            if(string.IsNullOrWhiteSpace(txtBaskiSayisi.Text)|| string.IsNullOrWhiteSpace(txtKitapYazari.Text)|| string.IsNullOrWhiteSpace(txtKitapAdi.Text)|| string.IsNullOrWhiteSpace(dateEdit1.SelectedText)||imageCmbTur.SelectedItem==null )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnKitapGetirbyId_Click(object sender, EventArgs e)
        {
            FillUpdateControls();
        }
        private Kitap GetKitapById(int id)
        {
            var kitap = kitapBusiness.GetKitapById(id);
            return kitap;
        }
        private void FillUpdateControls()
        {
            Kitap kitap = new Kitap();
            kitap = GetKitapById(int.Parse(txtGetKitapById.Text));
            if(kitap==null)
            {
                MessageBox.Show("kitap bulanamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtDuzenleKitapAdi.Text = kitap.Ad;
                txtDuzenleYazarAdi.Text = kitap.Yazar;
                txtDuzenleBaskiSayi.Text = kitap.BaskiSayisi.ToString();
                imagecmbDuzenleTur.SelectedIndex = kitap.TurId - 1;
                dateEditDuzenleYil.DateTime = kitap.BasimTarihi;
                btnDuzenleKaydet.Enabled = true;
            }
           
        }

        private void btnDuzenleKaydet_Click(object sender, EventArgs e)
        {
            if(UpdateKitapControlsNullControl())
            {
                UpdateKitap();
            }
            else
            {
                MessageBox.Show("boş alanları doldurun4", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateKitap()
        {
            Kitap kitap = new Kitap();
            kitap.Ad = txtDuzenleKitapAdi.Text;
            kitap.BaskiSayisi = int.Parse(txtDuzenleBaskiSayi.Text);
            kitap.Yazar = txtDuzenleYazarAdi.Text;
            kitap.BasimTarihi = dateEditDuzenleYil.DateTime;
            kitap.TurId = imagecmbDuzenleTur.SelectedIndex + 1;
            kitapBusiness.UpdateKitap(int.Parse(txtGetKitapById.Text), kitap);
        }
        private bool UpdateKitapControlsNullControl()
        {
            if (string.IsNullOrWhiteSpace(txtDuzenleKitapAdi.Text) || string.IsNullOrWhiteSpace(txtDuzenleYazarAdi.Text) || string.IsNullOrWhiteSpace(txtDuzenleBaskiSayi.Text) || string.IsNullOrWhiteSpace(dateEditDuzenleYil.Text) || imagecmbDuzenleTur.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSilKitapGetById_Click(object sender, EventArgs e)
        {
            FillDeleteControls();
        }
        private void FillDeleteControls()
        {
            Kitap kitap = new Kitap();
            kitap = GetKitapById(int.Parse(txtSilinecekId.Text));
            if (kitap == null)
            {
                MessageBox.Show("kitap bulanamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtSilKitapAdi.Text = kitap.Ad;
                txtSilYazarAdi.Text = kitap.Yazar;
                txtSilBasimSayisi.Text = kitap.BaskiSayisi.ToString();
                imageCmbSilKitapTur.SelectedIndex = kitap.TurId - 1;
                dateEditSilBasimYili.DateTime = kitap.BasimTarihi;
                btnKitapSil.Enabled = true;
            }

        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("silmek istediğnizden emin misinz", "EMİN MİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txtSilinecekId.Text))
                {
                    MessageBox.Show("boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DeleteKitap();
                }
            }          
            
        }
        private void DeleteKitap()
        {
            kitapBusiness.DeleteKitap(int.Parse(txtSilinecekId.Text));
        }

        
        private List<Kitap> GetAllKitap()
        {
            var kitaplarListe = kitapBusiness.GetAllKitap();
            return kitaplarListe;
        }
        private void fillStokCmb()
        {
            var kitaplar = GetAllKitap();
            foreach(var kitap in kitaplar)
            {
                imagecmbStokKitap.Properties.Items.Add(new ImageComboBoxItem(kitap.Ad, kitap.Id));
            }
        }

        private void btnStokKaydet_Click(object sender, EventArgs e)
        {

        }

        private void imagecmbStokKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kitapAdi = imagecmbStokKitap.EditValue.ToString();
            int id = GetKitapByName(kitapAdi);
            txtStokSecilenId.Text = id.ToString();

        }
        private int GetKitapByName(string kitapAdi)
        {
            int id = kitapBusiness.GetKitapByName(kitapAdi);
            return id;
        }

        private void btnStokArttir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtStokArttir.Text)||string.IsNullOrWhiteSpace(txtStokSecilenId.Text))
            {
                MessageBox.Show("boş alanları doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StokArttir(int.Parse(txtStokSecilenId.Text), int.Parse(txtStokArttir.Text));
            }
        }
        private void StokArttir(int id ,int stokSayisi)
        {
            kitapBusiness.StokArttir(id , stokSayisi);
        }
        private void StokAzalt(int id ,int stokSayisi)
        {
            kitapBusiness.StokAzalt(id, stokSayisi);
        }

        private void btnStokAzalt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStokArttir.Text) || string.IsNullOrWhiteSpace(txtStokSecilenId.Text))
            {
                MessageBox.Show("boş alanları doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StokAzalt(int.Parse(txtStokSecilenId.Text), int.Parse(txtStokArttir.Text));
            }
        }
       
        private void FillAllKitapGridView()
        {
            gridControlAllkitap.DataSource = GetAllKitapDTO();
            gridView1.Columns["TurId"].Visible = false;
            gridView1.Columns["KitapTur"].Visible = false;

        }
        private List<KitapListDTO> GetAllKitapDTO()
        {
            var kitaplarListe = kitapBusiness.GetAllKitapDTO();
            return kitaplarListe;
        }
        private List<KitapListDTO> GetMevcutAllKitapDTO()
        {
            var kitaplarListe = kitapBusiness.GetMevcutAllKitapDTO();
            return kitaplarListe;
        }
        private void FillMevcutAllKitapGridView()
        {
            gridControlMevcutKitaplar.DataSource = GetMevcutAllKitapDTO();
            gridView2.Columns["TurId"].Visible = false;
            gridView2.Columns["KitapTur"].Visible = false;

        }
    }
}
