namespace PurrFect
{
    partial class CustomerChart
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
            this.customer_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CustomerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.customer_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.customer_chart.Legends.Add(legend1);
            this.customer_chart.Location = new System.Drawing.Point(252, 184);
            this.customer_chart.Name = "customer_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.customer_chart.Series.Add(series1);
            this.customer_chart.Size = new System.Drawing.Size(465, 421);
            this.customer_chart.TabIndex = 5;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(249, 96);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(292, 25);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "Customer PurrFect Grooming";
            // 
            // CustomerChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(966, 700);
            this.Controls.Add(this.customer_chart);
            this.Controls.Add(this.CustomerLabel);
            this.Name = "CustomerChart";
            this.Text = "CustomerChart";
            ((System.ComponentModel.ISupportInitialize)(this.customer_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart customer_chart;
        private System.Windows.Forms.Label CustomerLabel;
    }
}