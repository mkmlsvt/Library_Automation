using Library_Automation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Business
{
    public class KitapTurBusiness
    {
        KitapTurData kitapTurData;
        public KitapTurBusiness()
        {
            kitapTurData = new KitapTurData();
        }
        public List<KitapTur> GetAllKitapTur()
        {
            var kitapTurleri = kitapTurData.GetAllKitapTur();
            return kitapTurleri;
        }

    }
}
