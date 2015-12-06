using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class SmartButton : Button
    {
        public event Action<Image, string> m_ReportUploadClicked;

        public string StatusMessage { get; set; }

        public Image Photo { get; set; }

        public SmartButton()
        {
        }

        public void notifyClickedObservers()
        {
            if (m_ReportUploadClicked != null)
            {
                m_ReportUploadClicked.Invoke(Photo, StatusMessage);
            }
        }
    }
}
