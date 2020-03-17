using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo.C_Sharp_Exam
{
    class Warehouse
    {
        string WarehouseLocation;

        public Warehouse(string warehouseLocation)
        {
            WarehouseLocation1 = warehouseLocation;
        }

        public string WarehouseLocation1 { get => WarehouseLocation; set => WarehouseLocation = value; }
    }
    class Item : Warehouse
    {
        int itemId;
        string itemname;

        public int ItemId1 { get => itemId; set => itemId = value; }
        public string Itemname { get => itemname; set => itemname = value; }

        public Item(string WarehoseLocation, int itemid, string itemName) : base(WarehoseLocation)
        {
            this.ItemId1 = ItemId1;
            Itemname = itemName;
        }

    }
    class Sales
    {
        List<Item> l = new List<Item>();
        public void AddItem(Item i)
        {
            l.Add(i);

        }

        public void FindandReturnItem(int Itemno)
        {
            // Console.WriteLine(l[1].Itemname);
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].ItemId1 == Itemno)
                {
                    l.Remove(l[i]);
                    Console.WriteLine(l[i].Itemname);

                }
            }

        }
        public void print()
        {
            for (int i = 0; i < l.Count; i++)
            {

                Console.WriteLine("Item no: " + l[i].Itemname + "\nItem name: " + l[i].ItemId1 + "\nLocation: " + l[i].WarehouseLocation1);

            }
        }


    }
    class question2Maincl
    {
        static void Main(string[] args)
        {


            Sales s = new Sales();

            Item i1 = null;
            Console.Write("Do you want to Add Item?(Y/N): ");
            char ch1 = char.Parse(Console.ReadLine());
            while (ch1 == 'Y' || ch1 == 'y')
            {

                Console.WriteLine("Enter work location");
                string loc = Console.ReadLine();
                Console.Write("Enter Itemno:");
                int ItemId = int.Parse(Console.ReadLine());
                Console.Write("Enter ItemName:");
                string ItemName = Console.ReadLine();
                i1 = new Item(loc, ItemId, ItemName);
                s.AddItem(i1);
                Console.Write("Do you want to Add an Item?(Y/N): ");
                ch1 = char.Parse(Console.ReadLine());


            }
            Console.Write("Do you want to Remove an Item?(Y/N): ");
            ch1 = char.Parse(Console.ReadLine());
            while (ch1 == 'Y' || ch1 == 'y')
            {
                int k = int.Parse(Console.ReadLine());
                s.FindandReturnItem(k);
                Console.Write("Do you want to Remove an Item?(Y/N): ");
                ch1 = char.Parse(Console.ReadLine());

            }

            s.FindandReturnItem(2);
            s.print();
        }
    }
}

