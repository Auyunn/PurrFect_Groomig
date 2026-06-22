namespace PurrFect
{
    partial class ManageCustomer
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
            this.CustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AdminCountLabel = new System.Windows.Forms.Label();
            this.CustomerCountLabel = new System.Windows.Forms.Label();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.RoleLB = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.TotalUsersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend1);
            this.CustomerChart.Location = new System.Drawing.Point(748, 54);
            this.CustomerChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerChart.Name = "CustomerChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CustomerChart.Series.Add(series1);
            this.CustomerChart.Size = new System.Drawing.Size(452, 325);
            this.CustomerChart.TabIndex = 0;
            this.CustomerChart.Text = "Total Admin and User";
            this.CustomerChart.Click += new System.EventHandler(this.CustomerChart_Click);
            // 
            // AdminCountLabel
            // 
            this.AdminCountLabel.AutoSize = true;
            this.AdminCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCountLabel.Location = new System.Drawing.Point(788, 414);
            this.AdminCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminCountLabel.Name = "AdminCountLabel";
            this.AdminCountLabel.Size = new System.Drawing.Size(0, 31);
            this.AdminCountLabel.TabIndex = 1;
            // 
            // CustomerCountLabel
            // 
            this.CustomerCountLabel.AutoSize = true;
            this.CustomerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCountLabel.Location = new System.Drawing.Point(788, 479);
            this.CustomerCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerCountLabel.Name = "CustomerCountLabel";
            this.CustomerCountLabel.Size = new System.Drawing.Size(0, 31);
            this.CustomerCountLabel.TabIndex = 2;
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(40, 54);
            this.CustomerDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersWidth = 62;
            this.CustomerDGV.RowTemplate.Height = 28;
            this.CustomerDGV.Size = new System.Drawing.Size(640, 325);
            this.CustomerDGV.TabIndex = 3;
            this.CustomerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Location = new System.Drawing.Point(35, 414);
            this.UsernameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(110, 25);
            this.UsernameLB.TabIndex = 4;
            this.UsernameLB.Text = "Username";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(35, 465);
            this.PasswordLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(106, 25);
            this.PasswordLB.TabIndex = 5;
            this.PasswordLB.Text = "Password";
            // 
            // RoleLB
            // 
            this.RoleLB.AutoSize = true;
            this.RoleLB.Location = new System.Drawing.Point(35, 520);
            this.RoleLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLB.Name = "RoleLB";
            this.RoleLB.Size = new System.Drawing.Size(56, 25);
            this.RoleLB.TabIndex = 6;
            this.RoleLB.Text = "Role";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(169, 410);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(255, 31);
            this.UsernameTB.TabIndex = 7;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(169, 465);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(255, 31);
            this.PasswordTB.TabIndex = 8;
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.RoleCB.Location = new System.Drawing.Point(169, 520);
            this.RoleCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(255, 33);
            this.RoleCB.TabIndex = 9;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(45, 652);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(120, 72);
            this.AddBTN.TabIndex = 10;
            this.AddBTN.Text = "ADD";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Location = new System.Drawing.Point(257, 652);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(120, 72);
            this.EditBTN.TabIndex = 11;
            this.EditBTN.Text = "EDIT";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(493, 652);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(120, 72);
            this.DeleteBTN.TabIndex = 12;
            this.DeleteBTN.Text = "DELETE";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // TotalUsersLabel
            // 
            this.TotalUsersLabel.AutoSize = true;
            this.TotalUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUsersLabel.Location = new System.Drawing.Point(743, 410);
            this.TotalUsersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalUsersLabel.Name = "TotalUsersLabel";
            this.TotalUsersLabel.Size = new System.Drawing.Size(0, 29);
            this.TotalUsersLabel.TabIndex = 13;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 835);
            this.Controls.Add(this.TotalUsersLabel);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.RoleCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.RoleLB);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.UsernameLB);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.CustomerCountLabel);
            this.Controls.Add(this.AdminCountLabel);
            this.Controls.Add(this.CustomerChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CustomerChart;
        private System.Windows.Forms.Label AdminCountLabel;
        private System.Windows.Forms.Label CustomerCountLabel;
        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label RoleLB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label TotalUsersLabel;
    }
}