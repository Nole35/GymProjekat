using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR09_2020_POP2021.Servisi
{
    interface IFitnesCentarServis
    {
        void readFitnesCentar();
        int saveFitnesCentar(Object obj);
        void updateFitnesCentar(Object obj);
        void updateFitnesCentar1(Object obj);
        void deleteFitnesCentar(int broj);
    }
}
