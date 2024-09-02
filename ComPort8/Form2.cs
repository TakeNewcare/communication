using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        Form1 objForm1;

        private void ShowData()
        {
            try
            {
                con = new SqlConnection("Server=DESKTOP-4B8919P; database=database01; user id=sa; password=1234;");
                con.Open();

                cmd = new SqlCommand($"select * from table01", con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                // ※ 테이블 이름 설정
                ds.Tables[0].Columns[0].ColumnName = "수신 데이터";

                dataGridView1.DataSource = ds.Tables[0];

                // ※ 열 선택해서 비지블
                // dataGridView1.Columns[0].Visible = false;


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Refresh();

                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // 모르겠음
        private void EvenFromForm1(object sender, Form1.UpdatedDataEventArgs args)
        {
            ShowData();
        }


        public Form2(Form1 objForm1)
        {
            InitializeComponent();
            this.objForm1 = objForm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowData();
            objForm1.UpdateDataEventHandler += EvenFromForm1;
        }
    }
}
