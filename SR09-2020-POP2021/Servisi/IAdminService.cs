using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    interface IAdminService
    {
       
        
        void updateAdmin(Object obj);
        void deleteAdmin(int broj);

        int saveAdmin(Object obj);
        void readAdmin();
    }
}
