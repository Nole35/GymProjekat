using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    interface ITreningServis
    {
        
       
        void updateTrening(Object obj);

        int saveTrening(Object obj);
        void updateTrening1(Object obj);
        void deleteTrening(int broj);

        void readTrening();
    }
}
