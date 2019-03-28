using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
/*
 * İlkcan Doğan
 * Takım Projesi Programı
 * 20.02.2018
 */
namespace FTP_Erişme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbSunucu.Text == string.Empty ||tbK_Adi.Text == string.Empty || tbSifre.Text==string.Empty)
            {
                MessageBox.Show("FTP Bilgilerini Girin", "FTP Bağlantısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bgCalis.RunWorkerAsync();
                lblDurum.Text = "Bağlanıyor...";
                btnBaglan.Enabled = false;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Control.CheckForIllegalCrossThreadCalls = false;
            groupIndir.Enabled = false;
            groupYukle.Enabled = false;
            pictureBox1.Visible = false;

        }
        List<string> files = new List<string>();
        private void apcalis_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                FtpWebRequest request = FtpWebRequest.Create(tbSunucu.Text) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(tbK_Adi.Text, tbSifre.Text);
                FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
                Stream respenStream = reponse.GetResponseStream();
                StreamReader reder = new StreamReader(respenStream);
                while (!reder.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reder.ReadLine());
                }
                reponse.Close();
                respenStream.Close();
                reder.Close();
                 lblDurum.Text = "Bağlandı";
                lblDurum.ForeColor = Color.Green;
                pictureBox1.Visible = true;
                

                foreach (string file in files)
                {
                    lbDizin.Items.Add(file);
                }
                groupIndir.Enabled = true;
                groupYukle.Enabled = true;
            

            }
            catch (Exception hata)
            {

                MessageBox.Show(string.Format(hata.Message), "Bağlantı Hatası",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Bağlantı Hatası";
                btnBaglan.Enabled = true;
            }
           
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbSunucu.Clear();
            tbK_Adi.Clear();
            tbSifre.Clear();
        }

        private void chbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGoster.Checked == true)
            {
                tbSifre.UseSystemPasswordChar = false;
            }
            else tbSifre.UseSystemPasswordChar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdIndirme_Dizini = new FolderBrowserDialog();
            if (fbdIndirme_Dizini.ShowDialog() == DialogResult.OK)
            {
                tbIndirme_Dizini.Text = fbdIndirme_Dizini.SelectedPath;
            }
        }

        private void bgIndir_DoWork(object sender, DoWorkEventArgs e)
        {
            string sunucu = tbSunucu.Text + @"/";
            string k_adi = tbK_Adi.Text;
            string sifre = tbSifre.Text;
            string dizin = tbIndirme_Dizini.Text + @"\";
            string dosya_adi = lbDizin.SelectedItem.ToString();

            try
            {
                FtpWebRequest sorgu = (FtpWebRequest)WebRequest.Create(sunucu + dosya_adi);
                sorgu.Credentials = new NetworkCredential(k_adi, sifre);
                using (FtpWebResponse response = (FtpWebResponse)sorgu.GetResponse())
                {
                    Stream veri = response.GetResponseStream();
                    string hedef_dizin = dizin + dosya_adi;
                    if (File.Exists(hedef_dizin)) 
                        File.Delete(hedef_dizin);
                    byte[] byteBuffer = new byte[99999];
               
                    using (FileStream output = new FileStream(hedef_dizin, FileMode.CreateNew))
                    {
                        int bytesRead = 0;
                        

                        do
                        {
                            bytesRead = veri.Read(byteBuffer, 0, byteBuffer.Length);
                            if (bytesRead > 0)
                            {
                                output.Write(byteBuffer, 0, bytesRead);
                            }
                        }
                        while (bytesRead > 0);
                        
                    }
                }
                lbIndirilen_dosya.Text = lbDizin.SelectedItem.ToString();
                MessageBox.Show("Dosya İndirildi.", "Proje Indir", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Dosya Indirilemedi.", "Proje Indir", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                groupIndir.Enabled = true;
                lbDizin.Enabled = true;
            }

        }

        private void fbdIndirme_Dizini_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
         
            if(tbIndirme_Dizini.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bir Dizin Seçin ", "Proj Indir",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(lbDizin.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen Indirilecek Dosya Seçin ", "Proj Indir",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bgIndir.RunWorkerAsync();
                groupIndir.Enabled = false;
                lbDizin.Enabled = false;
            }

          
        }
        public string dosya_Yukleme;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog FTP_Yukle = new OpenFileDialog();

            FTP_Yukle.Title = "Dosya Yükle";
            FTP_Yukle.Filter = "Sıkıştırılmış Dosyalar |*.rar;*.zip";
            
            if(FTP_Yukle.ShowDialog() == DialogResult.OK)
            {
                tbYukle.Text = FTP_Yukle.FileName;
                dosya_Yukleme = FTP_Yukle.SafeFileName;

              
            }

        }

        private void bgIndir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        public void Ftp_dosya_gonder(string fileroot)
        {
           
        }

        private void bgYukle_DoWork(object sender, DoWorkEventArgs e)
        {
            string sunucu = tbSunucu.Text + @"/";
            string k_adi = tbK_Adi.Text;
            string sifre = tbSifre.Text;
            string dizin = tbYukle.Text;
            string dosya_adi = dosya_Yukleme;

            FileInfo fileInf = new FileInfo(dizin);
            string uri = sunucu + fileInf.Name;

            FtpWebRequest reqFTP;

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            reqFTP.Credentials = new NetworkCredential(k_adi, sifre);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = fileInf.OpenRead();

            try
            {
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);

                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                lbYuklenen_dosya.Text = dosya_Yukleme;
                MessageBox.Show("Dosya Yüklendi", "Proj Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Yükleme Başarısız", "Proj Yukle",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                groupYukle.Enabled = true;
            }

            fs.Close();
            
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if(tbYukle.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bir Arşiv Dosyası Seçin","Dosya Seç", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                groupYukle.Enabled = false;
                
                bgYukle.RunWorkerAsync();
               
           
            }

        }
    }
}
