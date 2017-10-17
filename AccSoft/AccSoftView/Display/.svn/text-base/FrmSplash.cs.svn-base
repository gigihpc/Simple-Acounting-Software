using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Demos.DockingDemo;
using AccModelService;

namespace AccSoftView.Display
{
    public partial class FrmSplash : DevExpress.XtraEditors.XtraForm
    {
        private FrmMain1 fMain;
        public FrmSplash(FrmMain1 f)
        {
            InitializeComponent();
            SplashValue();
            fMain = f;
        }

        private void SplashValue()
        {
            //marqueProgressbar.Style = ProgressBarStyle.Marquee;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int milliSecondsToWait = 1;
            System.Threading.Thread.Sleep(milliSecondsToWait);
            DataManager.Instance.FillDataSet();

            //backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //marqueeProgressBar.Visible = false;
            //this.Visible = false;            
            //fMain = new frmMain();
            fMain.Show();
            this.Close();
        }
    }
}