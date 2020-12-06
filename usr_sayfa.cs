using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace webtab
{
    public partial class usr_sayfa : UserControl
    {
        public usr_sayfa()
        {
            InitializeComponent();
            pcr_yeni.Image = Properties.Resources.x_mark_24__1_;
        }

        private void pcr_geri_Click(object sender, EventArgs e)
        {
            wb_sayfa.GoBack();
        }

        private void pcr_ileri_Click(object sender, EventArgs e)
        {
            wb_sayfa.GoForward();
        }

        private void pcr_yeni_Click(object sender, EventArgs e)
        {
            pcr_yeni.Image = Properties.Resources.x_mark_24__1_;
            wb_sayfa.Refresh();
            tik = true;
        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') //enter işlemi
            {
                pcr_yeni.Image = Properties.Resources.x_mark_24__1_;
                wb_sayfa.Navigate(txt_url.Text);
                tik = true;
                
            }
        }
        private void wb_sayfa_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                txt_url.Text = wb_sayfa.Document.Url.ToString();    
        }
        bool tik = true;
        private void txt_url_Click(object sender, EventArgs e)
        {
            if (tik)
            {
                txt_url.SelectAll();
                tik = false;
            }
        }
        private void txt_url_DoubleClick(object sender, EventArgs e)
        {
            txt_url.SelectAll();
        }

        private void pcr_geri_MouseHover(object sender, EventArgs e)
        {
            pcr_geri.Image = Properties.Resources.arrow_111_24__2_;
        }

        private void pcr_geri_MouseLeave(object sender, EventArgs e)
        {
            pcr_geri.Image = Properties.Resources.arrow_111_24__1_;
        }

        private void pcr_ileri_MouseHover(object sender, EventArgs e)
        {
            pcr_ileri.Image = Properties.Resources.arrow_11_24__1_;
        }

        private void pcr_ileri_MouseLeave(object sender, EventArgs e)
        {
            pcr_ileri.Image = Properties.Resources.arrow_11_24;
        }

        private void pcr_yeni_MouseHover(object sender, EventArgs e)
        {
            pcr_yeni.Image = Properties.Resources.undo_2_24__1_;
        }

        private void pcr_yeni_MouseLeave(object sender, EventArgs e)
        {
            pcr_yeni.Image = Properties.Resources.undo_2_24;
        }

        private void wb_sayfa_NewWindow(object sender, CancelEventArgs e)
        {
        }

        private void wb_sayfa_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
         
            if (e.CurrentProgress == 10000)
            {
                pcr_yeni.Image = Properties.Resources.x_mark_24__1_;
            }
            else
            {
                pcr_yeni.Image = Properties.Resources.undo_2_24;
            }

        }
    }
}
