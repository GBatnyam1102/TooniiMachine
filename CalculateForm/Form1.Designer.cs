namespace CalculateForm
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            memoryOneItem1 = new WindowsFormsControlLibrary.MemoryOneItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            Equalbutton = new Button();
            button0 = new Button();
            MemorySaveButton = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ResultClearButton = new Button();
            AddButton = new Button();
            SubButton = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 209);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(0, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(856, 47);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(memoryOneItem1);
            flowLayoutPanel1.Location = new Point(859, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(305, 515);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // memoryOneItem1
            // 
            memoryOneItem1.Dock = DockStyle.Fill;
            memoryOneItem1.Location = new Point(3, 4);
            memoryOneItem1.Margin = new Padding(3, 4, 3, 4);
            memoryOneItem1.Name = "memoryOneItem1";
            memoryOneItem1.Size = new Size(296, 0);
            memoryOneItem1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(Equalbutton, 2, 4);
            tableLayoutPanel1.Controls.Add(button0, 1, 4);
            tableLayoutPanel1.Controls.Add(MemorySaveButton, 0, 4);
            tableLayoutPanel1.Controls.Add(button9, 2, 3);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button7, 0, 3);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 5, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(ResultClearButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(SubButton, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 209);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(856, 333);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Equalbutton
            // 
            Equalbutton.BackColor = Color.DarkViolet;
            Equalbutton.Dock = DockStyle.Fill;
            Equalbutton.Font = new Font("Segoe UI", 18F);
            Equalbutton.Location = new Point(576, 267);
            Equalbutton.Name = "Equalbutton";
            Equalbutton.Size = new Size(277, 63);
            Equalbutton.TabIndex = 14;
            Equalbutton.Text = "=";
            Equalbutton.UseVisualStyleBackColor = false;
            Equalbutton.Click += Equalbutton_Click;
            // 
            // button0
            // 
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Segoe UI", 18F);
            button0.Location = new Point(294, 267);
            button0.Name = "button0";
            button0.Size = new Size(276, 63);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Number_Click;
            // 
            // MemorySaveButton
            // 
            MemorySaveButton.BackColor = Color.Orange;
            MemorySaveButton.Dock = DockStyle.Fill;
            MemorySaveButton.Font = new Font("Segoe UI", 18F);
            MemorySaveButton.Location = new Point(3, 267);
            MemorySaveButton.Name = "MemorySaveButton";
            MemorySaveButton.Size = new Size(285, 63);
            MemorySaveButton.TabIndex = 12;
            MemorySaveButton.Text = "MS";
            MemorySaveButton.UseVisualStyleBackColor = false;
            MemorySaveButton.Click += MemorySaveButton_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 18F);
            button9.Location = new Point(576, 201);
            button9.Name = "button9";
            button9.Size = new Size(277, 60);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Number_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 18F);
            button8.Location = new Point(294, 201);
            button8.Name = "button8";
            button8.Size = new Size(276, 60);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Number_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(3, 201);
            button7.Name = "button7";
            button7.Size = new Size(285, 60);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Number_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(576, 135);
            button6.Name = "button6";
            button6.Size = new Size(277, 60);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Number_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(294, 135);
            button5.Name = "button5";
            button5.Size = new Size(276, 60);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Number_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(576, 69);
            button3.Name = "button3";
            button3.Size = new Size(277, 60);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Number_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 135);
            button4.Name = "button4";
            button4.Size = new Size(285, 60);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Number_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(294, 69);
            button2.Name = "button2";
            button2.Size = new Size(276, 60);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Number_Click;
            // 
            // ResultClearButton
            // 
            ResultClearButton.Dock = DockStyle.Fill;
            ResultClearButton.Font = new Font("Segoe UI", 18F);
            ResultClearButton.Location = new Point(294, 3);
            ResultClearButton.Name = "ResultClearButton";
            ResultClearButton.Size = new Size(276, 60);
            ResultClearButton.TabIndex = 1;
            ResultClearButton.Text = "C";
            ResultClearButton.UseVisualStyleBackColor = true;
            ResultClearButton.Click += ResultClearButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Red;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Font = new Font("Segoe UI", 18F);
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(285, 60);
            AddButton.TabIndex = 0;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // SubButton
            // 
            SubButton.BackColor = Color.DeepSkyBlue;
            SubButton.Dock = DockStyle.Fill;
            SubButton.Font = new Font("Segoe UI", 18F);
            SubButton.Location = new Point(576, 3);
            SubButton.Name = "SubButton";
            SubButton.Size = new Size(277, 60);
            SubButton.TabIndex = 2;
            SubButton.Text = "-";
            SubButton.UseVisualStyleBackColor = false;
            SubButton.Click += SubButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 69);
            button1.Name = "button1";
            button1.Size = new Size(285, 60);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Number_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(859, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 25);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Memory";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 542);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button SubButton;
        private Button ResultClearButton;
        private Button AddButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private WindowsFormsControlLibrary.MemoryOneItem memoryOneItem1;
        private Button button4;
        private Button button2;
        private Button Equalbutton;
        private Button button0;
        private Button MemorySaveButton;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
    }
}
