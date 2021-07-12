using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Data
{
    public class AdminData
    {
        DatabaseContext db;
        public AdminData()
        {
            db = new DatabaseContext();
        }
        public Admin LoginAdmin(Admin admin)
        {
            var trueOrfalse = db.Admin.FirstOrDefault(q => q.Username == admin.Username && q.Password == admin.Password);
            return trueOrfalse;
        }
    }
}
