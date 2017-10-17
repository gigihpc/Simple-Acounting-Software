using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using AccSoftView.Pembelian;
using AccSoftView.Penjualan;
using AccSoftView.DataMaster;
using AccSoftView.Gudang;
using AccSoftView.GeneralLedger;

namespace AccSoftView.Display
{
    public partial class FrmMain1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private FrmLogin frmLogin;
        private RegistrasiSuplier frmRegSuplier;
        private Reg_Customer frmRegCustomer;
        private FrmDaftarCustomer _fDaftarCust;
        private FrmGudang _fGudang;
        private FrmItem _fItem;
        private FrmMataUang _fMataUang;
        private FrmUser _fUser;
        private FrmDaftarSuplier frmDaftarSuplier;
        private FakturPembelian frmFakturPembelian;
        private FakturPenjualan _fktrPenjualan;
        private CN_DNPenjualan frmCnPenjualan;
        private CnDnPembelian frmDNPembelian;
        private PembayaranHutang frmPembHutang;
        private PembayaranPiutang frmPemPiutang;
        private PencairanCekMasuk frmPencCekMasuk;
        private PencairanCekBgKeluar frmPencCekKeluar;
        private MutasiStokApk frmMutasiApk;
        private FrmKasBank frmKasBankT;
        private FrmKodePerkiraan frmKodePerkiraanT;
        private FrmMasterAktiva frmMasterAktiva;
        private FrmMutasiAktiva frmMutasiAktiva;
        private FrmMultipleJurnal frmMultipleJurnalT;
        private FrmSingleJurnal frmSingleJurnalT;
        private FrmSaldoAwal frmSaldoAwalGL;
        private FrmBuktiBrgMasukAPG _fMskAPG;
        private FrmBuktiBrgKeluarAPG _fKeluarAPG;

        public FrmMain1(FrmLogin f)
        {
            InitializeComponent();
            frmLogin = f;
        }

        private void FrmMain1_Load(object sender, EventArgs e)
        {
            InitSkinGallery();
        }

        #region SkinGallery
        void InitSkinGallery()
        {
            SimpleButton imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                GalleryItem gItem = new GalleryItem();
                int groupIndex = 0;
                if (cnt.SkinName.IndexOf("Office") > -1) groupIndex = 1;
                rgbiSkins.Gallery.Groups[groupIndex].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5);
                
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
                rgbiSkins.Gallery.Groups[1].Visible = false;
            }
            rgbiSkins.Gallery.AllowHoverImages = true;
        }
        Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            Bitmap image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                StyleObjectInfoArgs info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent * 2, height - indent * 2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }        
        private void rgbiSkins_Gallery_InitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(70, 36);
        }

        private void rgbiSkins_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        }
        #endregion

        private void barButtonItemSuplier_ItemClick(object sender, ItemClickEventArgs e)
        {
             if (frmDaftarSuplier == null || frmDaftarSuplier.IsDisposed)
              {
                  frmDaftarSuplier = new FrmDaftarSuplier();
                  frmDaftarSuplier.MdiParent = this;
                  frmDaftarSuplier.WindowState = FormWindowState.Maximized;
                  frmDaftarSuplier.Show();
              }
              else
                  frmDaftarSuplier.Activate();        
        }

        private void barButtonItemSuplierTrans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRegSuplier == null || frmRegSuplier.IsDisposed)
            {
                frmRegSuplier = new RegistrasiSuplier();
                frmRegSuplier.MdiParent = this;
                frmRegSuplier.Show();
            }
            else
                frmRegSuplier.Activate();
        }

        private void barButtonItemCustomerTrans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRegCustomer == null || frmRegCustomer.IsDisposed)
            {
                frmRegCustomer = new Reg_Customer();
                frmRegCustomer.MdiParent = this;
                frmRegCustomer.Show();
            }
            else
                frmRegCustomer.Activate();

        }

        private void FrmMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }

        private void barButtonExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fDaftarCust == null || _fDaftarCust.IsDisposed)
            {
                _fDaftarCust = new FrmDaftarCustomer();
                _fDaftarCust.MdiParent = this;
                _fDaftarCust.WindowState = FormWindowState.Maximized;
                _fDaftarCust.Show();
            }
            else
                _fDaftarCust.Activate();

        }

        private void barButtonItemMataUang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fMataUang == null || _fMataUang.IsDisposed)
            {
                _fMataUang = new FrmMataUang();
                _fMataUang.MdiParent = this;
                _fMataUang.Show();
            }
            else
                _fMataUang.Activate();
        }

        private void barButtonItemUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fUser == null || _fUser.IsDisposed)
            {
                _fUser = new FrmUser();
                _fUser.MdiParent = this;
                _fUser.Show();
            }
            else
                _fUser.Activate();
        }

        private void barButtonItemGudang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fGudang == null || _fGudang.IsDisposed)
            {
                _fGudang = new FrmGudang();
                _fGudang.MdiParent = this;
                _fGudang.Show();
            }
            else
                _fGudang.Activate();
        }

        private void barButtonItemFakturPembDaftar_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemFakturPembelian_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmFakturPembelian == null || frmFakturPembelian.IsDisposed)
            {
                frmFakturPembelian = new FakturPembelian();
                frmFakturPembelian.MdiParent = this;
                frmFakturPembelian.WindowState = FormWindowState.Maximized;
                frmFakturPembelian.Show();
            }
            else
                frmFakturPembelian.Activate(); 
        }

        private void barButtonItemFktrPenj_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fktrPenjualan == null || _fktrPenjualan.IsDisposed)
            {
                _fktrPenjualan = new FakturPenjualan();
                _fktrPenjualan.MdiParent = this;
                _fktrPenjualan.WindowState = FormWindowState.Maximized;
                _fktrPenjualan.Show();
            }
            else
                _fktrPenjualan.Activate(); 
        }

        private void barButtonItemCNPenj_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmCnPenjualan == null || frmCnPenjualan.IsDisposed)
            {
                frmCnPenjualan = new CN_DNPenjualan();
                frmCnPenjualan.MdiParent = this;
                frmCnPenjualan.Show();
            }
            else
                frmCnPenjualan.Activate();
        }

        private void barButtonItemPembPiutang_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmPemPiutang == null || frmPemPiutang.IsDisposed)
            {
                frmPemPiutang = new PembayaranPiutang();
                frmPemPiutang.MdiParent = this;
                frmPemPiutang.Show();
            }
            else
                frmPemPiutang.Activate();
        }

        private void barButtonItemPencairanCekMasuk_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmPencCekKeluar == null || frmPencCekKeluar.IsDisposed)
            {
                frmPencCekKeluar = new PencairanCekBgKeluar();
                frmPencCekKeluar.MdiParent = this;
                frmPencCekKeluar.Show();
            }
            else
                frmPencCekKeluar.Activate();
        }

        private void barButtonItemDNPemb_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmDNPembelian == null || frmDNPembelian.IsDisposed)
            {
                frmDNPembelian = new CnDnPembelian();
                frmDNPembelian.MdiParent = this;
                frmDNPembelian.Show();
            }
            else
                frmDNPembelian.Activate();
        }

        private void barButtonItemPembHutang_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmPembHutang == null || frmPembHutang.IsDisposed)
            {
                frmPembHutang = new PembayaranHutang();
                frmPembHutang.MdiParent = this;
                frmPembHutang.Show();
            }
            else
                frmPembHutang.Activate();
        }

        private void barButtonItemPencairanCekKeluar_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmPencCekKeluar == null || frmPencCekKeluar.IsDisposed)
            {
                frmPencCekKeluar = new PencairanCekBgKeluar();
                frmPencCekKeluar.MdiParent = this;
                frmPencCekKeluar.Show();
            }
            else
                frmPencCekKeluar.Activate();
        }

        private void barButtonItemMutasiAPK_trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmMutasiApk == null || frmMutasiApk.IsDisposed)
            {
                frmMutasiApk = new MutasiStokApk();
                frmMutasiApk.MdiParent = this;
                frmMutasiApk.Show();
            }
            else
                frmMutasiApk.Activate();
        }

        private void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fItem == null || _fItem.IsDisposed)
            {
                _fItem = new FrmItem();
                _fItem.MdiParent = this;
                _fItem.Show();
            }
            else
                _fItem.Activate();
        }

        private void barButtonItemKasBankT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmKasBankT == null || frmKasBankT.IsDisposed)
            {
                frmKasBankT = new FrmKasBank();
                frmKasBankT.MdiParent = this;
                frmKasBankT.Show();
            }
            else
                frmKasBankT.Activate();
        }

        private void barButtonItemSingleJurnalT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmSingleJurnalT == null || frmSingleJurnalT.IsDisposed)
            {
                frmSingleJurnalT = new FrmSingleJurnal();
                frmSingleJurnalT.MdiParent = this;
                frmSingleJurnalT.Show();
            }
            else
                frmSingleJurnalT.Activate();
        }

        private void barButtonItemMultipleJurnal_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmMultipleJurnalT == null || frmMultipleJurnalT.IsDisposed)
            {
                frmMultipleJurnalT = new FrmMultipleJurnal();
                frmMultipleJurnalT.MdiParent = this;
                frmMultipleJurnalT.Show();
            }
            else
                frmMultipleJurnalT.Activate();
        }

        private void barButtonItemKodePerkiraanT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmKodePerkiraanT == null || frmKodePerkiraanT.IsDisposed)
            {
                frmKodePerkiraanT = new FrmKodePerkiraan();
                frmKodePerkiraanT.MdiParent = this;
                frmKodePerkiraanT.Show();
            }
            else
                frmKodePerkiraanT.Activate();
        }

        private void barButtonItemSaldoAwalGLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmSaldoAwalGL == null || frmSaldoAwalGL.IsDisposed)
            {
                frmSaldoAwalGL = new FrmSaldoAwal();
                frmSaldoAwalGL.MdiParent = this;
                frmSaldoAwalGL.Show();
            }
            else
                frmSaldoAwalGL.Activate();
        }

        private void barButtonItemMasterAktivaT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmMasterAktiva == null || frmMasterAktiva.IsDisposed)
            {
                frmMasterAktiva = new FrmMasterAktiva();
                frmMasterAktiva.MdiParent = this;
                frmMasterAktiva.Show();
            }
            else
                frmMasterAktiva.Activate();
        }

        private void barButtonItemMutasiAktivaT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmMutasiAktiva == null || frmMutasiAktiva.IsDisposed)
            {
                frmMutasiAktiva = new FrmMutasiAktiva();
                frmMutasiAktiva.MdiParent = this;
                frmMutasiAktiva.Show();
            }
            else
                frmMutasiAktiva.Activate();
        }

        private void barButtonItemBrgMskAPG_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fMskAPG == null || _fMskAPG.IsDisposed)
            {
                _fMskAPG = new FrmBuktiBrgMasukAPG();
                _fMskAPG.MdiParent = this;
                _fMskAPG.Show();
            }
            else
                _fMskAPG.Activate();
        }

        private void barButtonItemBrgKeluarAPG_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_fKeluarAPG == null || _fKeluarAPG.IsDisposed)
            {
                _fKeluarAPG = new FrmBuktiBrgKeluarAPG();
                _fKeluarAPG.MdiParent = this;
                _fKeluarAPG.Show();
            }
            else
                _fKeluarAPG.Activate();
        }


    }
}