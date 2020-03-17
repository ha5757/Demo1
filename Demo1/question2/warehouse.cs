

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo.Question4
{
    class Warehouse
    {
        string WarehouseLocation;

        public Warehouse(string warehouseLocation)
        {
            WarehouseLocation = warehouseLocation;
        }
        public string WarehouseLocation1 { get => WarehouseLocation; }
    }
    class Item : Warehouse
    {
        int ItemID;
        string ItemName;

        public Item(int itemID, string itemName, string location) : base(location)
        {
            ItemID = itemID;
            ItemName = itemName;
        }

        public int ItemID1 { get => ItemID; }
        public string ItemName1 { get => ItemName; }
    }
    class Sales
    {
        List<Item> list_of_items = null;
        public Sales()
        {
            list_of_items = new List<Item>();
        }
        public void AddItem(Item i)
        {
            list_of_items.Add(i);

        }
        public Item FindandReturnItem(int item_no)
        {
            for (int i = 0; i < list_of_items.Count; i++)
            {
                if (list_of_items[i].ItemID1 == item_no)
                {
                    Item it = list_of_items[i];
                    list_of_items.Remove(list_of_items[i]);
                    return it;
                }

            }
            throw new Exception("Item not found");
        }
    }
}
