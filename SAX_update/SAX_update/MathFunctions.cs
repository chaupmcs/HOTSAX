using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAX_update
{
    static class MathFunctions
    {

        static public double MinMax_Normalization(double value, double min, double max)
        {
            return ((value - min) / (max - min)) * (Constants.NEW_MAX - Constants.NEW_MIN) + Constants.NEW_MIN;
        }

        static public double Distance_old(List<double> t1, List<double> t2)
        {
            double Dist = 0;

            for (int i = 0; i <= t1.Count - 1; i++)
            {
                Dist = Dist + Math.Pow(t1.ElementAt(i) - t2.ElementAt(i), 2);
            }
            Dist = Math.Sqrt(Dist);
            return Dist;
        }

        //new distance function_much faster
        static public double Distance(List<double> t1, List<double> t2)
        {
            double dist = Math.Sqrt(t1.Zip(t2, (a, b) => (a - b) * (a - b)).Sum());
            return dist;
        }
    }
}
