using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var app = new Refactoring(Items);

            for (var i = 0; i < Items.Count; i++)
            {
                var current_item = Items[i].Name;

                switch (current_item)
                {
                    case "Aged Brie":
                        app.Update_Brie_Quality(i);
                        break;

                    case "Sulfuras, Hand of Ragnaros":
                        break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        app.Update_Concert_Ticket_Quality(i);
                        break;

                    case "Conjured Mana Cake":
                        app.Update_Conjured_Item(i);
                        break;

                    default:
                        app.Update_Common_Item(i);
                        break;
                }
                
            }
        }
    }
}
