namespace PurrFect
{
    partial class ThankYouForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTagLabel = new System.Windows.Forms.Label();
            this.ReminderLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.ReminderTagLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(282, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANK YOU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(184, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "FOR CHOOSING US";
            // 
            // IDTagLabel
            // 
            this.IDTagLabel.AutoSize = true;
            this.IDTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTagLabel.Location = new System.Drawing.Point(402, 386);
            this.IDTagLabel.Name = "IDTagLabel";
            this.IDTagLabel.Size = new System.Drawing.Size(75, 22);
            this.IDTagLabel.TabIndex = 2;
            this.IDTagLabel.Text = "Your ID:";
            this.IDTagLabel.Click += new System.EventHandler(this.IDTagLabel_Click);
            // 
            // ReminderLabel
            // 
            this.ReminderLabel.AutoSize = true;
            this.ReminderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderLabel.Location = new System.Drawing.Point(388, 417);
            this.ReminderLabel.Name = "ReminderLabel";
            this.ReminderLabel.Size = new System.Drawing.Size(92, 22);
            this.ReminderLabel.TabIndex = 3;
            this.ReminderLabel.Text = "Reminder:";
            this.ReminderLabel.Click += new System.EventHandler(this.ReminderLabel_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(485, 386);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(0, 20);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Click += new System.EventHandler(this.IDlabel_Click);
            // 
            // ReminderTagLabel
            // 
            this.ReminderTagLabel.AutoSize = true;
            this.ReminderTagLabel.Location = new System.Drawing.Point(485, 417);
            this.ReminderTagLabel.Name = "ReminderTagLabel";
            this.ReminderTagLabel.Size = new System.Drawing.Size(0, 20);
            this.ReminderTagLabel.TabIndex = 5;
            this.ReminderTagLabel.Click += new System.EventHandler(this.ReminderTagLabel_Click);
            // 
            // ThankYouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(953, 692);
            this.Controls.Add(this.ReminderTagLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.ReminderLabel);
            this.Controls.Add(this.IDTagLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThankYouForm";
            this.Text = "ThankYouForm";
            this.Load += new System.EventHandler(this.ThankYouForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDTagLabel;
        private System.Windows.Forms.Label ReminderLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label ReminderTagLabel;
    }
}