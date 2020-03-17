using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class warehouse
    {
        public string warehouselocation
        {
            get;
        }
        public warehouse(string warehouselocation)
        {
            this.warehouselocation = warehouselocation;
        }
    }
    class item
    {
        public item(string warehouselocation, int itemid, string itemname) : base(warehouselocation)
        {

        }
    }
}
