using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SanahOi
{
    public class Memory
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
            if(memoryItems.Count > 0)
            {
                var itemsToRemove = memoryItems.Where(item => item.Value == number).ToList();
                foreach (var item in itemsToRemove)
                {
                    memoryItems.Remove(item);
                }
            }
        }
       
    }
}
