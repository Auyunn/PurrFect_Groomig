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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxVaccinated = new System.Windows.Forms.TextBox();
            this.labelVaccinated = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(34, 86);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(143, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Pet Name :";
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreed.Location = new System.Drawing.Point(86, 154);
            this.labelBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(97, 32);
            this.labelBreed.TabIndex = 2;
            this.labelBreed.Text = "Breed :";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(69, 280);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(114, 32);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight :";
            // 
            // labelAllergies
            // 
            this.labelAllergies.AutoSize = true;
            this.labelAllergies.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllergies.Location = new System.Drawing.Point(51, 342);
            this.labelAllergies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllergies.Name = "labelAllergies";
            this.labelAllergies.Size = new System.Drawing.Size(131, 32);
            this.labelAllergies.TabIndex = 6;
            this.labelAllergies.Text = "Allergies :";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(201, 86);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(371, 43);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxBreed
            // 
            this.textBoxBreed.Location = new System.Drawing.Point(201, 154);
            this.textBoxBreed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBreed.Name = "textBoxBreed";
            this.textBoxBreed.Size = new System.Drawing.Size(209, 28);
            this.textBoxBreed.TabIndex = 9;
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(201, 350);
            this.textBoxAllergies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(209, 28);
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
            this.groupBoxDetails.Location = new System.Drawing.Point(40, 51);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDetails.Size = new System.Drawing.Size(1072, 535);
            this.groupBoxDetails.TabIndex = 16;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Pet Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PurrFect.Properties.Resources.PurrfectLogo;
            this.pictureBox1.Location = new System.Drawing.Point(650, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxVaccinated
            // 
            this.textBoxVaccinated.Location = new System.Drawing.Point(201, 401);
            this.textBoxVaccinated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVaccinated.Name = "textBoxVaccinated";
            this.textBoxVaccinated.Size = new System.Drawing.Size(209, 28);
            this.textBoxVaccinated.TabIndex = 20;
            // 
            // labelVaccinated
            // 
            this.labelVaccinated.AutoSize = true;
            this.labelVaccinated.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaccinated.Location = new System.Drawing.Point(27, 393);
            this.labelVaccinated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVaccinated.Name = "labelVaccinated";
            this.labelVaccinated.Size = new System.Drawing.Size(156, 32);
            this.labelVaccinated.TabIndex = 19;
            this.labelVaccinated.Text = "Vaccinated :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(601, 458);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(182, 42);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(348, 458);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(182, 42);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register Pet";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(201, 288);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(209, 28);
            this.textBoxWeight.TabIndex = 18;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(201, 225);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(209, 28);
            this.textBoxAge.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Age :";
            // 
            // openFileDialogUpload
            // 
            this.openFileDialogUpload.FileName = "openFileDialog1";
            // 
            // RegisterPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1160, 625);
            this.Controls.Add(this.groupBoxDetails);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVaccinated;
        private System.Windows.Forms.Label labelVaccinated;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}