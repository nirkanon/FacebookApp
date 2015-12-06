using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.IO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using B15_Ex03_Nir_304855521_Hen_304841851.Utils;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormPhotos : Form
    {
        private PhotosUtils m_PhotosUtils;
        private SmartButton m_btnSmart;
        private FilterBase[] m_filters; 

        public FormPhotos()
        {
            InitializeComponent();
            m_PhotosUtils = new PhotosUtils();
            m_btnSmart = new SmartButton();
            m_btnSmart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            m_btnSmart.Location = new System.Drawing.Point(503, 15);
            m_btnSmart.Name = "buttonPostImage";
            m_btnSmart.Size = new System.Drawing.Size(125, 45);
            m_btnSmart.TabIndex = 12;
            m_btnSmart.Text = "Upload";
            m_btnSmart.UseVisualStyleBackColor = true;
            m_btnSmart.Click += new System.EventHandler(btnSmart_Click);
            this.Controls.Add(m_btnSmart);
            m_btnSmart.m_ReportUploadClicked += new Action<Image, string>(m_PhotosUtils.UploadImage);
            m_filters = new FilterBase[] { new CopyAsGrayscale(), new DrawAsGrayscale(), new CopyWithTransparency(), new DrawWithTransparency(), new CopyAsNegative(), new DrawAsNegative(), new CopyAsSepiaTone(), new DrawAsSepiaTone() };
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Photo";
            fileDialog.Filter = "Png files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpeg)|*.jpeg";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxOriginalPicture.Image = m_PhotosUtils.CreateBitmap(fileDialog.FileName);
                OnCheckChangedEventHandler(sender, e);
            }
        }

        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {
            pictureBoxNewPicture.Image = m_filters[int.Parse(((RadioButton)sender).Tag.ToString())].FilterImage(pictureBoxOriginalPicture.Image);
        }

        private void btnSmart_Click(object sender, EventArgs e)
        {
            m_btnSmart.Photo = pictureBoxNewPicture.Image;
            m_btnSmart.StatusMessage = textBoxMessage.Text;
            m_btnSmart.notifyClickedObservers();
            MessageBox.Show("Photo Uploaded!", string.Empty, MessageBoxButtons.OK);
        }
    }
}
