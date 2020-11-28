using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelController
{
    public partial class Form1 : Form
    {
        private ExcelController_class ExcelObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file_path = ShowFileOpenDialog();
            ExcelObj = new ExcelController_class(file_path);
        }

        /// <summary>
        /// 그림파일오픈창을 로드후 해당 파일의 FullPath를 가져온다.
        /// </summary>
        /// <returns>파일의 FullPath 파일이 없거나 선택을 안할경우 ""를 리턴</returns>
        public string ShowFileOpenDialog()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            //ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";
            ofd.Filter = "엑셀 파일 (*.xlsx, *.xls) | *.xlsx; *.xls; | 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");

                //출력 예제용 로직
                label1.Text = "File Name  : " + fileName;
                label2.Text = "Full Name  : " + fileFullName;
                label3.Text = "File Path  : " + filePath;
                //File경로 + 파일명 리턴
                textBox1.Text = fileFullName;
                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                textBox1.Text = "";
                return "";
            }

            textBox1.Text = "";
            return "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelObj.CloseExcel();
        }

        private void exOpenBtn_Click(object sender, EventArgs e)
        {
            ExcelObj.OpenExcel();
        }

        private void exWriteBtn_Click(object sender, EventArgs e)
        {
            ExcelObj.WriteSomething(time_label.Text);
        }
    }
}
