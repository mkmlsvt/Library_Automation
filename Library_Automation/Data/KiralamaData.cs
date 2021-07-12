using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation.Data
{
    public class KiralamaData
    {
        DatabaseContext db;
        public KiralamaData()
        {
            db = new DatabaseContext();
        }
        public void AddKiralama(Kiralama kiralama)
        {
            try
            {
                db.Kiralama.Add(kiralama);
                db.SaveChanges();
                MessageBox.Show("Kiralama islemi basarili","BASARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e )
            {
                e = new Exception();
                MessageBox.Show(e.ToString());
            }
            
        }
        public List<Kiralama> GetAllKiralama()
        {
            var kiralikList = db.Kiralama.ToList();
            return kiralikList;
        }

        public void KiralaAktifChange(int id)
        {
            var kiralama = db.Kiralama.FirstOrDefault(q => q.Id == id);
            kiralama.Aktif = false;
            db.SaveChanges();
        }

        public void DeleteKiralama(int id)
        {
            try
            {
                var kiralama = db.Kiralama.FirstOrDefault(q => q.Id == id);
                db.Kiralama.Remove(kiralama);
                db.SaveChanges();
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
