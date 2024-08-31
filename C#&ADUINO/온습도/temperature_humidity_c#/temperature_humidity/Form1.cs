using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature_humidity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !serialPort1.IsOpen)
            {
                 // 온습도
                serialPort1.PortName = textBox1.Text.ToString();

                try {
                    serialPort1.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("오픈!");


            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                byte[] buffer = new byte[4];
                serialPort1.Read(buffer, 0, 4);
                serialPort1.Write(buffer, 0, 4);



                float t = ((buffer[0] * 256) + buffer[1]) / 100.0f;
                float h = ((buffer[2] * 256) + buffer[3]) / 100.0f;



                label5.Text = t.ToString("F2") + "'c";
                label6.Text = h.ToString("F2") + "%";

                // 데이터 집합 생성
                ListViewItem lvi = new ListViewItem();
                lvi.Text = DateTime.Now.ToString();

                lvi.SubItems.Add(t.ToString("F2"));        // 리스트뷰의 첫번째 아이탬은 text로 넣고 다음 요소들은 subitems.add로 넣는다.
                lvi.SubItems.Add(h.ToString("F2"));

                listView1.Items.Add(lvi);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "output.csv";

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);     // 쓸 준비 완료

            for (int i = 0; i<listView1.Items.Count; i++)
            {
                // listView1.Items[i].SubItems[0]
                sw.WriteLine(listView1.Items[i].SubItems[0].Text + "," + listView1.Items[i].SubItems[1].Text + "," + listView1.Items[i].SubItems[2].Text);

            }

            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();
        }
    }
}
