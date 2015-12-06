namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormFriends
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
            this.components = new System.ComponentModel.Container();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastStatus = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBirthDay = new System.Windows.Forms.TextBox();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.textBoxHometown = new System.Windows.Forms.TextBox();
            this.labelHometown = new System.Windows.Forms.Label();
            this.textBoxSearchFriends = new System.Windows.Forms.TextBox();
            this.buttonSearchFriends = new System.Windows.Forms.Button();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendListBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 39);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 355);
            this.listBoxFriends.TabIndex = 0;
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.friendListBindingSource, "ImageLarge", true));
            this.pictureBoxFriendProfile.Image = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.square_profile_pic_male;
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(451, 10);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(151, 161);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfile.TabIndex = 1;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(200, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelLastStatus
            // 
            this.labelLastStatus.AutoSize = true;
            this.labelLastStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelLastStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastStatus.ForeColor = System.Drawing.Color.White;
            this.labelLastStatus.Location = new System.Drawing.Point(138, 174);
            this.labelLastStatus.Name = "labelLastStatus";
            this.labelLastStatus.Size = new System.Drawing.Size(65, 16);
            this.labelLastStatus.TabIndex = 3;
            this.labelLastStatus.Text = "Statuses:";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Name", true));
            this.textBoxName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxName.Location = new System.Drawing.Point(257, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxBirthDay
            // 
            this.textBoxBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Birthday", true));
            this.textBoxBirthDay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxBirthDay.Location = new System.Drawing.Point(257, 53);
            this.textBoxBirthDay.Name = "textBoxBirthDay";
            this.textBoxBirthDay.Size = new System.Drawing.Size(149, 22);
            this.textBoxBirthDay.TabIndex = 7;
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBirthDay.ForeColor = System.Drawing.Color.White;
            this.labelBirthDay.Location = new System.Drawing.Point(186, 53);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(65, 16);
            this.labelBirthDay.TabIndex = 6;
            this.labelBirthDay.Text = "Birthday:";
            // 
            // textBoxHometown
            // 
            this.textBoxHometown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Hometown.Name", true));
            this.textBoxHometown.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxHometown.Location = new System.Drawing.Point(257, 83);
            this.textBoxHometown.Name = "textBoxHometown";
            this.textBoxHometown.Size = new System.Drawing.Size(149, 22);
            this.textBoxHometown.TabIndex = 9;
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.BackColor = System.Drawing.Color.Transparent;
            this.labelHometown.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelHometown.ForeColor = System.Drawing.Color.White;
            this.labelHometown.Location = new System.Drawing.Point(215, 86);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(36, 16);
            this.labelHometown.TabIndex = 8;
            this.labelHometown.Text = "City:";
            // 
            // textBoxSearchFriends
            // 
            this.textBoxSearchFriends.Location = new System.Drawing.Point(12, 10);
            this.textBoxSearchFriends.Name = "textBoxSearchFriends";
            this.textBoxSearchFriends.Size = new System.Drawing.Size(76, 20);
            this.textBoxSearchFriends.TabIndex = 12;
            // 
            // buttonSearchFriends
            // 
            this.buttonSearchFriends.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchFriends.Location = new System.Drawing.Point(94, 8);
            this.buttonSearchFriends.Name = "buttonSearchFriends";
            this.buttonSearchFriends.Size = new System.Drawing.Size(45, 23);
            this.buttonSearchFriends.TabIndex = 13;
            this.buttonSearchFriends.Text = "Find";
            this.buttonSearchFriends.UseVisualStyleBackColor = true;
            this.buttonSearchFriends.Click += new System.EventHandler(this.buttonSearchFriends_Click);
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.friendListBindingSource;
            // 
            // statusesDataGridView
            // 
            this.statusesDataGridView.AllowUserToAddRows = false;
            this.statusesDataGridView.AllowUserToDeleteRows = false;
            this.statusesDataGridView.AutoGenerateColumns = false;
            this.statusesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.statusesDataGridView.DataSource = this.statusesBindingSource;
            this.statusesDataGridView.Location = new System.Drawing.Point(141, 193);
            this.statusesDataGridView.Name = "statusesDataGridView";
            this.statusesDataGridView.ReadOnly = true;
            this.statusesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusesDataGridView.Size = new System.Drawing.Size(525, 201);
            this.statusesDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn1.HeaderText = "סטטוס";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.facebook_friends;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(691, 401);
            this.Controls.Add(this.statusesDataGridView);
            this.Controls.Add(this.buttonSearchFriends);
            this.Controls.Add(this.textBoxSearchFriends);
            this.Controls.Add(this.textBoxHometown);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.textBoxBirthDay);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLastStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(this.listBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFriends";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastStatus;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBirthDay;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.TextBox textBoxHometown;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.TextBox textBoxSearchFriends;
        private System.Windows.Forms.Button buttonSearchFriends;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.DataGridView statusesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}