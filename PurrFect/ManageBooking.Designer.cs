
﻿namespace PurrFect
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPackage = new System.Windows.Forms.Label();
            this.lbGroomer = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.dtpDatee = new System.Windows.Forms.DateTimePicker();
            this.cbxGroomer = new System.Windows.Forms.ComboBox();
            this.cbxTimee = new System.Windows.Forms.ComboBox();
            this.lbSummary = new System.Windows.Forms.Label();
            this.txtbxSummary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(514, 83);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.RowTemplate.Height = 28;
            this.dgvBooking.Size = new System.Drawing.Size(529, 295);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(92, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Booking ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(128, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Customer Name:";
            // 
            // lbPackage
            // 
            this.lbPackage.AutoSize = true;
            this.lbPackage.Location = new System.Drawing.Point(40, 173);
            this.lbPackage.Name = "lbPackage";
            this.lbPackage.Size = new System.Drawing.Size(75, 20);
            this.lbPackage.TabIndex = 3;
            this.lbPackage.Text = "Package:";
            // 
            // lbGroomer
            // 
            this.lbGroomer.AutoSize = true;
            this.lbGroomer.Location = new System.Drawing.Point(18, 235);
            this.lbGroomer.Name = "lbGroomer";
            this.lbGroomer.Size = new System.Drawing.Size(122, 20);
            this.lbGroomer.TabIndex = 4;
            this.lbGroomer.Text = "Groomer Name:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(30, 300);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(110, 20);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Booking Date:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(40, 370);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(109, 20);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Booking Time:";
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(514, 463);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(90, 58);
            this.bttnAdd.TabIndex = 11;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(697, 463);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(90, 58);
            this.bttnDelete.TabIndex = 12;
            this.bttnDelete.Text = "DELETE";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(864, 463);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(90, 58);
            this.bttnUpdate.TabIndex = 13;
            this.bttnUpdate.Text = "UPDATE";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(188, 39);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(279, 26);
            this.txtbxID.TabIndex = 14;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(188, 97);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(279, 26);
            this.txtbxName.TabIndex = 15;
            // 
            // cbxPackage
            // 
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(188, 165);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(279, 28);
            this.cbxPackage.TabIndex = 16;
            // 
            // dtpDatee
            // 
            this.dtpDatee.Location = new System.Drawing.Point(188, 294);
            this.dtpDatee.Name = "dtpDatee";
            this.dtpDatee.Size = new System.Drawing.Size(279, 26);
            this.dtpDatee.TabIndex = 18;
            // 
            // cbxGroomer
            // 
            this.cbxGroomer.FormattingEnabled = true;
            this.cbxGroomer.Location = new System.Drawing.Point(188, 227);
            this.cbxGroomer.Name = "cbxGroomer";
            this.cbxGroomer.Size = new System.Drawing.Size(279, 28);
            this.cbxGroomer.TabIndex = 19;
            // 
            // cbxTimee
            // 
            this.cbxTimee.FormattingEnabled = true;
            this.cbxTimee.Location = new System.Drawing.Point(188, 367);
            this.cbxTimee.Name = "cbxTimee";
            this.cbxTimee.Size = new System.Drawing.Size(279, 28);
            this.cbxTimee.TabIndex = 20;
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Location = new System.Drawing.Point(23, 434);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(139, 20);
            this.lbSummary.TabIndex = 21;
            this.lbSummary.Text = "Add-On Summary:";
            // 
            // txtbxSummary
            // 
            this.txtbxSummary.Location = new System.Drawing.Point(188, 431);
            this.txtbxSummary.Multiline = true;
            this.txtbxSummary.Name = "txtbxSummary";
            this.txtbxSummary.Size = new System.Drawing.Size(279, 100);
            this.txtbxSummary.TabIndex = 22;
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.txtbxSummary);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.cbxTimee);
            this.Controls.Add(this.cbxGroomer);
            this.Controls.Add(this.dtpDatee);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbGroomer);
            this.Controls.Add(this.lbPackage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvBooking);
            this.Name = "ManageBooking";
            this.Text = "Booking Management";
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPackage;
        private System.Windows.Forms.Label lbGroomer;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.DateTimePicker dtpDatee;
        private System.Windows.Forms.ComboBox cbxGroomer;
        private System.Windows.Forms.ComboBox cbxTimee;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.TextBox txtbxSummary;
    }

﻿namespace PurrFect
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPackage = new System.Windows.Forms.Label();
            this.lbGroomer = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.dtpDatee = new System.Windows.Forms.DateTimePicker();
            this.cbxGroomer = new System.Windows.Forms.ComboBox();
            this.cbxTimee = new System.Windows.Forms.ComboBox();
            this.lbSummary = new System.Windows.Forms.Label();
            this.txtbxSummary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(514, 83);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.RowTemplate.Height = 28;
            this.dgvBooking.Size = new System.Drawing.Size(529, 295);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(92, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Booking ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(128, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Customer Name:";
            // 
            // lbPackage
            // 
            this.lbPackage.AutoSize = true;
            this.lbPackage.Location = new System.Drawing.Point(40, 173);
            this.lbPackage.Name = "lbPackage";
            this.lbPackage.Size = new System.Drawing.Size(75, 20);
            this.lbPackage.TabIndex = 3;
            this.lbPackage.Text = "Package:";
            // 
            // lbGroomer
            // 
            this.lbGroomer.AutoSize = true;
            this.lbGroomer.Location = new System.Drawing.Point(18, 235);
            this.lbGroomer.Name = "lbGroomer";
            this.lbGroomer.Size = new System.Drawing.Size(122, 20);
            this.lbGroomer.TabIndex = 4;
            this.lbGroomer.Text = "Groomer Name:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(30, 300);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(110, 20);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Booking Date:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(40, 370);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(109, 20);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Booking Time:";
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(514, 463);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(90, 58);
            this.bttnAdd.TabIndex = 11;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(697, 463);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(90, 58);
            this.bttnDelete.TabIndex = 12;
            this.bttnDelete.Text = "DELETE";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(864, 463);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(90, 58);
            this.bttnUpdate.TabIndex = 13;
            this.bttnUpdate.Text = "UPDATE";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(188, 39);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(279, 26);
            this.txtbxID.TabIndex = 14;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(188, 97);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(279, 26);
            this.txtbxName.TabIndex = 15;
            // 
            // cbxPackage
            // 
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(188, 165);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(279, 28);
            this.cbxPackage.TabIndex = 16;
            // 
            // dtpDatee
            // 
            this.dtpDatee.Location = new System.Drawing.Point(188, 294);
            this.dtpDatee.Name = "dtpDatee";
            this.dtpDatee.Size = new System.Drawing.Size(279, 26);
            this.dtpDatee.TabIndex = 18;
            // 
            // cbxGroomer
            // 
            this.cbxGroomer.FormattingEnabled = true;
            this.cbxGroomer.Location = new System.Drawing.Point(188, 227);
            this.cbxGroomer.Name = "cbxGroomer";
            this.cbxGroomer.Size = new System.Drawing.Size(279, 28);
            this.cbxGroomer.TabIndex = 19;
            // 
            // cbxTimee
            // 
            this.cbxTimee.FormattingEnabled = true;
            this.cbxTimee.Location = new System.Drawing.Point(188, 367);
            this.cbxTimee.Name = "cbxTimee";
            this.cbxTimee.Size = new System.Drawing.Size(279, 28);
            this.cbxTimee.TabIndex = 20;
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Location = new System.Drawing.Point(23, 434);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(139, 20);
            this.lbSummary.TabIndex = 21;
            this.lbSummary.Text = "Add-On Summary:";
            // 
            // txtbxSummary
            // 
            this.txtbxSummary.Location = new System.Drawing.Point(188, 431);
            this.txtbxSummary.Multiline = true;
            this.txtbxSummary.Name = "txtbxSummary";
            this.txtbxSummary.Size = new System.Drawing.Size(279, 100);
            this.txtbxSummary.TabIndex = 22;
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.txtbxSummary);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.cbxTimee);
            this.Controls.Add(this.cbxGroomer);
            this.Controls.Add(this.dtpDatee);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbGroomer);
            this.Controls.Add(this.lbPackage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvBooking);
            this.Name = "ManageBooking";
            this.Text = "Booking Management";
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPackage;
        private System.Windows.Forms.Label lbGroomer;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.DateTimePicker dtpDatee;
        private System.Windows.Forms.ComboBox cbxGroomer;
        private System.Windows.Forms.ComboBox cbxTimee;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.TextBox txtbxSummary;
    }

}