using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xkfy_mod.Domain
{
    public class StoreItem
    {
        public string StoreName { get; set; }
        public string ProductName { get; set; }
        public uint Quantity { get; set; }
        public uint Possibility { get; set; } // will use a number between 0 and 100 to represent percentage
        public uint Price { get; set; }

    }
}
