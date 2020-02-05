using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Enums;
using Business_Layer.Interfaces;
using Business_Layer.Exceptions;

namespace Business_Layer
{
    public static class InventoryFactory
    {
        public static IInventory GetInventory(IDictionary<string, string> settings)
        {
            IInventory inventory = null;

            InventoryType type;
            Enum.TryParse(settings["InventoryType"], out type);

            switch (type)
            {
                case InventoryType.InMemory:
                    inventory = new InnerStorage(settings);
                    break;
                default:
                    throw new IncorrectStorage($"Incorrect inventorytype: {type}.");
            }

            return inventory;
            
        }
    }
}
