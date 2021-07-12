using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Data
{
    public class KitapTurData
    {
        DatabaseContext db;
        public KitapTurData()
        {
            db = new DatabaseContext();
        }
        public List<KitapTur> GetAllKitapTur()
        {
            var kitapTurleri = db.KitapTur.ToList();
            return kitapTurleri;
        }
    }
}
