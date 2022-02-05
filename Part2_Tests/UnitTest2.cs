using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    public class Test2
    {
        
        [Test]
        public void Cheese_Maturation()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                for (var j = 0; j < Items.Count; j++)
                {
                    
                    Assert.GreaterOrEqual(Items[j].Quality, 0);
                    
                }
                app.UpdateQuality();
            }
        }



    }
}
