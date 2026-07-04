using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouseInventory_finalplease_
{
    public abstract class InventoryItem
    {
        private string itemID;
        private int quantity;
        protected string itemName;

        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public decimal BaseCost { get; set; }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public InventoryItem(string id, string name, decimal cost, int qty)
        {
            ItemID = id;
            ItemName = name;
            BaseCost = cost;
            Quantity = qty;
        }

        public abstract decimal CalculateStorageFee();
    }
}
