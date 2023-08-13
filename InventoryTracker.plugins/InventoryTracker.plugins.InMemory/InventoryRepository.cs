using InventoryTracker.CoreBussiness;
using InventoryTracker.UseCases.PluginInterfaces;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace InventoryTracker.plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository() {

            _inventories = new List<Inventory>() {

            new Inventory() {InventoryID = 1, InventoryName = "Bike Seat" , Quantity = 10 , Price = 2 },
            new Inventory() {InventoryID = 2, InventoryName = "Bike Body" , Quantity = 10 , Price = 15 },
            new Inventory() {InventoryID = 3, InventoryName = "Bike Wheels" , Quantity = 10 , Price = 8 },
            new Inventory() {InventoryID = 4, InventoryName = "Bike Peadels" , Quantity = 20 , Price = 2 },
            };
        
        }


        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_inventories);
            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
        public Task AddInventoryItemAsync(Inventory item)
        {
            if ( _inventories.Any(x=> x.InventoryName.Equals(item.InventoryName , StringComparison.OrdinalIgnoreCase)) && item.InventoryName != "" && item.Quantity != 0)
            {
                var existingInventory = _inventories.Find(x => x.InventoryName.Equals(item.InventoryName, StringComparison.OrdinalIgnoreCase));
                if (existingInventory != null)
                {
                    existingInventory.Quantity += item.Quantity;
                }
                return Task.CompletedTask;
            }
            if ( item.InventoryName != "" && item.Quantity != 0)
            {
                item.InventoryID = _inventories.Max(x => x.InventoryID) + 1;
                _inventories.Add(item);
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }
        public Task UpdateItemAsync(Inventory item)
        {
            var thisItem = _inventories.Find(x => x.InventoryID.Equals(item.InventoryID));

            if (thisItem != null)
            {
                thisItem.InventoryName = item.InventoryName;
                thisItem.Price = item.Price;
                thisItem.Quantity = item.Quantity;
            }
            return Task.CompletedTask;

        }
        public Task<Inventory> GetItemById(int id)
        {
            var item = _inventories.Find(x => x.InventoryID.Equals(id));

            if(item != null)
            {
                return Task.FromResult(item);
            }

            return Task.FromResult<Inventory>(null);
        }
    }
}