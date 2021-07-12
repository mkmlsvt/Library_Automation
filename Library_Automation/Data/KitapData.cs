using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation.Data
{
    public class KitapData
    {
        DatabaseContext db;
        public KitapData()
        {
            db = new DatabaseContext();
        }
        public void AddKitap(Kitap kitap)
        {
            db.Kitap.Add(kitap);
            db.SaveChanges();
            MessageBox.Show("Kitap Kaydedildi");
        }

        public Kitap GetKitapBtId(int id)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            if(kitap!=null)
            {
                return kitap;
            }
            else
            {
                return null;
            }
        }

        public void DeleteKitap(int id)
        {
            try
            {
                var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
                if (kitap != null)
                {
                    db.Kitap.Remove(kitap);
                    db.SaveChanges();
                    MessageBox.Show("Silme Başarıyla Gerçekleşti", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu Id ile Kitap Bulunumadı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                db = new DatabaseContext();
                e = new Exception();
                MessageBox.Show(e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void StokArttir(int id ,int stokSayisi)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            if(kitap!=null)
            {
                try
                {
                    kitap.Stok = kitap.Stok + stokSayisi;
                    kitap.MusaitStok = kitap.MusaitStok + stokSayisi;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e = new Exception();
                    MessageBox.Show(e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
                MessageBox.Show("Stok Arttrıma Başarıyla Gerçekleşti", "Arttırıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Bu Id ile Kitap Bulunumadı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public int GetKitapByName(string kitapAdi)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Ad == kitapAdi);
            return kitap.Id;
        }

        public List<Kitap> GetAllKitap()
        {
            var kitaplarListe = db.Kitap.ToList();
            return kitaplarListe;
        }

        public void UpdateKitap(int id, Kitap kitap)
        {
            var duzenlenKitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            if(duzenlenKitap!=null)
            {
                duzenlenKitap.Ad = kitap.Ad;
                duzenlenKitap.BasimTarihi = kitap.BasimTarihi;
                duzenlenKitap.BaskiSayisi = kitap.BaskiSayisi;
                duzenlenKitap.TurId = kitap.TurId;
                duzenlenKitap.Yazar = kitap.Yazar;
                db.SaveChanges();
                MessageBox.Show("Düzenleme Başarıyla Gerçekleşti", "Düzenlendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu Id ile Kitap Bulunumadı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MusaitStokArttir(int id)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            kitap.MusaitStok = kitap.MusaitStok + 1;
            db.SaveChanges();
        }

        public void KitapKiralamaSonrasiStokAzalt(int id)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            kitap.MusaitStok = kitap.MusaitStok - 1;
            db.SaveChanges();           
        }

        public bool KitapVarmi(int id)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            if(kitap!=null)
            {
                if(kitap.MusaitStok<=0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void StokAzalt(int id, int stokSayisi)
        {
            var kitap = db.Kitap.FirstOrDefault(q => q.Id == id);
            if (kitap != null)
            {
                
                if(stokSayisi>kitap.Stok)
                {
                    MessageBox.Show("Stok Sayisi 0 in Altina Düşemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    kitap.Stok -= stokSayisi;
                    kitap.MusaitStok -= stokSayisi;
                    if(kitap.MusaitStok<0)
                    {
                        kitap.MusaitStok = 0;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Stok Azaltma Başarıyla Gerçekleşti", "Arttırıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                         
            }
            else
            {
                MessageBox.Show("Bu Id ile Kitap Bulunumadı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
