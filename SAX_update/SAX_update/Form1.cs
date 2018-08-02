using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAX_update
{
    public partial class form_SAX : Form
    {
        public form_SAX()
        {
            InitializeComponent();
        }

        private void btnBruteForce_Click(object sender, EventArgs e)
        {
           
            var watch = System.Diagnostics.Stopwatch.StartNew();///calc execution time

            List<double> data, result;
            data = ReadFile.ReadFileIntoList(this.txt_file_name.Text);

            int N_LENGTH = Convert.ToInt16(this.txt_N_length.Text);

            result = BruteForce.BruteForce_Function(data, N_LENGTH);

            watch.Stop();//stop timer
            var elapsedMs = watch.ElapsedMilliseconds;

            this.txt_best_so_far_dist_BruteForce.Text = result.ElementAt(0).ToString();
            this.txt_best_so_far_loc_BruteForce.Text = result.ElementAt(1).ToString();
            this.txt_execution_time_BruteForce.Text = elapsedMs.ToString();
            this.txt_file_name.Enabled = true;

            this.txt_status.Text = "Done !";//set status
            Console.WriteLine("Done");//printout to console
        }

      

        private void btnHeuristic_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();///calc execution time

            //read file
            List<double> data;
            data = ReadFile.ReadFileIntoList(this.txt_file_name.Text);

            //get the length of each sub_timeseries
            int N_LENGTH = Convert.ToInt16(this.txt_N_length.Text);

           
            List<double> result;//store the result

            Console.WriteLine("Calling Heuristic function... Please wait");
            result = Heuristic.Heuristic_Function(data, N_LENGTH);

            watch.Stop(); //stop timer
            long elapsedMs = watch.ElapsedMilliseconds;

            //print output:
            this.txt_best_so_far_dist_Heuristic.Text = result.ElementAt(0).ToString();
            this.txt_best_so_far_loc_Heuristic.Text = result.ElementAt(1).ToString();
            this.txt_execution_time_Heuristic.Text = elapsedMs.ToString();

            this.txt_status.Text = "Done !";// set status


            //print through console 
            Console.WriteLine("best_so_far_dist_Heuristic = " + result.ElementAt(0));
            Console.WriteLine("best_so_far_loc_Heuristic = " + result.ElementAt(1));
            Console.WriteLine("execution_time_Heuristic = " + elapsedMs);

            Console.WriteLine("Writing to file...");
            WriteFile.WriteFile_Function(data, N_LENGTH, (int)result.ElementAt(1));
            Console.WriteLine("Done !");
            Console.WriteLine("------------------------");
        }

        private void txt_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_best_so_far_dist_BruteForce.Clear();
            this.txt_best_so_far_loc_BruteForce.Clear();
            this.txt_execution_time_BruteForce.Clear();

            this.txt_best_so_far_dist_Heuristic.Clear();
            this.txt_best_so_far_loc_Heuristic.Clear();
            this.txt_execution_time_Heuristic.Clear();

            this.txt_status.Text = "Cleared !";

        }
    }
}
