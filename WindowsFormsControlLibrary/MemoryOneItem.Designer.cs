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
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoryClearOne = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtruct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 70);
            this.panel1.TabIndex = 0;
            // 
            // memoryClearOne
            // 
            this.memoryClearOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryClearOne.Location = new System.Drawing.Point(3, 44);
            this.memoryClearOne.Name = "memoryClearOne";
            this.memoryClearOne.Size = new System.Drawing.Size(96, 23);
            this.memoryClearOne.TabIndex = 0;
            this.memoryClearOne.Text = "MC";
            this.memoryClearOne.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(105, 44);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(93, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Subtruct
            // 
            this.Subtruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtruct.Location = new System.Drawing.Point(204, 44);
            this.Subtruct.Name = "Subtruct";
            this.Subtruct.Size = new System.Drawing.Size(93, 23);
            this.Subtruct.TabIndex = 2;
            this.Subtruct.Text = "-";
            this.Subtruct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.memoryClearOne, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Add, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Subtruct, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 70);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(204, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // MemoryOneItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MemoryOneItem";
            this.Size = new System.Drawing.Size(299, 81);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button memoryClearOne;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtruct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
