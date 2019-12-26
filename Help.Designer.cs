namespace RobertOgden
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LstInstructions2 = new System.Windows.Forms.ListBox();
            this.LstInstructions1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Location = new System.Drawing.Point(786, 694);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(201, 23);
            this.BtnReturn.TabIndex = 27;
            this.BtnReturn.Text = "Return to Application";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LstInstructions2
            // 
            this.LstInstructions2.FormattingEnabled = true;
            this.LstInstructions2.Location = new System.Drawing.Point(3, 265);
            this.LstInstructions2.Name = "LstInstructions2";
            this.LstInstructions2.Size = new System.Drawing.Size(1007, 420);
            this.LstInstructions2.TabIndex = 0;
            // 
            // LstInstructions1
            // 
            this.LstInstructions1.FormattingEnabled = true;
            this.LstInstructions1.Location = new System.Drawing.Point(3, 12);
            this.LstInstructions1.Name = "LstInstructions1";
            this.LstInstructions1.Size = new System.Drawing.Size(725, 251);
            this.LstInstructions1.TabIndex = 2;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LstInstructions1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LstInstructions2);
            this.Name = "FrmHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ListBox LstInstructions2;
        private System.Windows.Forms.ListBox LstInstructions1;
    }
}