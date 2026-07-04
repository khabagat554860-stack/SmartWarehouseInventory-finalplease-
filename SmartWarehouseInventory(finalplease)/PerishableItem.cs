using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouseInventory_finalplease_
{
    public class PerishableItem : InventoryItem
    {
        public double TemperatureSetting { get; set; }

        public PerishableItem(string id, string name, decimal cost, int qty, double temp)
            : base(id, name, cost, qty)
        {
            TemperatureSetting = temp;
        }

        public override decimal CalculateStorageFee()
        {
            return (BaseCost * Quantity) * 0.15m;
        }
    }
}
