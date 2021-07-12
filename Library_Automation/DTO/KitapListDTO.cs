using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.DTO
{
    public class KitapListDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public System.DateTime BasimTarihi { get; set; }
        public int BaskiSayisi { get; set; }
        public int Stok { get; set; }
        public int MusaitStok { get; set; }
        public int TurId { get; set; }           
        public string KitapTurAdi { get
            {
                return KitapTur.Ad;
            } }
        public virtual KitapTur KitapTur { get; set; }
    }
}
