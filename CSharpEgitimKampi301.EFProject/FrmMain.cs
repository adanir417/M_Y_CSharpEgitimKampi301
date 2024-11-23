using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_GuideForm_Click(object sender, EventArgs e)
        {
            FrmGuide frmGuide = new FrmGuide();                       
            frmGuide.Show(this);
            this.Hide();
            
           
        }

        private void btn_LocationForm_Click(object sender, EventArgs e)
        {
            FrmLocation frmLocation = new FrmLocation();
            frmLocation.Show(this);
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_StatisticForm_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show(this);
            this.Hide();
        }
    }
}
