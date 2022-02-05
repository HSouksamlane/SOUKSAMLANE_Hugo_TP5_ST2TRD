using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{

    public class Test7
    {
        [Test]
        public void Sulfuras_SellIn()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                var previous_SellIn1 = Items[0].SellIn;
                var previous_SellIn2 = Items[1].SellIn;

                app.UpdateQuality();

                Assert.AreEqual(Items[0].SellIn, previous_SellIn1);
                Assert.AreEqual(Items[1].SellIn, previous_SellIn2);
            }
        }


    }
}