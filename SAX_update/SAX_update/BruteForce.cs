using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAX_update
{
    static class BruteForce
    {
        static public List<double> BruteForce_Function(List<double> T, int n)
        {
            double best_so_far_dist = 0;
            int best_so_far_loc = 0;

            double dist = 0;
            double nearest_neighbor_dist = 0;

            Console.WriteLine("Running BruteForce_Function... Please wait");

            for (int p = 0; p <= T.Count - n; p++) //Begin outer loop 
            {
                nearest_neighbor_dist = Constants.INFINITE;

                for (int q = 0; q <= T.Count - n; q++)//Begin inner loop
                {
                    if (Math.Abs(p - q) < n)
                    {
                        continue;
                    }
                    else
                    {
                        dist = MathFunctions.Distance(T.GetRange(p, n), T.GetRange(q, n));
                        if (dist < nearest_neighbor_dist)
                        {
                            nearest_neighbor_dist = dist;
                        }
                    }
                }//end inner loop

                if (nearest_neighbor_dist > best_so_far_dist)
                {
                    best_so_far_dist = nearest_neighbor_dist;
                    best_so_far_loc = p;
                }

            } //end outer loop 

            List<double> list_result = new List<double>() { best_so_far_dist, best_so_far_loc };

            return list_result;
        }
    }
}//end flie
