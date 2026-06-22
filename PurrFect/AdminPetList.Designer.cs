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
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPetID = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.labelPetID = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVaccinated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPetList
            // 
            this.dataGridViewPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPetList.Location = new System.Drawing.Point(393, 25);
            this.dataGridViewPetList.Name = "dataGridViewPetList";
            this.dataGridViewPetList.RowHeadersWidth = 82;
            this.dataGridViewPetList.RowTemplate.Height = 33;
            this.dataGridViewPetList.Size = new System.Drawing.Size(733, 284);
            this.dataGridViewPetList.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(954, 773);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(224, 71);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(652, 773);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(224, 71);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(346, 773);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(224, 71);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(509, 558);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(592, 31);
            this.textBoxAge.TabIndex = 23;
            // 
            // textBoxBreed
            // 
            this.textBoxBreed.Location = new System.Drawing.Point(509, 503);
            this.textBoxBreed.Name = "textBoxBreed";
            this.textBoxBreed.Size = new System.Drawing.Size(592, 31);
            this.textBoxBreed.TabIndex = 22;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(509, 441);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(592, 31);
            this.textBoxPetName.TabIndex = 21;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(509, 390);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(592, 31);
            this.textBoxUserID.TabIndex = 20;
            // 
            // textBoxPetID
            // 
            this.textBoxPetID.Location = new System.Drawing.Point(509, 337);
            this.textBoxPetID.Name = "textBoxPetID";
            this.textBoxPetID.Size = new System.Drawing.Size(592, 31);
            this.textBoxPetID.TabIndex = 19;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(415, 558);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(62, 25);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "Age :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(396, 503);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(81, 25);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Breed :";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(359, 444);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(118, 25);
            this.labelMethod.TabIndex = 16;
            this.labelMethod.Text = "Pet Name :";
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Location = new System.Drawing.Point(388, 390);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(89, 25);
            this.labelBookingID.TabIndex = 15;
            this.labelBookingID.Text = "UserID :";
            // 
            // labelPetID
            // 
            this.labelPetID.AutoSize = true;
            this.labelPetID.Location = new System.Drawing.Point(401, 343);
            this.labelPetID.Name = "labelPetID";
            this.labelPetID.Size = new System.Drawing.Size(76, 25);
            this.labelPetID.TabIndex = 14;
            this.labelPetID.Text = "PetID :";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(509, 616);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(592, 31);
            this.textBoxWeight.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Weight :";
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(509, 667);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(592, 31);
            this.textBoxAllergies.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Allergies :";
            // 
            // textBoxVaccinated
            // 
            this.textBoxVaccinated.Location = new System.Drawing.Point(509, 721);
            this.textBoxVaccinated.Name = "textBoxVaccinated";
            this.textBoxVaccinated.Size = new System.Drawing.Size(592, 31);
            this.textBoxVaccinated.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vaccinated :";
            // 
            // AdminPetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1554, 869);
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
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.textBoxPetID);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelBookingID);
            this.Controls.Add(this.labelPetID);
            this.Controls.Add(this.dataGridViewPetList);
            this.Name = "AdminPetList";
            this.Text = "AdminPetList";
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
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxPetID;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.Label labelPetID;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVaccinated;
        private System.Windows.Forms.Label label3;
    }
}