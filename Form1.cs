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
                textBox1.Clear();

            }
        }
    }
}
