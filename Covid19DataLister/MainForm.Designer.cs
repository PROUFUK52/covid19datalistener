/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Ufcuk
 * Tarih: 30.09.2021
 * Zaman: 17:09
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace Covid19DataLister
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(572, 349);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(250, 250);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.Url = new System.Uri("https://covid19.saglik.gov.tr/", System.UriKind.Absolute);
			this.webBrowser1.Visible = false;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bugünkü Vaka Sayısı : Lütfen Bekleyin...";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(292, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bugünkü Test Sayısı : Lütfen Bekleyin...";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(292, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Bugünkü RIP Sayısı : Lütfen Bekleyin...";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(308, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bugünkü İyileşen Sayısı : Lütfen Bekleyin...";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(310, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(414, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "EN AZ İKİ DOZ AŞI OLMUŞ 18 YAŞ VE ÜSTÜ NÜFUS\r\n";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(310, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(363, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "1.Doz Aşı Yapılma Oranı : Lütfen Bekleyin...";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(310, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(363, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "2.Doz Aşı Yapılma Oranı : Lütfen Bekleyin...";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(310, 78);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(363, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "1.,2. VE 3.Doz Toplamı : Lütfen Bekleyin...";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(310, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(363, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "1.Doz Aşı Vurulan Kişi Sayısı : Lütfen Bekleyin...";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(310, 124);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(363, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "2.Doz Aşı Vurulan Kişi Sayısı : Lütfen Bekleyin...";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Location = new System.Drawing.Point(310, 147);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(363, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "3.Doz Aşı Vurulan Kişi Sayısı : Lütfen Bekleyin...";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(41, 124);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(118, 34);
			this.label12.TabIndex = 12;
			this.label12.Text = "Coded by KaptanUfuk\r\n";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(12, 170);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(756, 223);
			this.label13.TabIndex = 13;
			this.label13.Text = "Yapımcı Notu : Lütfen Bekleyin...";
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 402);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.webBrowser1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Covid19 Data Listener                                  ";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.ResumeLayout(false);

		}
	}
}
