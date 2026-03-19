using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1; // Enter가 눌리면 button1 클릭처럼 작동하도록 설정
            UpdateCount();
        }



        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var text = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                // 메시지 앞에 현재 시간을 출력
                var stamped = $"[{DateTime.Now:HH:mm:ss}] {text}";
                listbox1.Items.Add(stamped);
                UpdateCount();
                // 입력창 초기화
                textBox1.Clear();
                // 입력창으로 포커스를 돌려 바로 입력할 수 있게 함
                textBox1.Focus();
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = 0;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        // 현재 몇개의 메시지 개수가 있는지 보여줌
        private void UpdateCount()
        {
            lblcount.Text = $"현재 대화 : {listbox1.Items.Count}개";
        }
    }
}
