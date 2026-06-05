namespace PurrFect
{
    partial class SalesChart
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
            this.sales_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // sales_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.sales_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sales_chart.Legends.Add(legend1);
            this.sales_chart.Location = new System.Drawing.Point(247, 196);
            this.sales_chart.Name = "sales_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.sales_chart.Series.Add(series1);
            this.sales_chart.Size = new System.Drawing.Size(465, 421);
            this.sales_chart.TabIndex = 5;
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLabel.Location = new System.Drawing.Point(244, 108);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(254, 25);
            this.SalesLabel.TabIndex = 4;
            this.SalesLabel.Text = "PurrFect Grooming Sales";
            // 
            // SalesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(961, 701);
            this.Controls.Add(this.sales_chart);
            this.Controls.Add(this.SalesLabel);
            this.Name = "SalesChart";
            this.Text = "SalesChart";
            this.Load += new System.EventHandler(this.SalesChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sales_chart;
        private System.Windows.Forms.Label SalesLabel;
    }
}
