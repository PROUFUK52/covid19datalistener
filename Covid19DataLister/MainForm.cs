/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Ufcuk
 * Tarih: 30.09.2021
 * Zaman: 17:09
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Covid19DataLister
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public string programsurumu = "1.0";
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

	        HtmlElementCollection bilgi = webBrowser1.Document.All;
        foreach (HtmlElement element in bilgi)
        {
            if (element.GetAttribute("classname").Contains("bugunku-vaka-sayisi"))
                label1.Text = "Bugünkü Vaka Sayısı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("bugunku-test-sayisi"))
                label2.Text = "Bugünkü Test Sayısı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("bugunku-vefat-sayisi"))
                label3.Text = "Bugünkü Ölen Sayısı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("bugunku-iyilesen-sayisi"))
                label4.Text = "Bugünkü İyileşen Sayısı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("dozturkiyeortalamasi"))
                label6.Text = "1.Doz Aşı Yapılma Oranı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("doz2turkiyeortalamasi"))
                label7.Text = "2.Doz Aşı Yapılma Oranı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("toplamasidozusayisi"))
                label8.Text = "1.,2. Ve 3. Doz Toplamı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("doz1asisayisi"))
                label9.Text = "1.Doz Aşı Vurulan Kişi Sayısı :  : "+element.InnerText;           
            if (element.GetAttribute("classname").Contains("doz2asisayisi"))
                label10.Text = "2.Doz Aşı Vurulan Kişi Sayısı : "+element.InnerText;
            if (element.GetAttribute("classname").Contains("doz3asisayisi"))
                label11.Text = "3.Doz Aşı Vurulan Kişi Sayısı : "+element.InnerText;
            timer1.Enabled = true;
            if (label1.Text == "0")
            {
            	MessageBox.Show("Vay Be Virüssüz Bir Dünya :)) Maskelerin olmadığı bir zaman :)) hangi yıldayız acaba.Hmm "+DateTime.Today.Year+" yılındayız sanırım.Hmm galiba tam tarih bu "+ DateTime.Today+" ben 2021 yılından geliyorum.2021 yılında maske diye bişey var ve takmak zorundasın yoksa ceza kesiyorlar "+DateTime.Today.Year+" yılındaki gibi maskesiz rahat gezinme diye birşey yok :( neyse benim notum bu kadar iyi maskesiz günler :)) he bu arada unutmadan virüs diye birşey kalmadığı için programı kapatıyorum sen uğraşma diye bb","Virüssüz dünyaya KaptanUfuk'tan mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
            	Environment.Exit(0);
            }
        }
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			WebClient client = new WebClient();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string surum = client.DownloadString("https://raw.githubusercontent.com/PROUFUK52/covid19datalistener/main/surum");
			string bugsizsurum = surum.Substring(0, surum.Length - 1);
			if (bugsizsurum == programsurumu)
			{
			}
			else 
			{
				MessageBox.Show("Programa güncelleme gelmiştir."+Environment.NewLine+"Son Sürüm : "+surum +Environment.NewLine+"Sendeki Sürüm : "+programsurumu+Environment.NewLine+"Güncellemek İçin Lütfen https://youtube.com/KaptanUfuk adresini kontrol ediniz.","Güncelleme Kontrolcüsü",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}

			
	
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string notum = client.DownloadString("https://raw.githubusercontent.com/PROUFUK52/covid19datalistener/main/yapimcinotu");
			label13.Text = "Yapımcı Notu : "+notum;
		}
		void MainFormResize(object sender, EventArgs e)
		{
			if (this.Width <= 796)
			{
				this.Width = 796;
			}
			if (this.Height <= 441)
			{
				this.Height = 441;
			}
			
		}
		void Timer1Tick(object sender, EventArgs e)
		{
	this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
	label13.Text = label13.Text.Substring(1) + label13.Text.Substring(0, 1);
	label12.Text = label12.Text.Substring(1) + label12.Text.Substring(0, 1);
		}
		
	}
}