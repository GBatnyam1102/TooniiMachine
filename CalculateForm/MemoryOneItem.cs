using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.MainCalculator;
using CalculateForm;
using Calculator.SanahOi;

namespace WindowsFormsControlLibrary
{
    public partial class MemoryOneItem : UserControl
    {
        public int result = 0;
        public int total = 0;
        public MemoryOneItem()
        {
            InitializeComponent();
        }
        public void ChangeLabelText(BaseCalculator calculator)
        {
            this.OneItem.Text = calculator.Result.ToString();
            result = calculator.Result;
        }

        private void MemoryItemRemove_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.OneItem.Text) + result;
            this.OneItem.Text = total.ToString();
        }

        private void ItemSub_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.OneItem.Text) - result;
            this.OneItem.Text = total.ToString();
        }
    }
}
