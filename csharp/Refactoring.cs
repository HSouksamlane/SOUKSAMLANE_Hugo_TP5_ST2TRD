using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Refactoring
    {
        IList<Item> Items;
        public Refactoring(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void Update_Brie_Quality(int i)
        {
            Items[i].SellIn = Items[i].SellIn - 1;
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;
                if (Items[i].SellIn < 0)
                {
                    Items[i].Quality = Items[i].Quality + 1;
                }
            }
        }
        public void Update_Concert_Ticket_Quality(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;

                if (Items[i].SellIn < 11 && Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;
                }

                if (Items[i].SellIn < 6 && Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;
                }
            }
            Items[i].SellIn = Items[i].SellIn - 1;

            if (Items[i].SellIn < 0)
            {
                Items[i].Quality = Items[i].Quality - Items[i].Quality;
            }
        }
        
        public void Update_Common_Item(int i)
        {
            Items[i].SellIn = Items[i].SellIn - 1;
            if (Items[i].Quality > 0)
            {
                Items[i].Quality = Items[i].Quality - 1;
            }
            if (Items[i].SellIn < 0 && Items[i].Quality > 0)
            {
                Items[i].Quality = Items[i].Quality - 1;
            }
        }

        public void Update_Conjured_Item(int i)
        {
            Items[i].SellIn = Items[i].SellIn - 1;
            if (Items[i].Quality > 0)
            {
                Items[i].Quality = Items[i].Quality - 2;              
            }
            if (Items[i].SellIn < 0 && Items[i].Quality > 0)
            {
                Items[i].Quality = Items[i].Quality - 2;
            }
        }
    }
}
