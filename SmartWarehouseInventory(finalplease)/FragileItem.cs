using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouseInventory_finalplease_
{
    public class FragileItem : InventoryItem
    {
        public int CushioningLevel { get; set; }

        public FragileItem(string id, string name, decimal cost, int qty, int level)
            : base(id, name, cost, qty)
        {
            CushioningLevel = level;
        }

        public override decimal CalculateStorageFee()
        {
            return (BaseCost * Quantity) * 0.08m + (CushioningLevel * 5.00m);
        }
    }
}
