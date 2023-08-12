using InventoryTracker.CoreBussiness;
using InventoryTracker.UseCases.PluginInterfaces;

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
    }
}