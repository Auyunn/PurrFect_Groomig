namespace PurrFect
{
    partial class ManageGroomer
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
            this.dgvGroomer = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxSalary = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroomer
            // 
            this.dgvGroomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroomer.Location = new System.Drawing.Point(488, 53);
            this.dgvGroomer.Name = "dgvGroomer";
            this.dgvGroomer.RowHeadersWidth = 62;
            this.dgvGroomer.RowTemplate.Height = 28;
            this.dgvGroomer.Size = new System.Drawing.Size(529, 295);
            this.dgvGroomer.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(35, 71);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(97, 20);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Groomer ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 132);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(122, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Groomer Name:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(35, 188);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(119, 20);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Number Phone:";
            this.lbPhone.Click += new System.EventHandler(this.lbPhone_Click);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(35, 246);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(124, 20);
            this.lbSalary.TabIndex = 5;
            this.lbSalary.Text = "Groomer Salary:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(40, 308);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(127, 20);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Groomer Status:";
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(181, 71);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(279, 26);
            this.txtbxID.TabIndex = 15;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(181, 132);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(279, 26);
            this.txtbxName.TabIndex = 16;
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(181, 188);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(279, 26);
            this.txtbxPhone.TabIndex = 17;
            // 
            // txtbxSalary
            // 
            this.txtbxSalary.Location = new System.Drawing.Point(181, 243);
            this.txtbxSalary.Name = "txtbxSalary";
            this.txtbxSalary.Size = new System.Drawing.Size(279, 26);
            this.txtbxSalary.TabIndex = 18;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(181, 305);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(279, 28);
            this.cbxStatus.TabIndex = 21;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(44, 396);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(90, 58);
            this.bttnAdd.TabIndex = 22;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(214, 396);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(90, 58);
            this.bttnDelete.TabIndex = 23;
            this.bttnDelete.Text = "DELETE";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(381, 396);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(90, 58);
            this.bttnUpdate.TabIndex = 24;
            this.bttnUpdate.Text = "UPDATE";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // ManageGroomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1029, 495);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.txtbxSalary);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvGroomer);
            this.Name = "ManageGroomer";
            this.Text = "ManageGroomer Form";
            this.Load += new System.EventHandler(this.ManageGroomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroomer;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxSalary;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
    }
}