using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{

    public class Test5
    {

        [Test]
        public void Sulfuras_Quality()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                for (var j = 0; j < Items.Count; j++)
                {
                    Assert.AreEqual(Items[j].Quality, 80);
                }
                app.UpdateQuality();
            }
        }



    }
}

