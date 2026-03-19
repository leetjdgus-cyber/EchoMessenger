namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            listbox1 = new ListBox();
            button1 = new Button();
            lblcount = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(90, 40);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(90, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listbox1
            // 
            listbox1.FormattingEnabled = true;
            listbox1.Location = new Point(90, 100);
            listbox1.Name = "listbox1";
            listbox1.Size = new Size(622, 199);
            listbox1.SelectionMode = SelectionMode.MultiExtended;
            listbox1.TabIndex = 2;
            listbox1.SelectedIndexChanged += listbox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(595, 315);
            button1.Name = "button1";
            button1.Size = new Size(117, 78);
            button1.TabIndex = 3;
            button1.Text = "전송";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(90, 315);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(0, 15);
            lblcount.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("한컴 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            buttonClear.Location = new Point(482, 382);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(90, 46);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "기록 삭제";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete = new Button();
            buttonDelete.Font = new Font("한컴 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            buttonDelete.Location = new Point(382, 382);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 46);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "삭제";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblcount);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(button1);
            Controls.Add(listbox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listbox1;
        private Button button1;
        private Label lblcount;
        private Button buttonClear;
        private Button buttonDelete;
    }
}
