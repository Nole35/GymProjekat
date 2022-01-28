using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    interface IAdresaServis
    {
        void readAdrese();
        int saveAdresa(Object obj);
        void updateAdresa(Object obj);
        void updateAdresa1(Object obj);
        void deleteAdresa(int broj);
    }
}
