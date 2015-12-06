namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormMain
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
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonEventsForm = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonCheckins = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStatusText = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.btnStatisics = new System.Windows.Forms.Button();
            this.btnStatuses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFriends
            // 
            this.buttonFriends.Enabled = false;
            this.buttonFriends.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFriends.Location = new System.Drawing.Point(149, 251);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(92, 40);
            this.buttonFriends.TabIndex = 0;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonEventsForm
            // 
            this.buttonEventsForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEventsForm.Location = new System.Drawing.Point(417, 251);
            this.buttonEventsForm.Name = "buttonEventsForm";
            this.buttonEventsForm.Size = new System.Drawing.Size(92, 40);
            this.buttonEventsForm.TabIndex = 1;
            this.buttonEventsForm.Text = "Events";
            this.buttonEventsForm.UseVisualStyleBackColor = true;
            this.buttonEventsForm.Click += new System.EventHandler(this.buttonEventsForm_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.White;
            this.labelHello.Location = new System.Drawing.Point(12, 18);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(49, 18);
            this.labelHello.TabIndex = 2;
            this.labelHello.Text = "Hello ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(55, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 18);
            this.labelName.TabIndex = 3;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(15, 58);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(127, 143);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 4;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonCheckins
            // 
            this.buttonCheckins.Enabled = false;
            this.buttonCheckins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCheckins.Location = new System.Drawing.Point(283, 251);
            this.buttonCheckins.Name = "buttonCheckins";
            this.buttonCheckins.Size = new System.Drawing.Size(92, 40);
            this.buttonCheckins.TabIndex = 5;
            this.buttonCheckins.Text = "Checkins";
            this.buttonCheckins.UseVisualStyleBackColor = true;
            this.buttonCheckins.Click += new System.EventHandler(this.buttonCheckins_Click);
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPhotos.Location = new System.Drawing.Point(15, 251);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(92, 40);
            this.buttonPhotos.TabIndex = 6;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = true;
            this.buttonPhotos.Click += new System.EventHandler(this.buttonPhotos_Click);
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxAutoLogin.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(15, 207);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(107, 20);
            this.checkBoxAutoLogin.TabIndex = 7;
            this.checkBoxAutoLogin.Text = "Stay Logged";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Post Status:";
            // 
            // textBoxStatusText
            // 
            this.textBoxStatusText.Location = new System.Drawing.Point(151, 79);
            this.textBoxStatusText.Multiline = true;
            this.textBoxStatusText.Name = "textBoxStatusText";
            this.textBoxStatusText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStatusText.Size = new System.Drawing.Size(180, 44);
            this.textBoxStatusText.TabIndex = 9;
            this.textBoxStatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStatusText.TextChanged += new System.EventHandler(this.textBoxStatusText_TextChanged);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPostStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostStatus.Location = new System.Drawing.Point(337, 79);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(84, 44);
            this.buttonPostStatus.TabIndex = 10;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // btnStatisics
            // 
            this.btnStatisics.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStatisics.Location = new System.Drawing.Point(551, 251);
            this.btnStatisics.Name = "btnStatisics";
            this.btnStatisics.Size = new System.Drawing.Size(92, 40);
            this.btnStatisics.TabIndex = 11;
            this.btnStatisics.Text = "Statistics";
            this.btnStatisics.UseVisualStyleBackColor = true;
            this.btnStatisics.Click += new System.EventHandler(this.btnStatisics_Click);
            // 
            // btnStatuses
            // 
            this.btnStatuses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStatuses.Location = new System.Drawing.Point(551, 201);
            this.btnStatuses.Name = "btnStatuses";
            this.btnStatuses.Size = new System.Drawing.Size(92, 40);
            this.btnStatuses.TabIndex = 12;
            this.btnStatuses.Text = "Statuses";
            this.btnStatuses.UseVisualStyleBackColor = true;
            this.btnStatuses.Click += new System.EventHandler(this.btnStatuses_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.fbbackn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 317);
            this.Controls.Add(this.btnStatuses);
            this.Controls.Add(this.btnStatisics);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxStatusText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.buttonCheckins);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonEventsForm);
            this.Controls.Add(this.buttonFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonEventsForm;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonCheckins;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStatusText;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button btnStatisics;
        private System.Windows.Forms.Button btnStatuses;
    }
}
