using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{

    public class Test1
    {
       
        [Test]
        public void Concert_Ticket_Expiration()
        {
            IList<Item> Items = new List<Item>{              
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                for (var j = 0; j < Items.Count; j++)
                {
                    if (Items[j].SellIn<0)
                    {
                        Assert.AreEqual(0, Items[j].Quality);
                    }
                }
                app.UpdateQuality();
            }
        }

       

    }
}