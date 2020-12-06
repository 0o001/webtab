namespace webtab
{
    partial class usr_sayfa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_url = new System.Windows.Forms.TextBox();
            this.wb_sayfa = new System.Windows.Forms.WebBrowser();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ls_cizgi = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pcr_yeni = new System.Windows.Forms.PictureBox();
            this.pcr_ileri = new System.Windows.Forms.PictureBox();
            this.pcr_geri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_yeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_url.Location = new System.Drawing.Point(109, 8);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(371, 25);
            this.txt_url.TabIndex = 3;
            this.txt_url.Click += new System.EventHandler(this.txt_url_Click);
            this.txt_url.DoubleClick += new System.EventHandler(this.txt_url_DoubleClick);
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            // 
            // wb_sayfa
            // 
            this.wb_sayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wb_sayfa.Location = new System.Drawing.Point(0, 45);
            this.wb_sayfa.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_sayfa.Name = "wb_sayfa";
            this.wb_sayfa.Size = new System.Drawing.Size(487, 278);
            this.wb_sayfa.TabIndex = 4;
            this.wb_sayfa.Url = new System.Uri("", System.UriKind.Relative);
            this.wb_sayfa.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_sayfa_DocumentCompleted);
            this.wb_sayfa.NewWindow += new System.ComponentModel.CancelEventHandler(this.wb_sayfa_NewWindow);
            this.wb_sayfa.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.wb_sayfa_ProgressChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ls_cizgi});
            this.shapeContainer1.Size = new System.Drawing.Size(487, 323);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // ls_cizgi
            // 
            this.ls_cizgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ls_cizgi.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ls_cizgi.Name = "ls_cizgi";
            this.ls_cizgi.X1 = -34;
            this.ls_cizgi.X2 = 573;
            this.ls_cizgi.Y1 = 44;
            this.ls_cizgi.Y2 = 44;
            // 
            // pcr_yeni
            // 
            this.pcr_yeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_yeni.Image = global::webtab.Properties.Resources.undo_2_24;
            this.pcr_yeni.Location = new System.Drawing.Point(72, 8);
            this.pcr_yeni.Name = "pcr_yeni";
            this.pcr_yeni.Size = new System.Drawing.Size(31, 25);
            this.pcr_yeni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_yeni.TabIndex = 2;
            this.pcr_yeni.TabStop = false;
            this.pcr_yeni.Click += new System.EventHandler(this.pcr_yeni_Click);
            this.pcr_yeni.MouseLeave += new System.EventHandler(this.pcr_yeni_MouseLeave);
            this.pcr_yeni.MouseHover += new System.EventHandler(this.pcr_yeni_MouseHover);
            // 
            // pcr_ileri
            // 
            this.pcr_ileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_ileri.Image = global::webtab.Properties.Resources.arrow_11_24;
            this.pcr_ileri.Location = new System.Drawing.Point(37, 8);
            this.pcr_ileri.Name = "pcr_ileri";
            this.pcr_ileri.Size = new System.Drawing.Size(31, 25);
            this.pcr_ileri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_ileri.TabIndex = 1;
            this.pcr_ileri.TabStop = false;
            this.pcr_ileri.Click += new System.EventHandler(this.pcr_ileri_Click);
            this.pcr_ileri.MouseLeave += new System.EventHandler(this.pcr_ileri_MouseLeave);
            this.pcr_ileri.MouseHover += new System.EventHandler(this.pcr_ileri_MouseHover);
            // 
            // pcr_geri
            // 
            this.pcr_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_geri.Image = global::webtab.Properties.Resources.arrow_111_24__1_;
            this.pcr_geri.Location = new System.Drawing.Point(3, 8);
            this.pcr_geri.Name = "pcr_geri";
            this.pcr_geri.Size = new System.Drawing.Size(31, 25);
            this.pcr_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_geri.TabIndex = 0;
            this.pcr_geri.TabStop = false;
            this.pcr_geri.MouseLeave += new System.EventHandler(this.pcr_geri_MouseLeave);
            this.pcr_geri.MouseHover += new System.EventHandler(this.pcr_geri_MouseHover);
            // 
            // usr_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wb_sayfa);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.pcr_yeni);
            this.Controls.Add(this.pcr_ileri);
            this.Controls.Add(this.pcr_geri);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "usr_sayfa";
            this.Size = new System.Drawing.Size(487, 323);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_yeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_geri;
        private System.Windows.Forms.PictureBox pcr_ileri;
        private System.Windows.Forms.PictureBox pcr_yeni;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape ls_cizgi;
        public System.Windows.Forms.WebBrowser wb_sayfa;
        public System.Windows.Forms.TextBox txt_url;
    }
}