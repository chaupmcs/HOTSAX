using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAX_update
{
    static class ReadFile
    {
        static public List<double> ReadFileIntoList(string file_name)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", file_name);
            List<double> data = new List<double>();

            //read file
            string[] lines = System.IO.File.ReadAllLines(path);

            //skip the header
            lines = lines.Skip(1).ToArray();


            foreach (string line in lines)
            {
                data.Add(Convert.ToDouble(line)); //convert into a double list then add to 'data'
            }
            
            return data;
        }//end ReadFileIntoList function

        static public List<double> ReadFile2(string file_name)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", file_name);
            StreamReader file = new StreamReader(path);

            string line = file.ReadLine();//skipping the header of the file
            line = file.ReadLine();

            List<double> data = new List<double>();
            while (line != null)
            {
                double number = Convert.ToDouble(line);
                data.Add(number);
                line = file.ReadLine();

            }
            return data;
        }

    }
}
