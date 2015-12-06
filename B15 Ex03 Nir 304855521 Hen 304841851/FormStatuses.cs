using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using B15_Ex03_Nir_304855521_Hen_304841851.Utils;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormStatuses : Form
    {
        private Statuses m_Statuses;
        private Thread thread;

        public FormStatuses()
        {
            InitializeComponent();
        }

        private void FormStatuses_Load(object sender, EventArgs e)
        {
            thread = new Thread(this.LoadData);
            thread.Start();
        }

        private void LoadData()
        {
            m_Statuses = new Statuses();
            this.Invoke(new Action(() =>
            {
                foreach (string message in m_Statuses)
                {
                    listView1.Items.Add(message);
                }
            }));
        }
    }
}
