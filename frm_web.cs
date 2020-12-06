using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI; //Component
using TheCodeKing.ActiveButtons.Controls; //Component
using System.Net;
using System.IO;

namespace webtab
{
    public partial class frm_web : Form
    {
        public frm_web()
        {
            InitializeComponent();
            this.rpw_sekme.ItemSizeMode = PageViewItemSizeMode.Individual;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EkleButon("+", YeniSekme);
        }
        
      private void YeniSekme(object sender, EventArgs e)
        {
            usr_sayfa ac = new usr_sayfa();
            RadPageViewPage sayfa = new RadPageViewPage();
            ac.Dock = DockStyle.Fill;
            sayfa.Text = "Yeni Sekme";
            sayfa.Controls.Add(ac); //pagevievpagede usercontrolü aç
            rpw_sekme.Pages.Add(sayfa);//sekme olarak ekler
            rpw_sekme.SelectedPage = sayfa; //yeni sekme açıldığında aktif sayfa ol
            ac.wb_sayfa.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_sayfa_DocumentCompleted);
            ac.wb_sayfa.NewWindow += new CancelEventHandler(wb_sayfa_NewWindow);
        }
      void YeniPencere(string link)
      {
          usr_sayfa ac = new usr_sayfa();
          RadPageViewPage sayfa = new RadPageViewPage();
          ac.Dock = DockStyle.Fill;
          sayfa.Text = "Yeni Sekme";
          sayfa.Controls.Add(ac); //pagevievpagede usercontrolü aç
          rpw_sekme.Pages.Add(sayfa);//sekme olarak ekler
          rpw_sekme.SelectedPage = sayfa; //yeni sekme açıldığında aktif sayfa ol
          ac.wb_sayfa.Navigate(link);
          ac.wb_sayfa.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_sayfa_DocumentCompleted);
          ac.wb_sayfa.NewWindow += new CancelEventHandler(wb_sayfa_NewWindow);

      }
      void wb_sayfa_NewWindow(object sender, CancelEventArgs e)
      {
          e.Cancel = true;//internet explorerda açmaması için
          try
          {
              WebBrowser yenisekmeurl = (WebBrowser)sender;
              HtmlElement link = yenisekmeurl.Document.ActiveElement;
              Uri urlNavigated = new Uri(link.GetAttribute("href")); //yeni sekmede açılacak url
              YeniPencere(urlNavigated.ToString());

          }
          catch { MessageBox.Show("Yeni Sekmede Açılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
      }
        public static Image favicon(String u) //site faviconu çek
        {
            var url = new Uri(u);
            try
            {
                var iconURL = "http://www.google.com/s2/favicons?domain="+url.Host;
                System.Net.WebRequest request = System.Net.HttpWebRequest.Create(iconURL);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream stream = response.GetResponseStream();
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }
        void wb_sayfa_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (((WebBrowser)sender).Document.Url.ToString() != "about:blank") 
            {
                rpw_sekme.SelectedPage.Image = favicon(e.Url.ToString());
                if (((WebBrowser)sender).DocumentTitle.Length <= 15)
                    rpw_sekme.SelectedPage.Text = ((WebBrowser)sender).DocumentTitle;
                else rpw_sekme.SelectedPage.Text = ((WebBrowser)sender).DocumentTitle.Substring(0, 12) + "..."; //sitenin başlığı uzunsa azaltıp gösterilmesi 
                rpw_sekme.SelectedPage.ToolTipText = ((WebBrowser)sender).DocumentTitle; //tooltip olarak sitenin tüm adının görünmesi için
            }
            else
            {
                rpw_sekme.SelectedPage.Text = "Yeni Sekme";
                rpw_sekme.SelectedPage.ToolTipText = "Yeni Sekme";
            }
        }
        private void EkleButon(string yazi, EventHandler handler) //Yeni sekme + butonu oluşturmak
        {
            IActiveMenu menu = ActiveMenu.GetInstance(this);
            ActiveButton buttonNull = new ActiveButton();
            buttonNull.Text = null;
            buttonNull.Dock = DockStyle.Fill;
            buttonNull.Hide();
            menu.Items.Add(buttonNull);
            ActiveButton button = new ActiveButton();
            button.Text = yazi;
            button.Cursor = Cursors.Hand;
            button.ForeColor = Color.Black;
            menu.ToolTip.SetToolTip(button, "Yeni Sekme");
            button.Click += handler;
            menu.Items.Add(button);
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            YeniSekme(sender, e);
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (((RadPageView)sender).Pages.Count == 0) this.Close(); // eğer bir tane sekme varsa sekme çarpısına formu kapatma işlemi
        }
    }
}
