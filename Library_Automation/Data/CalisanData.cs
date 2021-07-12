using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation.Data
{
    public class CalisanData
    {
        DatabaseContext db;
        public CalisanData()
        {
            db = new DatabaseContext();
        }
        public List<Calisan> GetAllCalisan()
        {
            var calisanlar = db.Calisan.ToList();
            return calisanlar;
        }

        public void AddEmployee(Calisan calisan)
        {
            var a = db.Calisan.FirstOrDefault(q => q.Username == calisan.Username);
            if(a==null)
            {
                db.Calisan.Add(calisan);
                db.SaveChanges();
                MessageBox.Show("Başarıyla kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Girdiğinz username kullanımda", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateEmployee(int duzenlenecekId, Calisan calisan)
        {
            Calisan a = db.Calisan.FirstOrDefault(q => q.Username == calisan.Username && q.Id != duzenlenecekId);
            if(a==null)
            {
                Calisan updateingCalisan = db.Calisan.FirstOrDefault(q => q.Id == duzenlenecekId);
                updateingCalisan.Ad = calisan.Ad;
                updateingCalisan.Yas = calisan.Yas;
                updateingCalisan.Soyad = calisan.Soyad;
                updateingCalisan.Username = calisan.Username;
                updateingCalisan.Password = calisan.Password;
                updateingCalisan.CinsiyetE = calisan.CinsiyetE;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Girdiğinz username kullanımda", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int FindId(Calisan calisan)
        {
            var aktifCalisan = db.Calisan.FirstOrDefault(q => q.Username == calisan.Username && q.Password == calisan.Password);
            if(aktifCalisan!=null)
            {
                return aktifCalisan.Id;
            }
            else
            {
                return 0;
            }
        }

        public bool LoginEmployee(Calisan calisan)
        {
            Calisan calisanTF = db.Calisan.FirstOrDefault(q => q.Password == calisan.Password && q.Username == calisan.Username);
            if(calisanTF!=null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void DeleteEmployee(int silenecekId)
        {
            try
            {
                var silinecekCalisan = db.Calisan.FirstOrDefault(q => q.Id == silenecekId);
                db.Calisan.Remove(silinecekCalisan);
                db.SaveChanges();
                MessageBox.Show("Calisan silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                db = new DatabaseContext();
                e = new Exception();
                MessageBox.Show(e.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
