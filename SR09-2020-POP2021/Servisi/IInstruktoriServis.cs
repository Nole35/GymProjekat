using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    public interface IInstruktoriServis
    {
        void readInstruktor();
        int saveInstruktor(Object obj);
        void updateInstruktor(Object obj);
        void updateInstruktor1(Object obj);
        void deleteInstruktor(int broj);
    }
}
