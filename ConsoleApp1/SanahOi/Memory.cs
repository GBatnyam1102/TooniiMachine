using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SanahOi
{
    class Memory
    {
        public List<MemoryItem> memoryItems;
        public Memory()
        {
            memoryItems = new List<MemoryItem>();
        }
        public void Save(int number)
        {
            memoryItems.Add(new MemoryItem(number));
        }
        public void OneItemRemove(int number)
        {
            foreach (var item1 in memoryItems)
            {
                if (item1.Equals(number))
                {
                    memoryItems.Remove(item1);
                }
            }
        }
        public void OneItemAddValue(int number)
        {
            foreach (var item1 in memoryItems)
            {
                if (item1.Equals(number))
                {
                    item1.Value += number;
                }
            }
        }

        public void OneItemSubtructValue(int number)
        {
            foreach (var item1 in memoryItems)
            {
                if (item1.Equals(number))
                {
                    item1.Value -= number;
                }
            }
        }
    }
}
