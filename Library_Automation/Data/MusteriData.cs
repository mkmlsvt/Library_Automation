using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation.Data
{
    public class MusteriData
    {
        DatabaseContext db;
        public MusteriData()
        {
            db = new DatabaseContext();
        }
        public void AddMusteri(Musteri musteri)
        {
            
            db.Musteri.Add(musteri);
            db.SaveChanges();
        }
        public List<Musteri> GetAllMusteri()
        {
            var musteriler = db.Musteri.ToList();
            return musteriler;
        }

        public Musteri GetById(int id)
        {
            Musteri musteri = db.Musteri.FirstOrDefault(q => q.Id == id);
            return musteri;
        }

        public void UpdateMusteri(int duzenlencekId, Musteri musteri)
        {
            var duzenlencekMusteri = db.Musteri.FirstOrDefault(q => q.Id == duzenlencekId);
            duzenlencekMusteri.Ad = musteri.Ad;
            duzenlencekMusteri.Soyad = musteri.Soyad;
            duzenlencekMusteri.Yas= musteri.Yas;
            duzenlencekMusteri.CinsiyetE = musteri.CinsiyetE;
            duzenlencekMusteri.Meslek = musteri.Meslek;
            db.SaveChanges();
            MessageBox.Show("Duzenleme gerçekleşti", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteMusteri(int id)
        {
            var musteri = db.Musteri.FirstOrDefault(q => q.Id == id);
            if(musteri!=null)
            {
                try
                {
                    db.Musteri.Remove(musteri);
                    db.SaveChanges();
                    MessageBox.Show("Musteri Silindi", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e)
                {
                    db = new DatabaseContext();
                    e = new Exception();
                    MessageBox.Show(e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Id bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public bool MusteriCezalimi(int id)
        {
            var musteri = db.Musteri.FirstOrDefault(q => q.Id == id);
            if(musteri.Ceza)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MusteriCezaVer(int musteriId)
        {
            var musteri =  db.Musteri.FirstOrDefault(q => q.Id == musteriId);
            musteri.Ceza = true;
            db.SaveChanges();
        }
    }
}
