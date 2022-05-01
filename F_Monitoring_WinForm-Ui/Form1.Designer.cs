namespace F_Monitoring_WinForm_Ui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlightCounter_lb = new System.Windows.Forms.Label();
            this.LastUpdate_lb = new System.Windows.Forms.Label();
            this.FlightCounter_Tb = new System.Windows.Forms.TextBox();
            this.LastUpdate_Tb = new System.Windows.Forms.TextBox();
            this.Top5Countries_lb = new System.Windows.Forms.Label();
            this.Top5Countries_Tb = new System.Windows.Forms.TextBox();
            this.CountriesList_Tb = new System.Windows.Forms.TextBox();
            this.CountriesList_lb = new System.Windows.Forms.Label();
            this.Filghts_Tb = new System.Windows.Forms.TextBox();
            this.Filghts_lb = new System.Windows.Forms.Label();
            this.Filght_Details_Tb = new System.Windows.Forms.TextBox();
            this.Filght_Details_lb = new System.Windows.Forms.Label();
            this.HighestFlight_btn = new System.Windows.Forms.Button();
            this.LowestFlight_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_btn.Location = new System.Drawing.Point(49, 55);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(123, 62);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = false;
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Stop_btn.Location = new System.Drawing.Point(204, 55);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(123, 62);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Live_pictureBox1_Click);
            // 
            // FlightCounter_lb
            // 
            this.FlightCounter_lb.AutoSize = true;
            this.FlightCounter_lb.Location = new System.Drawing.Point(45, 213);
            this.FlightCounter_lb.Name = "FlightCounter_lb";
            this.FlightCounter_lb.Size = new System.Drawing.Size(117, 20);
            this.FlightCounter_lb.TabIndex = 3;
            this.FlightCounter_lb.Text = " Flight Counter ";
            // 
            // LastUpdate_lb
            // 
            this.LastUpdate_lb.AutoSize = true;
            this.LastUpdate_lb.Location = new System.Drawing.Point(45, 257);
            this.LastUpdate_lb.Name = "LastUpdate_lb";
            this.LastUpdate_lb.Size = new System.Drawing.Size(121, 24);
            this.LastUpdate_lb.TabIndex = 4;
            this.LastUpdate_lb.Text = " Last Update";
            // 
            // FlightCounter_Tb
            // 
            this.FlightCounter_Tb.Location = new System.Drawing.Point(183, 207);
            this.FlightCounter_Tb.Name = "FlightCounter_Tb";
            this.FlightCounter_Tb.Size = new System.Drawing.Size(161, 26);
            this.FlightCounter_Tb.TabIndex = 5;
            // 
            // LastUpdate_Tb
            // 
            this.LastUpdate_Tb.Location = new System.Drawing.Point(183, 254);
            this.LastUpdate_Tb.Name = "LastUpdate_Tb";
            this.LastUpdate_Tb.Size = new System.Drawing.Size(161, 26);
            this.LastUpdate_Tb.TabIndex = 6;
            // 
            // Top5Countries_lb
            // 
            this.Top5Countries_lb.AutoSize = true;
            this.Top5Countries_lb.Location = new System.Drawing.Point(45, 326);
            this.Top5Countries_lb.Name = "Top5Countries_lb";
            this.Top5Countries_lb.Size = new System.Drawing.Size(150, 24);
            this.Top5Countries_lb.TabIndex = 7;
            this.Top5Countries_lb.Text = " Top 5 Countries";
            // 
            // Top5Countries_Tb
            // 
            this.Top5Countries_Tb.Location = new System.Drawing.Point(34, 362);
            this.Top5Countries_Tb.Multiline = true;
            this.Top5Countries_Tb.Name = "Top5Countries_Tb";
            this.Top5Countries_Tb.Size = new System.Drawing.Size(232, 107);
            this.Top5Countries_Tb.TabIndex = 8;
            // 
            // CountriesList_Tb
            // 
            this.CountriesList_Tb.Location = new System.Drawing.Point(33, 529);
            this.CountriesList_Tb.Multiline = true;
            this.CountriesList_Tb.Name = "CountriesList_Tb";
            this.CountriesList_Tb.Size = new System.Drawing.Size(232, 107);
            this.CountriesList_Tb.TabIndex = 10;
            // 
            // CountriesList_lb
            // 
            this.CountriesList_lb.AutoSize = true;
            this.CountriesList_lb.Location = new System.Drawing.Point(45, 493);
            this.CountriesList_lb.Name = "CountriesList_lb";
            this.CountriesList_lb.Size = new System.Drawing.Size(127, 24);
            this.CountriesList_lb.TabIndex = 9;
            this.CountriesList_lb.Text = "Countries List";
            // 
            // Filghts_Tb
            // 
            this.Filghts_Tb.Location = new System.Drawing.Point(442, 362);
            this.Filghts_Tb.Multiline = true;
            this.Filghts_Tb.Name = "Filghts_Tb";
            this.Filghts_Tb.Size = new System.Drawing.Size(232, 107);
            this.Filghts_Tb.TabIndex = 12;
            // 
            // Filghts_lb
            // 
            this.Filghts_lb.AutoSize = true;
            this.Filghts_lb.Location = new System.Drawing.Point(453, 326);
            this.Filghts_lb.Name = "Filghts_lb";
            this.Filghts_lb.Size = new System.Drawing.Size(67, 24);
            this.Filghts_lb.TabIndex = 11;
            this.Filghts_lb.Text = "Filghts";
            // 
            // Filght_Details_Tb
            // 
            this.Filght_Details_Tb.Location = new System.Drawing.Point(945, 362);
            this.Filght_Details_Tb.Multiline = true;
            this.Filght_Details_Tb.Name = "Filght_Details_Tb";
            this.Filght_Details_Tb.Size = new System.Drawing.Size(232, 107);
            this.Filght_Details_Tb.TabIndex = 14;
            this.Filght_Details_Tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Filght_Details_lb
            // 
            this.Filght_Details_lb.AutoSize = true;
            this.Filght_Details_lb.Location = new System.Drawing.Point(956, 326);
            this.Filght_Details_lb.Name = "Filght_Details_lb";
            this.Filght_Details_lb.Size = new System.Drawing.Size(127, 24);
            this.Filght_Details_lb.TabIndex = 13;
            this.Filght_Details_lb.Text = "Filght_Details";
            this.Filght_Details_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // HighestFlight_btn
            // 
            this.HighestFlight_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HighestFlight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HighestFlight_btn.Location = new System.Drawing.Point(903, 36);
            this.HighestFlight_btn.Name = "HighestFlight_btn";
            this.HighestFlight_btn.Size = new System.Drawing.Size(165, 62);
            this.HighestFlight_btn.TabIndex = 15;
            this.HighestFlight_btn.Text = "Highest Flight";
            this.HighestFlight_btn.UseVisualStyleBackColor = false;
            // 
            // LowestFlight_btn
            // 
            this.LowestFlight_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LowestFlight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LowestFlight_btn.Location = new System.Drawing.Point(1100, 36);
            this.LowestFlight_btn.Name = "LowestFlight_btn";
            this.LowestFlight_btn.Size = new System.Drawing.Size(165, 62);
            this.LowestFlight_btn.TabIndex = 16;
            this.LowestFlight_btn.Text = "Lowest Flight";
            this.LowestFlight_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 691);
            this.Controls.Add(this.LowestFlight_btn);
            this.Controls.Add(this.HighestFlight_btn);
            this.Controls.Add(this.Filght_Details_Tb);
            this.Controls.Add(this.Filght_Details_lb);
            this.Controls.Add(this.Filghts_Tb);
            this.Controls.Add(this.Filghts_lb);
            this.Controls.Add(this.CountriesList_Tb);
            this.Controls.Add(this.CountriesList_lb);
            this.Controls.Add(this.Top5Countries_Tb);
            this.Controls.Add(this.Top5Countries_lb);
            this.Controls.Add(this.LastUpdate_Tb);
            this.Controls.Add(this.FlightCounter_Tb);
            this.Controls.Add(this.LastUpdate_lb);
            this.Controls.Add(this.FlightCounter_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FlightCounter_lb;
        private System.Windows.Forms.Label LastUpdate_lb;
        private System.Windows.Forms.TextBox FlightCounter_Tb;
        private System.Windows.Forms.TextBox LastUpdate_Tb;
        private System.Windows.Forms.Label Top5Countries_lb;
        private System.Windows.Forms.TextBox Top5Countries_Tb;
        private System.Windows.Forms.TextBox CountriesList_Tb;
        private System.Windows.Forms.Label CountriesList_lb;
        private System.Windows.Forms.TextBox Filghts_Tb;
        private System.Windows.Forms.Label Filghts_lb;
        private System.Windows.Forms.TextBox Filght_Details_Tb;
        private System.Windows.Forms.Label Filght_Details_lb;
        private System.Windows.Forms.Button HighestFlight_btn;
        private System.Windows.Forms.Button LowestFlight_btn;
    }
}

