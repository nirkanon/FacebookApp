namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormEvents
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
            this.comboBoxEvents = new System.Windows.Forms.ComboBox();
            this.pictureBoxEventPhoto = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventPlace = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.textBoxEventDate = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEvents
            // 
            this.comboBoxEvents.FormattingEnabled = true;
            this.comboBoxEvents.Location = new System.Drawing.Point(277, 12);
            this.comboBoxEvents.Name = "comboBoxEvents";
            this.comboBoxEvents.Size = new System.Drawing.Size(179, 21);
            this.comboBoxEvents.TabIndex = 0;
            this.comboBoxEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvents_SelectedIndexChanged);
            // 
            // pictureBoxEventPhoto
            // 
            this.pictureBoxEventPhoto.Image = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.facebook_icon;
            this.pictureBoxEventPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEventPhoto.Name = "pictureBoxEventPhoto";
            this.pictureBoxEventPhoto.Size = new System.Drawing.Size(243, 211);
            this.pictureBoxEventPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventPhoto.TabIndex = 1;
            this.pictureBoxEventPhoto.TabStop = false;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.BackColor = System.Drawing.Color.Transparent;
            this.labelEventName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelEventName.ForeColor = System.Drawing.Color.Black;
            this.labelEventName.Location = new System.Drawing.Point(8, 242);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(107, 19);
            this.labelEventName.TabIndex = 2;
            this.labelEventName.Text = "Event Name:";
            // 
            // labelEventPlace
            // 
            this.labelEventPlace.AutoSize = true;
            this.labelEventPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelEventPlace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelEventPlace.ForeColor = System.Drawing.Color.Black;
            this.labelEventPlace.Location = new System.Drawing.Point(8, 271);
            this.labelEventPlace.Name = "labelEventPlace";
            this.labelEventPlace.Size = new System.Drawing.Size(82, 19);
            this.labelEventPlace.TabIndex = 3;
            this.labelEventPlace.Text = "Location:";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEventDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelEventDate.ForeColor = System.Drawing.Color.Black;
            this.labelEventDate.Location = new System.Drawing.Point(8, 298);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(50, 19);
            this.labelEventDate.TabIndex = 4;
            this.labelEventDate.Text = "Date:";
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(116, 241);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxEventName.Size = new System.Drawing.Size(330, 20);
            this.textBoxEventName.TabIndex = 5;
            this.textBoxEventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.Location = new System.Drawing.Point(116, 270);
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxEventLocation.Size = new System.Drawing.Size(330, 20);
            this.textBoxEventLocation.TabIndex = 6;
            this.textBoxEventLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEventDate
            // 
            this.textBoxEventDate.Location = new System.Drawing.Point(116, 299);
            this.textBoxEventDate.Name = "textBoxEventDate";
            this.textBoxEventDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxEventDate.Size = new System.Drawing.Size(124, 20);
            this.textBoxEventDate.TabIndex = 7;
            this.textBoxEventDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel.Location = new System.Drawing.Point(13, 223);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(74, 16);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Event Link";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.Facebook_Events;
            this.ClientSize = new System.Drawing.Size(468, 350);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.textBoxEventDate);
            this.Controls.Add(this.textBoxEventLocation);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.labelEventPlace);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.pictureBoxEventPhoto);
            this.Controls.Add(this.comboBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEvents";
            this.RightToLeftLayout = true;
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxEventPhoto;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventPlace;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.TextBox textBoxEventDate;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}