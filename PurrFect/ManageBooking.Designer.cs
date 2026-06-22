namespace PurrFect
{
    partial class ManageBooking
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.lbBooking = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBStatus = new System.Windows.Forms.TextBox();
            this.TBGroomerID = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.TBServiceID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBTotPrice = new System.Windows.Forms.TextBox();
            this.TBPetID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(569, 46);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.RowTemplate.Height = 28;
            this.dgvBooking.Size = new System.Drawing.Size(561, 351);
            this.dgvBooking.TabIndex = 2;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick_1);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(30, 112);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(58, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "Pet ID:";
            // 
            // lbBooking
            // 
            this.lbBooking.AutoSize = true;
            this.lbBooking.Location = new System.Drawing.Point(28, 59);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(92, 20);
            this.lbBooking.TabIndex = 5;
            this.lbBooking.Text = "Booking ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Groomer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Booking Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Booking Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // TBStatus
            // 
            this.TBStatus.Location = new System.Drawing.Point(187, 389);
            this.TBStatus.Name = "TBStatus";
            this.TBStatus.Size = new System.Drawing.Size(313, 26);
            this.TBStatus.TabIndex = 13;
            // 
            // TBGroomerID
            // 
            this.TBGroomerID.FormattingEnabled = true;
            this.TBGroomerID.Location = new System.Drawing.Point(187, 165);
            this.TBGroomerID.Name = "TBGroomerID";
            this.TBGroomerID.Size = new System.Drawing.Size(313, 28);
            this.TBGroomerID.TabIndex = 14;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "10:00",
            "12:00",
            "2:00",
            "4:00"});
            this.cbTime.Location = new System.Drawing.Point(187, 325);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(313, 28);
            this.cbTime.TabIndex = 15;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(187, 278);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(313, 26);
            this.dtpDate.TabIndex = 17;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(591, 422);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(90, 58);
            this.bttnAdd.TabIndex = 18;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(808, 422);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(90, 58);
            this.bttnEdit.TabIndex = 19;
            this.bttnEdit.Text = "EDIT";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(1003, 422);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(90, 58);
            this.bttnDelete.TabIndex = 20;
            this.bttnDelete.Text = "DELETE";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(187, 56);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(313, 26);
            this.txtbxID.TabIndex = 21;
            // 
            // TBServiceID
            // 
            this.TBServiceID.FormattingEnabled = true;
            this.TBServiceID.Location = new System.Drawing.Point(187, 214);
            this.TBServiceID.Name = "TBServiceID";
            this.TBServiceID.Size = new System.Drawing.Size(313, 28);
            this.TBServiceID.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Price RM:";
            // 
            // TBTotPrice
            // 
            this.TBTotPrice.Location = new System.Drawing.Point(187, 454);
            this.TBTotPrice.Name = "TBTotPrice";
            this.TBTotPrice.Size = new System.Drawing.Size(313, 26);
            this.TBTotPrice.TabIndex = 24;
            // 
            // TBPetID
            // 
            this.TBPetID.FormattingEnabled = true;
            this.TBPetID.Location = new System.Drawing.Point(187, 112);
            this.TBPetID.Name = "TBPetID";
            this.TBPetID.Size = new System.Drawing.Size(313, 28);
            this.TBPetID.TabIndex = 25;
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1142, 544);
            this.Controls.Add(this.TBPetID);
            this.Controls.Add(this.TBTotPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBServiceID);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.TBGroomerID);
            this.Controls.Add(this.TBStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBooking);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvBooking);
            this.Name = "ManageBooking";
            this.Text = "ManageBooking";
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBStatus;
        private System.Windows.Forms.ComboBox TBGroomerID;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.ComboBox TBServiceID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBTotPrice;
        private System.Windows.Forms.ComboBox TBPetID;
    }
}