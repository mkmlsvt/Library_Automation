using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.DTO
{
    public class MusteriDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get
            {
                if(CinsiyetE)
                {
                    return "Erkek";
                }
                else
                {
                    return "Kadin";
                }    
            } }
        public bool CinsiyetE { get; set; }
        public string Meslek { get; set; }
        public int Yas { get; set; }
        public bool Ceza { get; set; }
    }
}
