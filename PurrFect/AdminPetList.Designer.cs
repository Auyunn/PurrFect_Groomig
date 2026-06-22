namespace PurrFect
{
    partial class AdminPetList
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
            this.dataGridViewPetList = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxBreed = new System.Windows.Forms.TextBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.textBoxPetID = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelPetID = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVaccinated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.Label();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPetList
            // 
            this.dataGridViewPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPetList.Location = new System.Drawing.Point(295, 20);
            this.dataGridViewPetList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPetList.Name = "dataGridViewPetList";
            this.dataGridViewPetList.RowHeadersWidth = 82;
            this.dataGridViewPetList.RowTemplate.Height = 33;
            this.dataGridViewPetList.Size = new System.Drawing.Size(550, 227);
            this.dataGridViewPetList.TabIndex = 0;
            this.dataGridViewPetList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPetList_CellClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(716, 650);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(168, 57);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(489, 650);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(168, 57);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(260, 650);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 57);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(382, 441);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(445, 26);
            this.textBoxAge.TabIndex = 23;
            // 
            // textBoxBreed
            // 
            this.textBoxBreed.Location = new System.Drawing.Point(382, 397);
            this.textBoxBreed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBreed.Name = "textBoxBreed";
            this.textBoxBreed.Size = new System.Drawing.Size(445, 26);
            this.textBoxBreed.TabIndex = 22;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(382, 348);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(445, 26);
            this.textBoxPetName.TabIndex = 21;
            // 
            // textBoxPetID
            // 
            this.textBoxPetID.Location = new System.Drawing.Point(382, 270);
            this.textBoxPetID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPetID.Name = "textBoxPetID";
            this.textBoxPetID.Size = new System.Drawing.Size(445, 26);
            this.textBoxPetID.TabIndex = 19;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(311, 441);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 20);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "Age :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(297, 397);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(60, 20);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Breed :";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(269, 350);
            this.labelMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(87, 20);
            this.labelMethod.TabIndex = 16;
            this.labelMethod.Text = "Pet Name :";
            // 
            // labelPetID
            // 
            this.labelPetID.AutoSize = true;
            this.labelPetID.Location = new System.Drawing.Point(301, 274);
            this.labelPetID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPetID.Name = "labelPetID";
            this.labelPetID.Size = new System.Drawing.Size(58, 20);
            this.labelPetID.TabIndex = 14;
            this.labelPetID.Text = "PetID :";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(382, 488);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(445, 26);
            this.textBoxWeight.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Weight :";
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(382, 529);
            this.textBoxAllergies.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(445, 26);
            this.textBoxAllergies.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 529);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Allergies :";
            // 
            // textBoxVaccinated
            // 
            this.textBoxVaccinated.Location = new System.Drawing.Point(382, 572);
            this.textBoxVaccinated.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVaccinated.Name = "textBoxVaccinated";
            this.textBoxVaccinated.Size = new System.Drawing.Size(445, 26);
            this.textBoxVaccinated.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vaccinated :";
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(301, 313);
            this.userid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(68, 20);
            this.userid.TabIndex = 33;
            this.userid.Text = "UserID :";
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(382, 312);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(445, 28);
            this.comboBoxUserID.TabIndex = 34;
            // 
            // AdminPetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 777);
            this.Controls.Add(this.comboBoxUserID);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.textBoxVaccinated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAllergies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxBreed);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.textBoxPetID);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelPetID);
            this.Controls.Add(this.dataGridViewPetList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPetList";
            this.Text = "AdminPetList";
            this.Load += new System.EventHandler(this.AdminPetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPetList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxBreed;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.TextBox textBoxPetID;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelPetID;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVaccinated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.ComboBox comboBoxUserID;
    }
}