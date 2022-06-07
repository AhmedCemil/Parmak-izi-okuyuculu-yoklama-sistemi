using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;

namespace Parmakiziokuyucuyoklamasistemi
{
    public partial class form_ArduinoHaberlesmesi : Form
    {
        public form_ArduinoHaberlesmesi()
        {
            InitializeComponent();
        }

        SQL Sql = new SQL();
        public int receivedID;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // Bu kısımda portlardan gelen bilgileri string listesine alıp
            foreach (string port in ports) // Her bir port bilgisini
                comboBox1.Items.Add(port); // comboBox1 içerisine listeliyoruz.

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataRecieved);
        }
        
        public bool isSerialPortOpen()
        {
            if (serialPort1.IsOpen) return true; else return false;
        }

        private void SerialPort1_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);

            string data = serialPort1.ReadLine();       // bufferdan verileri oku
            if (GelenVeri.InvokeRequired)
            {
                GelenVeri.Invoke(new MethodInvoker(delegate
                {
                    if (data[0] >= 48 && data[0] <= 57)
                    {
                        receivedID = fpToParmakizi(Int16.Parse(data.Substring(0, 3)));
                    }
                        GelenVeri.AppendText(data + "\r\n");
                }));
            }
        }

        private int fpToParmakizi(int receivedInt)
        {
            string komut_fpToParmakizi = "SELECT * FROM [Parmak İzi Yoklama Sistemi].dbo.Parmakİzi";
            DataTable tablo_Parmakizi = Sql.Tablo(komut_fpToParmakizi);
            for (int i = 0; i < tablo_Parmakizi.Rows.Count; i++)
            {
                if (tablo_Parmakizi.Rows[i]["Fp_id"].ToString() == receivedInt.ToString()) return Int16.Parse(tablo_Parmakizi.Rows[i]["Parmakİzi_id"].ToString());
            }
            return -1;
        }

        private void KayitGir_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("e"); // 1. butona bastığımızda Arduino ya e karakteri gönderiyoruz
                label1.Text = "Ekleme komutu gönderildi."; // işlemin gerçekleştiğini label yazısından gözlemliyoruz
            }
            else MessageBox.Show("Port kapalıyken data gönderilemez!");
        }

        private void KayitSil_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("s"); // 2. butona bastığımızda Arduino ya s karakteri gönderiyoruz
                label1.Text = "Silme komutu gönderildi."; // işlemin gerçekleştiğini label yazısından gözlemliyoruz
            }
            else MessageBox.Show("Port kapalıyken data gönderilemez!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString(); // ComboBox1 listesinden seçtiğimiz port ismini
                                                        // serialPort1 e aktarıyoruz ki arduino ya bağlantı kurabilelim.
            serialPort1.Open(); // Arduino ya bağlantı kurduracak serialimizi aktif ediyoruz.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close(); // Form kapatılırken eğer serial portumuz açık kaldıysa kapatıyoruz.
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            GelenVeri.Clear();
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write(GidenVeri.Text + "\n");
            else MessageBox.Show("Port kapalıyken data gönderilemez!");
        }
    }
}
