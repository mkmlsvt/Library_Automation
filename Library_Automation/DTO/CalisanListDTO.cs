using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.DTO
{
    public class CalisanListDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get
            {
                if(CinsiyetE)
                {
                    return "Erkek";
                }
                else
                {
                    return "Kadın";
                }
            } }
        public bool CinsiyetE { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
    }
}
