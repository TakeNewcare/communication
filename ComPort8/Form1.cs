using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ComPort
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendwith;
        string dataIn;
        SqlConnection con;
        SqlCommand cmd;

        StreamWriter objStreamWriter;

        string pathFile;

        bool state_AppendText = true;  // append로 텍스트 추가할건지

        // 파일에 데이터 넣기

        /*
         1. streamwtiter 객체를 생성하여 메모장 경로 넣어주기
        2. write 함수를 이용하여 쓰기
        3. close 함수를 이용하여 저장
         */

        #region My Own Method
        private void SaveDataToTxtFile()
        {

            if (fileToolStripMenuItem.Checked)
            {
                try
                {
                    // StreamWriter 클래스 : 파일에 텍스트를 쓰기 위해 사용되는 클래스
                    // 파라미터로 경로와 파일에 데이터를 추가할지의 여부가 들어간다.
                    objStreamWriter = new StreamWriter(pathFile, state_AppendText);

                    if (toolStripComboBox_writeLineOrwriteText.Text == "줄바꿈")
                    {
                        objStreamWriter.WriteLine(dataIn);
                    }
                    else if (toolStripComboBox_writeLineOrwriteText.Text == "쓰기")
                    {
                        objStreamWriter.Write(dataIn + " ");
                    }

                    objStreamWriter.Close(); // 닫아줘야, 적은 데이터를 저장하거나 다른 사용자가 사용할 수 있게 된다.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }
        
        private void SaveDataToSqlDatabase()
        {
            if (SaveToDatabase.Checked)
            {

                try
                {
                    con = new SqlConnection("Server=DESKTOP-4B8919P; database=database01; user id=sa; password=1234;");
                    con.Open();

                    cmd = new SqlCommand($"insert into table01 values ({dataIn})", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    RefreshDataGridViewForm2();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        //------------ 여기서 모르겠음
        #region EventHandler
        public delegate void UpdateDelegate(object sender, UpdatedDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;

        public class UpdatedDataEventArgs : EventArgs
        {

        }

        protected void RefreshDataGridViewForm2()
        {
            UpdatedDataEventArgs args = new UpdatedDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }
        //------------ 여기까지


        #endregion
        #endregion

        #region GUI Method


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;

            btnSendData.Enabled = true;
            toolStripComboBox3.Text = "위";


            sendwith = "둘다";

            toolStripComboBox1.Text = "기존 데이터에 추가";
            toolStripComboBox2.Text = "둘다";

            toolStripComboBox_appendOrOverwriteText.Text = "데이터 추가";
            toolStripComboBox_writeLineOrwriteText.Text = "줄바꿈";

            // 현재 포르젝트의 디렉토리 경로를 얻는다
            pathFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            // C:\Users\User\Desktop\시리얼 통신\ComPort\bin\Debug
            // System.IO.Directory.GetCurrentDirectory() : 현재 프로젝트 디렉토리 경로 반환
            // Path.GetDirectoryName(...) : 주어진 경로의 상위 디렉토리 경로 반환
            // 이중으로 사용하여 두번째 상위 디렉토리 경로를 찾는다.

            pathFile += @"\_My Source File\SerialData.txt";

            saveToTxtFileToolStripMenuItem.Checked = false;
            SaveToDatabase.Checked = false;
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);


                serialPort1.Open();
                progressBar1.Value = 100;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;

                if (sendwith == "없음")
                {
                    serialPort1.Write(dataOUT);
                }
                else if (sendwith == "둘다")
                {
                    serialPort1.Write(dataOUT + "\r\n");
                }
                else if (sendwith == "새 라인")
                {
                    serialPort1.Write(dataOUT + "\n");

                }
                else if (sendwith == "가장 앞으로")
                {
                    serialPort1.Write(dataOUT + "\r");
                }
            }
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //            None
            //Both
            //New Line
            //Carrige Return

            if (toolStripComboBox2.Text == "없음")
            {
                sendwith = "없음";
            }
            else if (toolStripComboBox2.Text == "둘다")
            {
                sendwith = "둘다";
            }
            else if (toolStripComboBox2.Text == "새 라인")
            {
                sendwith = "새 라인";
            }
            else if (toolStripComboBox2.Text == "가장 앞으로")
            {
                sendwith = "가장 앞으로";
            }
        }


        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                serialPort1.RtsEnable = false;
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }


        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tBoxDataOut.Text.Length;
            lblDataOutLength.Text = string.Format("{0:00}", dataOutLength);

        }


        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;  // 해당 키 이벤트가 더 이상 다른 핸들러에 의해 처리되지 않도록 할 수 있다.
                e.SuppressKeyPress = true; //  해당 키 입력이 기본적으로 처리되지 않도록 막습니다. 예를 들어, 텍스트 박스에서 키 입력을 무시하려면 이 속성을 사용

            }
        }

        private void doSomething()
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if (sendwith == "없음")
                {
                    serialPort1.Write(dataOUT);
                }
                else if (sendwith == "둘다")
                {
                    serialPort1.Write(dataOUT + "\r\n");
                }
                else if (sendwith == "새 라인")
                {
                    serialPort1.Write(dataOUT + "\n");
                }
                else if (sendwith == "가장 앞으로")
                {
                    serialPort1.Write(dataOUT + "\r");
                }
            }
        }





        // 데이터 받아오기
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(showData));
        }

        private void showData(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "항상 새로고침")
            {
                tBoxDataIN.Text = dataIn;
            }
            else if (toolStripComboBox1.Text == "기존 데이터에 추가")
            {
                if (toolStripComboBox3.Text == "위")
                {
                    tBoxDataIN.Text = tBoxDataIN.Text.Insert(0, dataIn);   // 최신 데이터를 최상단에 위치하도록 설정 => tera term 은 반대로 나온다

                }
                else if (toolStripComboBox3.Text == "아래")
                {
                    tBoxDataIN.Text += dataIn;

                }
            }

            int dataInLength = tBoxDataIN.Text.Length;

            lblDataInLength.Text = string.Format("{0:00}", dataInLength);

            SaveDataToTxtFile();
            SaveDataToSqlDatabase();

        }


        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox12.Width = panel1.Width - 230;
            groupBox12.Height = panel1.Height - 47;
            tBoxDataIN.Height = panel1.Height - 91;

            // 7강 시작
        }

        private void toolStripComboBox_appendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_appendOrOverwriteText.Text == "데이터 추가")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;

            }
        }

        private void DataScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objform2 = new Form2(this);
            objform2.Show();
        }

        #endregion


    }
}
