using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    public class Test9
    {
        [Test]
        public void Quality_Decreasing()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},

				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                
                var previous_Quality1 = Items[0].Quality;
                var previous_Quality2 = Items[1].Quality;
                var previous_Quality3 = Items[2].Quality;
                var previous_Quality4 = Items[3].Quality;


                app.UpdateQuality();

                Assert.LessOrEqual(Items[0].Quality, previous_Quality1);
                Assert.GreaterOrEqual(Items[1].Quality, previous_Quality2);
                Assert.LessOrEqual(Items[2].Quality, previous_Quality3);
                Assert.LessOrEqual(Items[3].Quality, previous_Quality4);

            }
        }


    }
}