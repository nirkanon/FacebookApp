using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class PhotosUtils
    {
        private User m_LoggedUser;

        public SmartButton m_Button;

        public PhotosUtils()
        {
            m_Button = new SmartButton();
            m_LoggedUser = LoggedUserSingleton.Instance.GetUser();
            m_Button.m_ReportUploadClicked += new Action<Image, string>(this.UploadImage);
        }

        public Bitmap CreateBitmap(string i_FileName)
        {
            StreamReader streamReader = new StreamReader(i_FileName);
            Bitmap sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return sourceBitmap;
        }

        public void UploadImage(Image i_Image)
        {
            MemoryStream memoryStream = new MemoryStream();
            i_Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] buffer = memoryStream.GetBuffer();
            m_LoggedUser.PostPhoto(buffer, string.Empty);
        }

        public void UploadImage(Image i_Image, string i_Message)
        {
            MemoryStream memoryStream = new MemoryStream();
            i_Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] buffer = memoryStream.GetBuffer();
            m_LoggedUser.PostPhoto(buffer, i_Message);
        }

        public int Count()
        {
            int count = 0;
            foreach (Album album in m_LoggedUser.Albums)
            {
                 count += album.Photos.Count();
            }

            return count;
        }
    }
}
