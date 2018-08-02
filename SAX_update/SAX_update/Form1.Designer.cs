namespace SAX_update
{
    partial class form_SAX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHeuristic = new System.Windows.Forms.Button();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.txt_best_so_far_dist_Heuristic = new System.Windows.Forms.TextBox();
            this.txt_best_so_far_loc_Heuristic = new System.Windows.Forms.TextBox();
            this.txt_best_so_far_dist_BruteForce = new System.Windows.Forms.TextBox();
            this.txt_best_so_far_loc_BruteForce = new System.Windows.Forms.TextBox();
            this.txt_execution_time_Heuristic = new System.Windows.Forms.TextBox();
            this.txt_execution_time_BruteForce = new System.Windows.Forms.TextBox();
            this.label_best_so_far_dist = new System.Windows.Forms.Label();
            this.label_best_so_far_loc = new System.Windows.Forms.Label();
            this.label_execution_time = new System.Windows.Forms.Label();
            this.txt_file_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_N_length = new System.Windows.Forms.TextBox();
            this.label_N_length = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHeuristic
            // 
            this.btnHeuristic.Location = new System.Drawing.Point(107, 26);
            this.btnHeuristic.Name = "btnHeuristic";
            this.btnHeuristic.Size = new System.Drawing.Size(100, 23);
            this.btnHeuristic.TabIndex = 0;
            this.btnHeuristic.Text = "Heuristic";
            this.btnHeuristic.UseVisualStyleBackColor = true;
            this.btnHeuristic.Click += new System.EventHandler(this.btnHeuristic_Click);
            // 
            // btnBruteForce
            // 
            this.btnBruteForce.Location = new System.Drawing.Point(222, 26);
            this.btnBruteForce.Name = "btnBruteForce";
            this.btnBruteForce.Size = new System.Drawing.Size(100, 23);
            this.btnBruteForce.TabIndex = 0;
            this.btnBruteForce.Text = "BruteForce";
            this.btnBruteForce.UseVisualStyleBackColor = true;
            this.btnBruteForce.Click += new System.EventHandler(this.btnBruteForce_Click);
            // 
            // txt_best_so_far_dist_Heuristic
            // 
            this.txt_best_so_far_dist_Heuristic.Location = new System.Drawing.Point(107, 76);
            this.txt_best_so_far_dist_Heuristic.Name = "txt_best_so_far_dist_Heuristic";
            this.txt_best_so_far_dist_Heuristic.Size = new System.Drawing.Size(100, 20);
            this.txt_best_so_far_dist_Heuristic.TabIndex = 1;
            // 
            // txt_best_so_far_loc_Heuristic
            // 
            this.txt_best_so_far_loc_Heuristic.Location = new System.Drawing.Point(107, 112);
            this.txt_best_so_far_loc_Heuristic.Name = "txt_best_so_far_loc_Heuristic";
            this.txt_best_so_far_loc_Heuristic.Size = new System.Drawing.Size(100, 20);
            this.txt_best_so_far_loc_Heuristic.TabIndex = 1;
            // 
            // txt_best_so_far_dist_BruteForce
            // 
            this.txt_best_so_far_dist_BruteForce.Location = new System.Drawing.Point(222, 76);
            this.txt_best_so_far_dist_BruteForce.Name = "txt_best_so_far_dist_BruteForce";
            this.txt_best_so_far_dist_BruteForce.Size = new System.Drawing.Size(100, 20);
            this.txt_best_so_far_dist_BruteForce.TabIndex = 1;
            // 
            // txt_best_so_far_loc_BruteForce
            // 
            this.txt_best_so_far_loc_BruteForce.Location = new System.Drawing.Point(222, 112);
            this.txt_best_so_far_loc_BruteForce.Name = "txt_best_so_far_loc_BruteForce";
            this.txt_best_so_far_loc_BruteForce.Size = new System.Drawing.Size(100, 20);
            this.txt_best_so_far_loc_BruteForce.TabIndex = 1;
            // 
            // txt_execution_time_Heuristic
            // 
            this.txt_execution_time_Heuristic.Location = new System.Drawing.Point(107, 148);
            this.txt_execution_time_Heuristic.Name = "txt_execution_time_Heuristic";
            this.txt_execution_time_Heuristic.Size = new System.Drawing.Size(100, 20);
            this.txt_execution_time_Heuristic.TabIndex = 1;
            // 
            // txt_execution_time_BruteForce
            // 
            this.txt_execution_time_BruteForce.Location = new System.Drawing.Point(222, 148);
            this.txt_execution_time_BruteForce.Name = "txt_execution_time_BruteForce";
            this.txt_execution_time_BruteForce.Size = new System.Drawing.Size(100, 20);
            this.txt_execution_time_BruteForce.TabIndex = 1;
            // 
            // label_best_so_far_dist
            // 
            this.label_best_so_far_dist.AutoSize = true;
            this.label_best_so_far_dist.Location = new System.Drawing.Point(12, 76);
            this.label_best_so_far_dist.Name = "label_best_so_far_dist";
            this.label_best_so_far_dist.Size = new System.Drawing.Size(84, 13);
            this.label_best_so_far_dist.TabIndex = 2;
            this.label_best_so_far_dist.Text = "best_so_far_dist";
            // 
            // label_best_so_far_loc
            // 
            this.label_best_so_far_loc.AutoSize = true;
            this.label_best_so_far_loc.Location = new System.Drawing.Point(12, 115);
            this.label_best_so_far_loc.Name = "label_best_so_far_loc";
            this.label_best_so_far_loc.Size = new System.Drawing.Size(82, 13);
            this.label_best_so_far_loc.TabIndex = 2;
            this.label_best_so_far_loc.Text = "best_so_far_loc";
            // 
            // label_execution_time
            // 
            this.label_execution_time.AutoSize = true;
            this.label_execution_time.Location = new System.Drawing.Point(12, 151);
            this.label_execution_time.Name = "label_execution_time";
            this.label_execution_time.Size = new System.Drawing.Size(89, 13);
            this.label_execution_time.TabIndex = 2;
            this.label_execution_time.Text = "time_Milliseconds";
            // 
            // txt_file_name
            // 
            this.txt_file_name.Location = new System.Drawing.Point(143, 227);
            this.txt_file_name.Name = "txt_file_name";
            this.txt_file_name.Size = new System.Drawing.Size(100, 20);
            this.txt_file_name.TabIndex = 1;
            this.txt_file_name.Text = "ECG_15000.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "file name";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(102, 208);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(35, 13);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(143, 201);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(100, 20);
            this.txt_status.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(261, 264);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 39);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_N_length
            // 
            this.txt_N_length.Location = new System.Drawing.Point(143, 252);
            this.txt_N_length.Name = "txt_N_length";
            this.txt_N_length.Size = new System.Drawing.Size(100, 20);
            this.txt_N_length.TabIndex = 6;
            this.txt_N_length.Text = "600";
            // 
            // label_N_length
            // 
            this.label_N_length.AutoSize = true;
            this.label_N_length.Location = new System.Drawing.Point(12, 255);
            this.label_N_length.Name = "label_N_length";
            this.label_N_length.Size = new System.Drawing.Size(125, 13);
            this.label_N_length.TabIndex = 7;
            this.label_N_length.Text = "N_length_sub_timeseries";
            // 
            // form_SAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 303);
            this.Controls.Add(this.label_N_length);
            this.Controls.Add(this.txt_N_length);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_execution_time);
            this.Controls.Add(this.label_best_so_far_loc);
            this.Controls.Add(this.label_best_so_far_dist);
            this.Controls.Add(this.txt_best_so_far_loc_BruteForce);
            this.Controls.Add(this.txt_execution_time_BruteForce);
            this.Controls.Add(this.txt_file_name);
            this.Controls.Add(this.txt_execution_time_Heuristic);
            this.Controls.Add(this.txt_best_so_far_loc_Heuristic);
            this.Controls.Add(this.txt_best_so_far_dist_BruteForce);
            this.Controls.Add(this.txt_best_so_far_dist_Heuristic);
            this.Controls.Add(this.btnBruteForce);
            this.Controls.Add(this.btnHeuristic);
            this.Name = "form_SAX";
            this.Text = "SAX.ver1.6__Nov 4th 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeuristic;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.TextBox txt_best_so_far_dist_Heuristic;
        private System.Windows.Forms.TextBox txt_best_so_far_loc_Heuristic;
        private System.Windows.Forms.TextBox txt_best_so_far_dist_BruteForce;
        private System.Windows.Forms.TextBox txt_best_so_far_loc_BruteForce;
        private System.Windows.Forms.TextBox txt_execution_time_Heuristic;
        private System.Windows.Forms.TextBox txt_execution_time_BruteForce;
        private System.Windows.Forms.Label label_best_so_far_dist;
        private System.Windows.Forms.Label label_best_so_far_loc;
        private System.Windows.Forms.Label label_execution_time;
        private System.Windows.Forms.TextBox txt_file_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_N_length;
        private System.Windows.Forms.Label label_N_length;
    }
}

