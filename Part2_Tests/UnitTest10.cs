using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    public class Test10
    {
        [Test]
        public void Quality_Decreasing_x2()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},

            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {

                var previous_Quality1 = Items[0].Quality;
                var previous_Quality2 = Items[1].Quality;
                var previous_Quality3 = Items[2].Quality;

                app.UpdateQuality();


                if ((Items[0].SellIn < 0) & (Items[0].Quality != 0))
                {
                    Assert.IsTrue(Items[0].Quality == (previous_Quality1 - 2));
                }

                if ((Items[1].SellIn < 0) & (Items[1].Quality != 50))
                {
                    Assert.IsTrue(Items[1].Quality == (previous_Quality2 + 2));
                }

                if ((Items[2].SellIn < 0) & (Items[2].Quality != 0))
                {
                    Assert.IsTrue(Items[2].Quality == (previous_Quality3 - 2));
                }

               
            

            }
        }


    }
}