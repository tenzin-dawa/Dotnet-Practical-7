using System;
using System.Collections.Generic;
using System.Text;
using ItemInfo;
namespace Sorting
{
    public class VGeneric
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>(10);
            items.Add(new Item(1,800, "Shirt", ItemType.Cotton));
            items.Add(new Item(2,1500, "Trousers", ItemType.Nylon));
            items.Add(new Item(3,3000, "Coat", ItemType.Cordroy));
            items.Add(new Item(4,2000, "Jacket", ItemType.Polyester));
            items.Add(new Item(5,1000, "Sweater", ItemType.Woolen));
            Console.WriteLine("\nITEMS SORTED AS PER NAME: ");
            ItemSelcSort.Sort<Item>(items, Item.CompareName);
            items.Reverse();
            foreach(Item i1 in items)
            {
                Console.WriteLine(i1.Name);
            }
            Console.WriteLine("\nITEMS SORTED AS PER COST: ");
            ItemSelcSort.Sort<Item>(items, Item.CompareCost);
            foreach(Item i1 in items)
            {
                Console.WriteLine($"{i1.Name} : RS {i1.Cost}");
            }
            Console.WriteLine("\nITEMS SORTED AS PER TYPE: ");
            ItemSelcSort.Sort<Item>(items, Item.CompareVehicleType);
            foreach(Item i1 in items)
            {
                Console.WriteLine($"{i1.Name} : {i1.itemType}");
            }
        }
    }
}