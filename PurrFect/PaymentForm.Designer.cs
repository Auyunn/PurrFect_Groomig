namespace PurrFect
{
    partial class PaymentForm
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
            this.BillsP = new System.Windows.Forms.Panel();
            this.BillsL = new System.Windows.Forms.Label();
            this.PaymentGB = new System.Windows.Forms.GroupBox();
            this.CardRB = new System.Windows.Forms.RadioButton();
            this.CashRB = new System.Windows.Forms.RadioButton();
            this.OnlineBankRB = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ProceedBTN = new System.Windows.Forms.Button();
            this.PaymentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillsP
            // 
            this.BillsP.BackColor = System.Drawing.Color.White;
            this.BillsP.Location = new System.Drawing.Point(37, 63);
            this.BillsP.Name = "BillsP";
            this.BillsP.Size = new System.Drawing.Size(453, 576);
            this.BillsP.TabIndex = 0;
            // 
            // BillsL
            // 
            this.BillsL.AutoSize = true;
            this.BillsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsL.Location = new System.Drawing.Point(39, 20);
            this.BillsL.Name = "BillsL";
            this.BillsL.Size = new System.Drawing.Size(103, 25);
            this.BillsL.TabIndex = 1;
            this.BillsL.Text = "Your Bills";
            // 
            // PaymentGB
            // 
            this.PaymentGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PaymentGB.Controls.Add(this.listBox1);
            this.PaymentGB.Controls.Add(this.OnlineBankRB);
            this.PaymentGB.Controls.Add(this.CashRB);
            this.PaymentGB.Controls.Add(this.CardRB);
            this.PaymentGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGB.Location = new System.Drawing.Point(549, 67);
            this.PaymentGB.Name = "PaymentGB";
            this.PaymentGB.Size = new System.Drawing.Size(404, 224);
            this.PaymentGB.TabIndex = 2;
            this.PaymentGB.TabStop = false;
            this.PaymentGB.Text = "Choose Payment Method";
            // 
            // CardRB
            // 
            this.CardRB.AutoSize = true;
            this.CardRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardRB.Location = new System.Drawing.Point(37, 57);
            this.CardRB.Name = "CardRB";
            this.CardRB.Size = new System.Drawing.Size(68, 24);
            this.CardRB.TabIndex = 0;
            this.CardRB.TabStop = true;
            this.CardRB.Text = "Card";
            this.CardRB.UseVisualStyleBackColor = true;
            this.CardRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CashRB
            // 
            this.CashRB.AutoSize = true;
            this.CashRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRB.Location = new System.Drawing.Point(37, 120);
            this.CashRB.Name = "CashRB";
            this.CashRB.Size = new System.Drawing.Size(71, 24);
            this.CashRB.TabIndex = 1;
            this.CashRB.TabStop = true;
            this.CashRB.Text = "Cash";
            this.CashRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CashRB.UseVisualStyleBackColor = true;
            // 
            // OnlineBankRB
            // 
            this.OnlineBankRB.AutoSize = true;
            this.OnlineBankRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineBankRB.Location = new System.Drawing.Point(37, 177);
            this.OnlineBankRB.Name = "OnlineBankRB";
            this.OnlineBankRB.Size = new System.Drawing.Size(141, 24);
            this.OnlineBankRB.TabIndex = 2;
            this.OnlineBankRB.TabStop = true;
            this.OnlineBankRB.Text = "Online Banking";
            this.OnlineBankRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OnlineBankRB.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Maybank2U",
            "Bank Islam Berhad",
            "CIMB",
            "RHB"});
            this.listBox1.Location = new System.Drawing.Point(271, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 24);
            this.listBox1.TabIndex = 3;
            // 
            // ProceedBTN
            // 
            this.ProceedBTN.Location = new System.Drawing.Point(872, 602);
            this.ProceedBTN.Name = "ProceedBTN";
            this.ProceedBTN.Size = new System.Drawing.Size(81, 37);
            this.ProceedBTN.TabIndex = 3;
            this.ProceedBTN.Text = "Proceed";
            this.ProceedBTN.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(981, 694);
            this.Controls.Add(this.ProceedBTN);
            this.Controls.Add(this.PaymentGB);
            this.Controls.Add(this.BillsL);
            this.Controls.Add(this.BillsP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.PaymentGB.ResumeLayout(false);
            this.PaymentGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BillsP;
        private System.Windows.Forms.Label BillsL;
        private System.Windows.Forms.GroupBox PaymentGB;
        private System.Windows.Forms.RadioButton CardRB;
        private System.Windows.Forms.RadioButton OnlineBankRB;
        private System.Windows.Forms.RadioButton CashRB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ProceedBTN;
    }
}