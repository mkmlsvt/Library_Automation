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
    public partial class frmMusteriVeKirala : DevExpress.XtraEditors.XtraForm
    {
        public int aktifId;
        CalisanBusiness calisanBusiness;
        KiralamaBusiness kiralamaBusiness;
        KitapBusiness kitapBusiness;
        MusteriBusiness musteriBusiness;
        public frmMusteriVeKirala()
        {
            InitializeComponent();
            musteriBusiness = new MusteriBusiness();
            kitapBusiness = new KitapBusiness();
            kiralamaBusiness = new KiralamaBusiness();
            calisanBusiness = new CalisanBusiness();
        }

        private void navBarItemKirala_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKirala;
            FillGridviewMusteriKisaList();
            FillGridviewKitapKisaList();
        }
        private void navBarItemKiraAktifList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKiralaAktifList;
            FillGridViewAktifKiralikList();
        }

        private void navBarItemKiraListe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageKiralaList;
            FillGridViewAllKiralikList();
        }

        private void navBarItemMEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageMusteriEkle;

        }

        private void navBarItemMDuzenle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageMusteriDuzenle;
            FillCombobox();

        }

        private void navBarItemMSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageMusteriSil;
            FillCombobox();
        }

        private void navBarItemMlist_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPageMusteriList;
            FillGridviewMusteriList();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if(AddMusteriControlsIsNull())
            {
                AddMusteri();
                MessageBox.Show("Musteri Basarıyla eklendi", "EKLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        private void AddMusteri()
        {
            Musteri musteri = new Musteri();
            musteri.Ad = txtMEkleAd.Text;
            musteri.Soyad = txtMEkleSoyad.Text;
            musteri.Yas = int.Parse(txtMEkleYas.Text);
            musteri.Meslek = txtMEkleMeslek.Text;
            if(cmbMEkleSex.SelectedItem.ToString()=="Erkek")
            {
                musteri.CinsiyetE = true;
            }
            else
            {
                musteri.CinsiyetE = false;
            }
            musteriBusiness.AddMusteri(musteri);
        }
        private bool AddMusteriControlsIsNull()
        {
            if(string.IsNullOrWhiteSpace(txtMEkleAd.Text)|| string.IsNullOrWhiteSpace(txtMEkleSoyad.Text) || string.IsNullOrWhiteSpace(txtMEkleYas.Text) || string.IsNullOrWhiteSpace(txtMEkleMeslek.Text) || cmbMEkleSex.SelectedIndex<0 )
            {
                MessageBox.Show("boş alanları doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }
        private List<Musteri> GetAllMusteri()
        {
            var musteriler = musteriBusiness.GetAllMusteri();
            return musteriler;
        }
        private void FillCombobox()
        {
            imageCmbMusteriIdSec.Properties.Items.Clear();
            imagecmbMSilincekId.Properties.Items.Clear();
            var musteriler = GetAllMusteri();
            foreach (var musteri in musteriler)
            {
                imageCmbMusteriIdSec.Properties.Items.Add(new ImageComboBoxItem(musteri.Id.ToString(), musteri.Id));       
                imagecmbMSilincekId.Properties.Items.Add(new ImageComboBoxItem(musteri.Id.ToString(), musteri.Id));
            }
        }      
        private void FillMusteriDuzenleControlsById(int id)
        {
            var musteri = musteriBusiness.GetById(id);
            txtMDuzenleAd.Text = musteri.Ad;
            txtMDuzenleSoyad.Text = musteri.Soyad;
            txtMDuzenleYas.Text = musteri.Yas.ToString();
            txtMDuzenleMeslek.Text = musteri.Meslek;
            if(musteri.CinsiyetE)
            {
                cmbMDuzenleSex.SelectedIndex = 1;
            }
            else
            {
                cmbMDuzenleSex.SelectedIndex = 0;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if(UpdateMusteriControlsIsNull())
            {
                UpdateMusteri();
            }           
        }
        private void UpdateMusteri()
        {
           int duzenlencekId =  int.Parse(imageCmbMusteriIdSec.SelectedItem.ToString());
            Musteri musteri = new Musteri();
            musteri.Ad = txtMDuzenleAd.Text;
            musteri.Soyad = txtMDuzenleSoyad.Text;
            musteri.Yas= int.Parse(txtMDuzenleYas.Text);
            musteri.Meslek = txtMDuzenleMeslek.Text;
            if (cmbMDuzenleSex.SelectedIndex==1)
            {
                musteri.CinsiyetE = true;
            }
            else
            {
                musteri.CinsiyetE = false;
            }
            musteriBusiness.UpdateMusteri(duzenlencekId, musteri);
        }
        private bool UpdateMusteriControlsIsNull()
        {
            if (string.IsNullOrWhiteSpace(txtMDuzenleAd.Text) || string.IsNullOrWhiteSpace(txtMDuzenleSoyad.Text) || string.IsNullOrWhiteSpace(txtMDuzenleYas.Text) || string.IsNullOrWhiteSpace(txtMDuzenleMeslek.Text))
            {
                MessageBox.Show("boş alanları doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void imageCmbMusteriIdSec_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (imageCmbMusteriIdSec.SelectedIndex < 0)
            {
                MessageBox.Show("Once Id Seçmelisiniz ", "SECIM YAPMADINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FillMusteriDuzenleControlsById(int.Parse(imageCmbMusteriIdSec.SelectedItem.ToString()));
            }
        }

        private void imagecmbMSilincekId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMusteriSilControlsById(int.Parse(imagecmbMSilincekId.SelectedItem.ToString()));
        }
        private void FillMusteriSilControlsById(int id)
        {
            var musteri = musteriBusiness.GetById(id);
            txtMSilAd.Text = musteri.Ad;
            txtMSilSoyad.Text = musteri.Soyad;
            txtMSilYas.Text = musteri.Yas.ToString();
            txtMSilMeslek.Text = musteri.Meslek;
            if (musteri.CinsiyetE)
            {
                cmbMSilSex.SelectedIndex = 1;
            }
            else
            {
                cmbMSilSex.SelectedIndex = 0;
            }
        }

        private void btnMsil_Click(object sender, EventArgs e)
        {
            DeleteMusteri(int.Parse(imagecmbMSilincekId.SelectedItem.ToString()));
        }
        private void DeleteMusteri(int id)
        {
            DialogResult dialog = MessageBox.Show("Silmek İstediğinizden emin misiniz", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                musteriBusiness.DeleteMusteri(id);
            }
            
        }
        private List<MusteriDTO> GetAllMusteriDTO()
        {
            var musterilerDTO = musteriBusiness.GetAllMusteriDTO();
            return musterilerDTO;
        }
        private void FillGridviewMusteriList()
        {
            gridControlMusteriList.DataSource = GetAllMusteriDTO();
            gridView1.Columns["CinsiyetE"].Visible = false;
        }
        private void FillGridviewMusteriKisaList()
        {
            gridControlMusteriKisa.DataSource = GetAllMusteriDTO();
            gridView2.Columns["CinsiyetE"].Visible = false;
            gridView2.Columns["Yas"].Visible = false;
            gridView2.Columns["Ceza"].Visible = false;
            gridView2.Columns["Meslek"].Visible = false;
        }
        private void FillGridviewKitapKisaList()
        {
            gridControlKitapKisa.DataSource = GetAllKitapListDTO();
            gridView3.Columns["BasimTarihi"].Visible = false;
            gridView3.Columns["BaskiSayisi"].Visible = false;
            gridView3.Columns["Stok"].Visible = false;
            gridView3.Columns["TurId"].Visible = false;
            gridView3.Columns["KitapTur"].Visible = false;
        }
        private void FillGridViewAllKiralikList()
        {
            gridControlTumKiralamalar.DataSource = GetAllKiralama();
            gridView4.Columns["Calisan"].Visible = false;
            gridView4.Columns["Kitap"].Visible = false;
            gridView4.Columns["Musteri"].Visible = false;
        }
        private void FillGridViewAktifKiralikList()
        {
            gridControlAktifKiralama.DataSource = GetAllAktifKiralama();
            gridView5.Columns["Calisan"].Visible = false;
            gridView5.Columns["Kitap"].Visible = false;
            gridView5.Columns["Musteri"].Visible = false;
        }

        private List<KitapListDTO> GetAllKitapListDTO()
        {
            var kitaplar = kitapBusiness.GetMevcutAllKitapDTO();
            return kitaplar;
        }
        private void frmMusteriVeKirala_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.Editable = false;
            gridView4.OptionsBehavior.Editable = false;
            gridView5.OptionsBehavior.Editable = false;
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            AddKirala();
        }
        private void AddKirala()
        {
                      
            Kiralama kiralama = new Kiralama();
            if(KitapVarmi(int.Parse(gridView3.GetFocusedRowCellValue("Id").ToString())))
            {
                if(MusteriCezalimi(int.Parse(gridView2.GetFocusedRowCellValue("Id").ToString())))
                {
                    kiralama.CalisanId = frmLoginEmployee.aktifCalisanIdsi;
                    kiralama.KitapId = int.Parse(gridView3.GetFocusedRowCellValue("Id").ToString());
                    kiralama.Tarih = DateTime.Now;
                    kiralama.MusteriId = int.Parse(gridView2.GetFocusedRowCellValue("Id").ToString());
                    kiralama.Aktif = true;
                    kiralamaBusiness.AddKiralama(kiralama);
                    kitapBusiness.KitapKiralamaSonrasiStokAzalt(kiralama.KitapId);
                }
                else
                {
                    MessageBox.Show("Secilen Musteri Cezalı ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Kitap stoklarımızda yoktur ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }        
        }      
        private bool KitapVarmi(int id)
        {
           return kitapBusiness.Kitapvarmi(id);
        }
        private bool MusteriCezalimi(int id )
        {
            return musteriBusiness.MusteriCezalimi(id);
        }

        private List<Kiralama> GetAllKiralama()
        {
            var kiralikListe = kiralamaBusiness.GetAllKiralama();
            return kiralikListe;
        }
        private List<Kiralama> GetAllAktifKiralama()
        {
            var kiralikListe = kiralamaBusiness.GetAllAktifKiralama();
            return kiralikListe;
        }

        private void btnGeriGeldi_Click(object sender, EventArgs e)
        {         
            KiralaAktifChange(int.Parse(gridView5.GetFocusedRowCellValue("Id").ToString()));
            KitapMusaitStokArttir(int.Parse(gridView5.GetFocusedRowCellValue("KitapId").ToString()));
            FillGridViewAktifKiralikList();
            MessageBox.Show("Kitap Iade işlemi başarıyle gerçekleşti ", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void KiralaAktifChange(int id)
        {
            kiralamaBusiness.KiralaAktifChange(id);
        }
        private void KitapMusaitStokArttir(int kitapId)
        {
            kitapBusiness.MusaitStokArttir(kitapId);
        }
        private void btnCezalandir_Click(object sender, EventArgs e)
        {
            MusteriCezalandir(int.Parse(gridView5.GetFocusedRowCellValue("MusteriId").ToString()));
        }
        private void MusteriCezalandir(int musteriId)
        {
            musteriBusiness.MusteriCezaVer(musteriId);
            MessageBox.Show("Musteri Cezalandırıldı kütüphanemizden daha kitap kirayalamaz..", "CEZA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKiralaSil_Click(object sender, EventArgs e)
        {
            DeleteKiralama(int.Parse(gridView4.GetFocusedRowCellValue("Id").ToString()));
            FillGridViewAllKiralikList();
        }
        private void DeleteKiralama(int id)
        {
            kiralamaBusiness.DeleteKiralama(id);
        }
    }
}
