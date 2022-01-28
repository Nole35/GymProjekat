using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    interface IFitnesCentarServis
    {
       
       
        void updateFitnesCentar(Object obj);

        int saveFitnesCentar(Object obj);
        void updateFitnesCentar1(Object obj);
        void deleteFitnesCentar(int broj);

        void readFitnesCentar();
    }
}
