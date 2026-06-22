namespace PurrFect
{
    partial class AdminPayment
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
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.labelPaymentID = new System.Windows.Forms.Label();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxPaymentID = new System.Windows.Forms.TextBox();
            this.textBoxBookingID = new System.Windows.Forms.TextBox();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(296, 35);
            this.dataGridViewPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 82;
            this.dataGridViewPayment.RowTemplate.Height = 33;
            this.dataGridViewPayment.Size = new System.Drawing.Size(550, 227);
            this.dataGridViewPayment.TabIndex = 0;
            this.dataGridViewPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPayment_CellClick);
            // 
            // labelPaymentID
            // 
            this.labelPaymentID.AutoSize = true;
            this.labelPaymentID.Location = new System.Drawing.Point(288, 313);
            this.labelPaymentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaymentID.Name = "labelPaymentID";
            this.labelPaymentID.Size = new System.Drawing.Size(96, 20);
            this.labelPaymentID.TabIndex = 1;
            this.labelPaymentID.Text = "PaymentID :";
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Location = new System.Drawing.Point(288, 366);
            this.labelBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(92, 20);
            this.labelBookingID.TabIndex = 2;
            this.labelBookingID.Text = "BookingID :";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(240, 416);
            this.labelMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(137, 20);
            this.labelMethod.TabIndex = 3;
            this.labelMethod.Text = "Payment Method :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(260, 478);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(118, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Payment Date :";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(307, 539);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(73, 20);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount :";
            // 
            // textBoxPaymentID
            // 
            this.textBoxPaymentID.Location = new System.Drawing.Point(402, 308);
            this.textBoxPaymentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPaymentID.Name = "textBoxPaymentID";
            this.textBoxPaymentID.Size = new System.Drawing.Size(445, 26);
            this.textBoxPaymentID.TabIndex = 6;
            // 
            // textBoxBookingID
            // 
            this.textBoxBookingID.Location = new System.Drawing.Point(402, 364);
            this.textBoxBookingID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBookingID.Name = "textBoxBookingID";
            this.textBoxBookingID.Size = new System.Drawing.Size(445, 26);
            this.textBoxBookingID.TabIndex = 7;
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(402, 416);
            this.textBoxMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(445, 26);
            this.textBoxMethod.TabIndex = 8;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(402, 478);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(445, 26);
            this.textBoxDate.TabIndex = 9;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(402, 539);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(445, 26);
            this.textBoxAmount.TabIndex = 10;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(419, 596);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(168, 57);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(646, 596);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(168, 57);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AdminPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 695);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxBookingID);
            this.Controls.Add(this.textBoxPaymentID);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelBookingID);
            this.Controls.Add(this.labelPaymentID);
            this.Controls.Add(this.dataGridViewPayment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPayment";
            this.Text = "AdminPayment";
            this.Load += new System.EventHandler(this.AdminPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.Label labelPaymentID;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxPaymentID;
        private System.Windows.Forms.TextBox textBoxBookingID;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}