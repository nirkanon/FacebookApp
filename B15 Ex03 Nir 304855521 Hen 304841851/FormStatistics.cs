using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormStatistics : Form
    {
        private Dictionary<string, int> m_Data;
        private StatisticsFacade m_Statistics;
        private Thread thread;
        private bool m_IsClosed = false;

        public FormStatistics()
        {
            InitializeComponent();
            m_Statistics = new StatisticsFacade();
        }

        protected override void OnShown(EventArgs e)
        {
            labelLoading.Show();
            thread = new Thread(this.LoadDictionaryData);
            thread.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_IsClosed = true;
        }

        private void LoadDictionaryData()
        {
            m_Data = m_Statistics.GetData();
            if (m_IsClosed == false)
            {
                this.Invoke(new Action(() =>
                {
                    LoadData();
                    labelLoading.Hide();
                }));
            }
        }

        private void LoadData()
        {
            listViewStatistics.Items.Clear();
            foreach (KeyValuePair<string, int> keyValuePair in m_Data)
            {
                ListViewItem listViewItem = new ListViewItem(keyValuePair.Key);
                listViewItem.SubItems.Add(keyValuePair.Value.ToString());
                listViewStatistics.Items.Add(listViewItem);
            }
        }
    }
}
