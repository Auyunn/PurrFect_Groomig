namespace PurrFect
{
    partial class Best_Selling_Service
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.service_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.service_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(285, 99);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(219, 25);
            this.CustomerLabel.TabIndex = 6;
            this.CustomerLabel.Text = "Best-Selling Package";
            // 
            // service_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.service_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.service_chart.Legends.Add(legend1);
            this.service_chart.Location = new System.Drawing.Point(290, 156);
            this.service_chart.Name = "service_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.service_chart.Series.Add(series1);
            this.service_chart.Size = new System.Drawing.Size(465, 421);
            this.service_chart.TabIndex = 7;
            this.service_chart.Click += new System.EventHandler(this.service_chart_Click);
            // 
            // Best_Selling_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1038, 706);
            this.Controls.Add(this.service_chart);
            this.Controls.Add(this.CustomerLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Best_Selling_Service";
            this.Text = "Best_Selling_Service";
            this.Load += new System.EventHandler(this.Best_Selling_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.service_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart service_chart;
    }
}