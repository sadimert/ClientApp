using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace ClientApp
{
    public partial class Form1 : Form
    {
        Thread t;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        
        public delegate void ricdegis(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ekranabas(string s)
        {
            if (this.InvokeRequired)// thread
            {
                ricdegis degis = new ricdegis(ekranabas);
                 this.Invoke(degis, s);
            }
            else
            {
                s = "Server: " + s;
                txtEkran.AppendText(s + "\n");
            }
        }

        
        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {

                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }

        public void baglanti_kur()
        {
            try
            {
                
                baglantikur = new TcpClient("127.0.0.1", 123);
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                txtEkran.AppendText(DateTime.Now.ToString() + "Baglanti kuruldu… \n");
            }
            catch (Exception)
            {

                MessageBox.Show("Server ile baglanti kurulurken hata olustu!");
            }
        }


      

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            baglanti_kur();
        }

       
        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            if (txtGonder.Text == "")
                return;
            else
            {
                yaz = new StreamWriter(ag);
                
                //yaz.WriteLine(txtGonder.Text);
                yaz.Flush();
                txtEkran.AppendText(txtGonder.Text + "\n");
                txtGonder.Text = "\n";
                MessageBox.Show("hata");
            }
            

        }
        private void btnKes_Click(object sender, EventArgs e)
        {
            baglantikur.Client.Close();
        }

    }
}
