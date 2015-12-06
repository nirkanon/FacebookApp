namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormCheckins
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
            this.listViewCheckins = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.buttonRate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCheckins
            // 
            this.listViewCheckins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnLocation,
            this.columnRating});
            this.listViewCheckins.FullRowSelect = true;
            this.listViewCheckins.GridLines = true;
            this.listViewCheckins.Location = new System.Drawing.Point(12, 12);
            this.listViewCheckins.MultiSelect = false;
            this.listViewCheckins.Name = "listViewCheckins";
            this.listViewCheckins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewCheckins.Size = new System.Drawing.Size(476, 154);
            this.listViewCheckins.TabIndex = 0;
            this.listViewCheckins.UseCompatibleStateImageBehavior = false;
            this.listViewCheckins.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 43;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLocation.Width = 258;
            // 
            // columnRating
            // 
            this.columnRating.Text = "Rating";
            this.columnRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(8, 34);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRating.TabIndex = 1;
            // 
            // buttonRate
            // 
            this.buttonRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRate.Location = new System.Drawing.Point(522, 99);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 2;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxRating);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(494, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rate";
            // 
            // CheckinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::B15_Ex03_Nir_304855521_Hen_304841851.Properties.Resources.Blue_Background_03;
            this.ClientSize = new System.Drawing.Size(634, 178);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.listViewCheckins);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckinsForm";
            this.Text = "Checkins";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCheckins;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}