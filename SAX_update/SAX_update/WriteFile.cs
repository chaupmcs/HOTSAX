using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAX_update
{
    static class WriteFile
    {
        static public void WriteFile_Function(List<double> data, int N_LENGTH, int best_so_far_loc)
        {
            string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"Output\", "output_SAX.csv" );
            string delimiter = ",";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(delimiter, new string[] { "index", "data", "is_discord" }));
            for (int index = 0; index < data.Count; index++)
            {
                string is_discord = "N";
                if (index >= best_so_far_loc && index <= best_so_far_loc + N_LENGTH - 1)
                    is_discord = "Y";
                sb.AppendLine(string.Join(delimiter, new string[] { index.ToString(), data[index].ToString(), is_discord }));
            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }
    }
}
