using System;

namespace Lists
{
    public class ListArray
    {
        private Item[] arrayOfItems;
        private int numItems;
        private int capacity;

        public bool Full() => numItems >= arrayOfItems.Length;
        public bool Empty() => numItems == 0;
        public int FreeSpaces() => arrayOfItems.Length - numItems;
        public int Length() => arrayOfItems.Length;

        public int Count
        {
            get { return numItems; }
        }

        public ListArray() : this(capacity: 100)
        {
        }

        public ListArray(int capacity)
        {
            arrayOfItems = new Item[capacity];
            this.capacity = capacity;
            numItems = 0;
        }

        public void Add(Item item)
        {
            if (FreeSpaces() < 10)
            {
                Array.Resize(ref arrayOfItems, arrayOfItems.Length + 100);
            }
            arrayOfItems[numItems] = item;
            numItems++;
        }

        public bool Remove(Item item)
        {
            // Removes all items that match item. 
            // Returns true if there was any.
            int location = 0;
            bool result = false;
            while (location < numItems)
            {
                if (arrayOfItems[location].ProductName == item.ProductName)
                {
                    arrayOfItems[location] = arrayOfItems[numItems - 1];
                    numItems--;
                    location--; // to ensure item moved up is checked
                    result = true;
                }
                location++;
            }
            if (FreeSpaces() >= 110)
            {
                Array.Resize(ref arrayOfItems, arrayOfItems.Length - 100);
            }
            return result;
        }


        public void RemoveAt(int index)
        {
            if (numItems >= index)
            {
                arrayOfItems[index] = arrayOfItems[numItems];
                numItems--;
            }
        }

        public Item Retrieve(int index)
        {
            if (index <= numItems)
            {
                return arrayOfItems[index];
            }
            else
            {
                throw new InvalidOperationException("Index out of boundaries");
            }
        }

        public bool Found(Item item, out int position)
        {
            for (int i = 0; i < numItems; i++)
            {
                if (arrayOfItems[i].ProductName == item.ProductName)
                {
                    position = i;
                    return true;
                }
            }
            position = -1;
            return false;
        }
    }
}
