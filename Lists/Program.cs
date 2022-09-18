﻿using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the class
            var myList = new ListArray();
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "apples", Quantity = 1 });
            myList.Add(new Item { ProductName = "milk", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "apples", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            // List the items in the list

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(myList.Retrieve(i).ProductName);
            }

            // Remove carrots

            myList.Remove(new Item { ProductName = "carrots" });

            // List the items in the list again
            Console.WriteLine("\n");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(myList.Retrieve(i).ProductName);
            }

            // Test adding new spaces
            Console.WriteLine("\nCurrent spaces: " + myList.Length()); // Expected: 100
            Console.WriteLine("Adding 100 items");
            for (int i = 0; i < 100; i++)
            {
                myList.Add(new Item { ProductName = "egg", Quantity = 1 });
            }
            Console.WriteLine("Current spaces: " + myList.Length()); // Expected: 200

            // Test removing unused spaces
            Console.WriteLine("Removing 100 items");
            myList.Remove(new Item { ProductName = "egg" });
            Console.WriteLine("Current spaces: " + myList.Length()); // Expected: 100

            // Ask the user for an item and output its position in the list

            Console.WriteLine("\nItem name: ");
            string item_name = Console.ReadLine();

            Console.WriteLine("Item quantity: ");
            int item_quant = int.Parse(Console.ReadLine());

            Item item = new Item { ProductName = item_name, Quantity = item_quant };

            int position;
            Console.WriteLine(myList.Found(item, out position));
            Console.WriteLine(position);
        }
    }
}
