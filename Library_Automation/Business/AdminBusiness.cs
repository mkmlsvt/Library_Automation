using Library_Automation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Business
{
    public class AdminBusiness
    {
        AdminData adminData;
        public AdminBusiness()
        {
            adminData = new AdminData();
        }
        public bool LoginAdmin(Admin admin)
        {
            var a = adminData.LoginAdmin(admin);
            if (a != null)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
