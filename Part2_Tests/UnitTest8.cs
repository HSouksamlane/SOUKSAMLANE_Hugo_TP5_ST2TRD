using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    public class Test8
    {
        [Test]
        public void Descreasing_SellIn()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
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
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                var previous_SellIn1 = Items[0].SellIn;
                var previous_SellIn2 = Items[1].SellIn;
                var previous_SellIn3 = Items[2].SellIn;
                var previous_SellIn4 = Items[3].SellIn;
                var previous_SellIn5 = Items[4].SellIn;
                var previous_SellIn6 = Items[5].SellIn;

                app.UpdateQuality();

                Assert.LessOrEqual(Items[0].SellIn, previous_SellIn1);
                Assert.LessOrEqual(Items[1].SellIn, previous_SellIn2);
                Assert.LessOrEqual(Items[2].SellIn, previous_SellIn3);
                Assert.LessOrEqual(Items[3].SellIn, previous_SellIn4);
                Assert.LessOrEqual(Items[4].SellIn, previous_SellIn5);
                Assert.LessOrEqual(Items[5].SellIn, previous_SellIn6);
            }
        }


    }
}