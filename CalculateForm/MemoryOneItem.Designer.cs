namespace WindowsFormsControlLibrary
{
    partial class MemoryOneItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            OneItem = new Label();
            MemoryItemRemove = new Button();
            ItemAdd = new Button();
            ItemSub = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(OneItem, 2, 0);
            tableLayoutPanel1.Controls.Add(MemoryItemRemove, 0, 1);
            tableLayoutPanel1.Controls.Add(ItemAdd, 1, 1);
            tableLayoutPanel1.Controls.Add(ItemSub, 2, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(270, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OneItem
            // 
            OneItem.AutoSize = true;
            OneItem.Dock = DockStyle.Bottom;
            OneItem.Location = new Point(183, 22);
            OneItem.Margin = new Padding(3);
            OneItem.Name = "OneItem";
            OneItem.RightToLeft = RightToLeft.No;
            OneItem.Size = new Size(84, 20);
            OneItem.TabIndex = 0;
            OneItem.Text = "label1";
            OneItem.TextAlign = ContentAlignment.TopRight;
            // 
            // MemoryItemRemove
            // 
            MemoryItemRemove.Dock = DockStyle.Fill;
            MemoryItemRemove.Location = new Point(3, 48);
            MemoryItemRemove.Name = "MemoryItemRemove";
            MemoryItemRemove.Size = new Size(85, 39);
            MemoryItemRemove.TabIndex = 1;
            MemoryItemRemove.Text = "MC";
            MemoryItemRemove.UseVisualStyleBackColor = true;
            MemoryItemRemove.Click += MemoryItemRemove_Click;
            // 
            // ItemAdd
            // 
            ItemAdd.Dock = DockStyle.Fill;
            ItemAdd.Location = new Point(94, 48);
            ItemAdd.Name = "ItemAdd";
            ItemAdd.Size = new Size(83, 39);
            ItemAdd.TabIndex = 2;
            ItemAdd.Text = "+";
            ItemAdd.UseVisualStyleBackColor = true;
            ItemAdd.Click += ItemAdd_Click;
            // 
            // ItemSub
            // 
            ItemSub.Dock = DockStyle.Fill;
            ItemSub.Location = new Point(183, 48);
            ItemSub.Name = "ItemSub";
            ItemSub.Size = new Size(84, 39);
            ItemSub.TabIndex = 3;
            ItemSub.Text = "-";
            ItemSub.UseVisualStyleBackColor = true;
            ItemSub.Click += ItemSub_Click;
            // 
            // MemoryOneItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemoryOneItem";
            Size = new Size(270, 90);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button MemoryItemRemove;
        private Button ItemAdd;
        private Button ItemSub;
        private Label OneItem;
    }
}
