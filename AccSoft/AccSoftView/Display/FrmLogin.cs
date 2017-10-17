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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private FrmMain1 fMain;
        private LoginModel _loginmodel;
        Size showSize = new Size(372, 390);
        Size hideSize = new Size(372, 190);

        public FrmLogin()
        {
            InitializeComponent();
            fMain = new FrmMain1(this);
            _loginmodel = new LoginModel();
        }

        private void ShowDetails(bool showing)
        {
            if (showing)
            {
                this.Size = new Size(showSize.Width, showSize.Height);
            }
            else
            {
                this.Size = new Size(hideSize.Width, hideSize.Height);
            }

            layoutControl1.TabStop = showing;

            this.Invalidate();
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            LoginDb();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_testkonek_Click(object sender, EventArgs e)
        {
            KoneksiServer();
        }

        private void linkLabelSever_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelSever.Text == "Lihat Server >>")
            {
                ShowDetails(true);
                linkLabelSever.Text = "Sembunyikan Server >>";
            }
            else if (linkLabelSever.Text == "Sembunyikan Server >>")
            {
                ShowDetails(false);
                linkLabelSever.Text = "Lihat Server >>";
            }
        }

        private void LoginDb()
        {
            if (_loginmodel.statusLogin(txt_pass.Text, txt_user.Text) == true)
            {
                FrmSplash FS = new FrmSplash(fMain);
                FS.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nama Pengguna atau Kata Kunci salah");
                txt_pass.Text = "";
                txt_pass.Focus();
            }
        }

        private void KoneksiServer()
        {
            if (_loginmodel.LoginServer(cmb_server.Text, cmb_db.Text, cmb_user.Text, txtpass.Text) == true)
                MessageBox.Show("Koneksi Berhasil");
            else
            {
                MessageBox.Show("Koneksi Gagal");
                cmb_server.Text = "";
                cmb_db.Text = "";
                cmb_user.Text = "";
                txtpass.Text = "";
                cmb_server.Focus();
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                LoginDb();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                KoneksiServer();
        }
    }
}