using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    public interface IPolaznikServis
    {
       
        void updatePolaznik(Object obj);

        int savePolaznik(Object obj);
        void updatePolaznik1(Object obj);
        void deletePolaznik(int broj);

        void readPolaznik();
    }
}
