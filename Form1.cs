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
        }

        

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var text = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                listbox1.Items.Add(text);
                //입력창 초기화
                textBox1.Clear();
                // 입력창으로 포커스를 돌려 바로 입력할 수 있게 함
                textBox1.Focus();
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = 0;

            }
        }
    }
}
