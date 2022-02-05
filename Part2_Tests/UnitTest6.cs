using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{

    public class Test6
    {
        [Test]
        public void Cheese_Increases()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                var previous_quality1 = Items[0].Quality;              
                
                app.UpdateQuality();

                Assert.GreaterOrEqual(Items[0].Quality, previous_quality1);
            }
        }


    }
}