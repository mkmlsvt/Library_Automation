using Library_Automation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Business
{
    public class KiralamaBusiness
    {
        KiralamaData kiralamaData;
        public KiralamaBusiness()
        {
            kiralamaData = new KiralamaData();
        }
        public void AddKiralama(Kiralama kiralama)
        {
            kiralamaData.AddKiralama(kiralama);
        }
        public List<Kiralama> GetAllKiralama()
        {
            return kiralamaData.GetAllKiralama();
        }
        public List<Kiralama> GetAllAktifKiralama()
        {
            var kiralikListe = kiralamaData.GetAllKiralama();
            List<Kiralama> kiralikAktifList = new List<Kiralama>();
            foreach(var kiralik in kiralikListe)
            {
                if(kiralik.Aktif==true)
                {
                    kiralikAktifList.Add(kiralik);
                }
            }
            return kiralikAktifList;
        }

        public void KiralaAktifChange(int id)
        {
            kiralamaData.KiralaAktifChange(id);
        }

        public void DeleteKiralama(int id)
        {
            kiralamaData.DeleteKiralama(id);
        }
    }
}
