namespace PurrFect
{
    partial class RegisterPetForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelBreed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelAllergies = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBreed = new System.Windows.Forms.TextBox();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.openFileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxVaccinated = new System.Windows.Forms.TextBox();
            this.labelVaccinated = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(46, 108);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 45);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Pet Name :";
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreed.Location = new System.Drawing.Point(115, 193);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(132, 45);
            this.labelBreed.TabIndex = 2;
            this.labelBreed.Text = "Breed :";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(92, 350);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(155, 45);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight :";
            // 
            // labelAllergies
            // 
            this.labelAllergies.AutoSize = true;
            this.labelAllergies.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllergies.Location = new System.Drawing.Point(68, 427);
            this.labelAllergies.Name = "labelAllergies";
            this.labelAllergies.Size = new System.Drawing.Size(179, 45);
            this.labelAllergies.TabIndex = 6;
            this.labelAllergies.Text = "Allergies :";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(268, 108);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(493, 53);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxBreed
            // 
            this.textBoxBreed.Location = new System.Drawing.Point(268, 193);
            this.textBoxBreed.Name = "textBoxBreed";
            this.textBoxBreed.Size = new System.Drawing.Size(277, 35);
            this.textBoxBreed.TabIndex = 9;
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(268, 437);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(277, 35);
            this.textBoxAllergies.TabIndex = 15;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.Pink;
            this.groupBoxDetails.Controls.Add(this.pictureBox1);
            this.groupBoxDetails.Controls.Add(this.textBoxVaccinated);
            this.groupBoxDetails.Controls.Add(this.labelVaccinated);
            this.groupBoxDetails.Controls.Add(this.buttonCancel);
            this.groupBoxDetails.Controls.Add(this.buttonRegister);
            this.groupBoxDetails.Controls.Add(this.textBoxWeight);
            this.groupBoxDetails.Controls.Add(this.textBoxAge);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.textBoxAllergies);
            this.groupBoxDetails.Controls.Add(this.textBoxBreed);
            this.groupBoxDetails.Controls.Add(this.textBoxName);
            this.groupBoxDetails.Controls.Add(this.labelAllergies);
            this.groupBoxDetails.Controls.Add(this.labelWeight);
            this.groupBoxDetails.Controls.Add(this.labelBreed);
            this.groupBoxDetails.Controls.Add(this.labelName);
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.Location = new System.Drawing.Point(53, 64);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(1429, 669);
            this.groupBoxDetails.TabIndex = 16;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Pet Details";
            // 
            // openFileDialogUpload
            // 
            this.openFileDialogUpload.FileName = "openFileDialog1";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(464, 572);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(242, 53);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register Pet";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(801, 572);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(242, 53);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Khaki;
            this.buttonNext.Location = new System.Drawing.Point(1309, 776);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(224, 81);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Khaki;
            this.buttonPrev.Location = new System.Drawing.Point(1064, 776);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(224, 81);
            this.buttonPrev.TabIndex = 22;
            this.buttonPrev.Text = "Previous";
            this.buttonPrev.UseVisualStyleBackColor = false;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(268, 281);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(277, 35);
            this.textBoxAge.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Age :";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(268, 360);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(277, 35);
            this.textBoxWeight.TabIndex = 18;
            // 
            // textBoxVaccinated
            // 
            this.textBoxVaccinated.Location = new System.Drawing.Point(268, 501);
            this.textBoxVaccinated.Name = "textBoxVaccinated";
            this.textBoxVaccinated.Size = new System.Drawing.Size(277, 35);
            this.textBoxVaccinated.TabIndex = 20;
            // 
            // labelVaccinated
            // 
            this.labelVaccinated.AutoSize = true;
            this.labelVaccinated.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaccinated.Location = new System.Drawing.Point(36, 491);
            this.labelVaccinated.Name = "labelVaccinated";
            this.labelVaccinated.Size = new System.Drawing.Size(211, 45);
            this.labelVaccinated.TabIndex = 19;
            this.labelVaccinated.Text = "Vaccinated :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PurrFect.Properties.Resources.PurrfectLogo;
            this.pictureBox1.Location = new System.Drawing.Point(866, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1554, 869);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBoxDetails);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RegisterPetForm";
            this.Text = "RegisterPetForm";
            this.Load += new System.EventHandler(this.RegisterPetForm_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelAllergies;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBreed;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialogUpload;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVaccinated;
        private System.Windows.Forms.Label labelVaccinated;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}