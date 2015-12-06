namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormPhotos
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.radioButtonGrayscaleBits = new System.Windows.Forms.RadioButton();
            this.radioButtonGrayscaleDraw = new System.Windows.Forms.RadioButton();
            this.radioButtonTransDraw = new System.Windows.Forms.RadioButton();
            this.radioButtonNegativeBits = new System.Windows.Forms.RadioButton();
            this.radioButtonNegativeDraw = new System.Windows.Forms.RadioButton();
            this.radioButtonTransBits = new System.Windows.Forms.RadioButton();
            this.radioButtonSepiaBits = new System.Windows.Forms.RadioButton();
            this.radioButtonSepiaDraw = new System.Windows.Forms.RadioButton();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNewPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginalPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOpenFile.Location = new System.Drawing.Point(78, 15);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(125, 45);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Load Photo";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // radioButtonGrayscaleBits
            // 
            this.radioButtonGrayscaleBits.AutoSize = true;
            this.radioButtonGrayscaleBits.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGrayscaleBits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGrayscaleBits.ForeColor = System.Drawing.Color.White;
            this.radioButtonGrayscaleBits.Location = new System.Drawing.Point(274, 66);
            this.radioButtonGrayscaleBits.Name = "radioButtonGrayscaleBits";
            this.radioButtonGrayscaleBits.Size = new System.Drawing.Size(124, 20);
            this.radioButtonGrayscaleBits.TabIndex = 4;
            this.radioButtonGrayscaleBits.TabStop = true;
            this.radioButtonGrayscaleBits.Tag = "0";
            this.radioButtonGrayscaleBits.Text = "Grayscale - Bits";
            this.radioButtonGrayscaleBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonGrayscaleBits.UseVisualStyleBackColor = false;
            this.radioButtonGrayscaleBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonGrayscaleDraw
            // 
            this.radioButtonGrayscaleDraw.AutoSize = true;
            this.radioButtonGrayscaleDraw.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonGrayscaleDraw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGrayscaleDraw.ForeColor = System.Drawing.Color.White;
            this.radioButtonGrayscaleDraw.Location = new System.Drawing.Point(274, 92);
            this.radioButtonGrayscaleDraw.Name = "radioButtonGrayscaleDraw";
            this.radioButtonGrayscaleDraw.Size = new System.Drawing.Size(134, 20);
            this.radioButtonGrayscaleDraw.TabIndex = 5;
            this.radioButtonGrayscaleDraw.TabStop = true;
            this.radioButtonGrayscaleDraw.Tag = "1";
            this.radioButtonGrayscaleDraw.Text = "Grayscale - Draw";
            this.radioButtonGrayscaleDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonGrayscaleDraw.UseVisualStyleBackColor = false;
            this.radioButtonGrayscaleDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonTransDraw
            // 
            this.radioButtonTransDraw.AutoSize = true;
            this.radioButtonTransDraw.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTransDraw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonTransDraw.ForeColor = System.Drawing.Color.White;
            this.radioButtonTransDraw.Location = new System.Drawing.Point(274, 120);
            this.radioButtonTransDraw.Name = "radioButtonTransDraw";
            this.radioButtonTransDraw.Size = new System.Drawing.Size(156, 20);
            this.radioButtonTransDraw.TabIndex = 6;
            this.radioButtonTransDraw.TabStop = true;
            this.radioButtonTransDraw.Tag = "2";
            this.radioButtonTransDraw.Text = "Transparency - Draw";
            this.radioButtonTransDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTransDraw.UseVisualStyleBackColor = false;
            this.radioButtonTransDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonNegativeBits
            // 
            this.radioButtonNegativeBits.AutoSize = true;
            this.radioButtonNegativeBits.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNegativeBits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonNegativeBits.ForeColor = System.Drawing.Color.White;
            this.radioButtonNegativeBits.Location = new System.Drawing.Point(274, 150);
            this.radioButtonNegativeBits.Name = "radioButtonNegativeBits";
            this.radioButtonNegativeBits.Size = new System.Drawing.Size(117, 20);
            this.radioButtonNegativeBits.TabIndex = 7;
            this.radioButtonNegativeBits.TabStop = true;
            this.radioButtonNegativeBits.Tag = "3";
            this.radioButtonNegativeBits.Text = "Negative - Bits";
            this.radioButtonNegativeBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonNegativeBits.UseVisualStyleBackColor = false;
            this.radioButtonNegativeBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonNegativeDraw
            // 
            this.radioButtonNegativeDraw.AutoSize = true;
            this.radioButtonNegativeDraw.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNegativeDraw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonNegativeDraw.ForeColor = System.Drawing.Color.White;
            this.radioButtonNegativeDraw.Location = new System.Drawing.Point(274, 176);
            this.radioButtonNegativeDraw.Name = "radioButtonNegativeDraw";
            this.radioButtonNegativeDraw.Size = new System.Drawing.Size(127, 20);
            this.radioButtonNegativeDraw.TabIndex = 8;
            this.radioButtonNegativeDraw.TabStop = true;
            this.radioButtonNegativeDraw.Tag = "4";
            this.radioButtonNegativeDraw.Text = "Negative - Draw";
            this.radioButtonNegativeDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonNegativeDraw.UseVisualStyleBackColor = false;
            this.radioButtonNegativeDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonTransBits
            // 
            this.radioButtonTransBits.AutoSize = true;
            this.radioButtonTransBits.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTransBits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonTransBits.ForeColor = System.Drawing.Color.White;
            this.radioButtonTransBits.Location = new System.Drawing.Point(274, 206);
            this.radioButtonTransBits.Name = "radioButtonTransBits";
            this.radioButtonTransBits.Size = new System.Drawing.Size(146, 20);
            this.radioButtonTransBits.TabIndex = 9;
            this.radioButtonTransBits.TabStop = true;
            this.radioButtonTransBits.Tag = "5";
            this.radioButtonTransBits.Text = "Transparency - Bits";
            this.radioButtonTransBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTransBits.UseVisualStyleBackColor = false;
            this.radioButtonTransBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonSepiaBits
            // 
            this.radioButtonSepiaBits.AutoSize = true;
            this.radioButtonSepiaBits.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSepiaBits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonSepiaBits.ForeColor = System.Drawing.Color.White;
            this.radioButtonSepiaBits.Location = new System.Drawing.Point(274, 232);
            this.radioButtonSepiaBits.Name = "radioButtonSepiaBits";
            this.radioButtonSepiaBits.Size = new System.Drawing.Size(133, 20);
            this.radioButtonSepiaBits.TabIndex = 10;
            this.radioButtonSepiaBits.TabStop = true;
            this.radioButtonSepiaBits.Tag = "6";
            this.radioButtonSepiaBits.Text = "Sepia Tone - Bits";
            this.radioButtonSepiaBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSepiaBits.UseVisualStyleBackColor = false;
            this.radioButtonSepiaBits.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // radioButtonSepiaDraw
            // 
            this.radioButtonSepiaDraw.AutoSize = true;
            this.radioButtonSepiaDraw.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSepiaDraw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonSepiaDraw.ForeColor = System.Drawing.Color.White;
            this.radioButtonSepiaDraw.Location = new System.Drawing.Point(274, 258);
            this.radioButtonSepiaDraw.Name = "radioButtonSepiaDraw";
            this.radioButtonSepiaDraw.Size = new System.Drawing.Size(143, 20);
            this.radioButtonSepiaDraw.TabIndex = 11;
            this.radioButtonSepiaDraw.TabStop = true;
            this.radioButtonSepiaDraw.Tag = "7";
            this.radioButtonSepiaDraw.Text = "Sepia Tone - Draw";
            this.radioButtonSepiaDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSepiaDraw.UseVisualStyleBackColor = false;
            this.radioButtonSepiaDraw.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(475, 70);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMessage.Size = new System.Drawing.Size(206, 20);
            this.textBoxMessage.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(433, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Title:";
            // 
            // pictureBoxNewPicture
            // 
            this.pictureBoxNewPicture.Image = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.facebook_icon;
            this.pictureBoxNewPicture.Location = new System.Drawing.Point(429, 96);
            this.pictureBoxNewPicture.Name = "pictureBoxNewPicture";
            this.pictureBoxNewPicture.Size = new System.Drawing.Size(254, 235);
            this.pictureBoxNewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNewPicture.TabIndex = 3;
            this.pictureBoxNewPicture.TabStop = false;
            // 
            // pictureBoxOriginalPicture
            // 
            this.pictureBoxOriginalPicture.Image = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.facebook_icon;
            this.pictureBoxOriginalPicture.Location = new System.Drawing.Point(12, 91);
            this.pictureBoxOriginalPicture.Name = "pictureBoxOriginalPicture";
            this.pictureBoxOriginalPicture.Size = new System.Drawing.Size(254, 240);
            this.pictureBoxOriginalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginalPicture.TabIndex = 2;
            this.pictureBoxOriginalPicture.TabStop = false;
            // 
            // FormPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.mzl_shrwbzbt;
            this.ClientSize = new System.Drawing.Size(695, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.radioButtonSepiaDraw);
            this.Controls.Add(this.radioButtonSepiaBits);
            this.Controls.Add(this.radioButtonTransBits);
            this.Controls.Add(this.radioButtonNegativeDraw);
            this.Controls.Add(this.radioButtonNegativeBits);
            this.Controls.Add(this.radioButtonTransDraw);
            this.Controls.Add(this.radioButtonGrayscaleDraw);
            this.Controls.Add(this.radioButtonGrayscaleBits);
            this.Controls.Add(this.pictureBoxNewPicture);
            this.Controls.Add(this.pictureBoxOriginalPicture);
            this.Controls.Add(this.buttonOpenFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPhotos";
            this.Text = "PhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.PictureBox pictureBoxOriginalPicture;
        private System.Windows.Forms.PictureBox pictureBoxNewPicture;
        private System.Windows.Forms.RadioButton radioButtonGrayscaleBits;
        private System.Windows.Forms.RadioButton radioButtonGrayscaleDraw;
        private System.Windows.Forms.RadioButton radioButtonTransDraw;
        private System.Windows.Forms.RadioButton radioButtonNegativeBits;
        private System.Windows.Forms.RadioButton radioButtonNegativeDraw;
        private System.Windows.Forms.RadioButton radioButtonTransBits;
        private System.Windows.Forms.RadioButton radioButtonSepiaBits;
        private System.Windows.Forms.RadioButton radioButtonSepiaDraw;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
    }
}