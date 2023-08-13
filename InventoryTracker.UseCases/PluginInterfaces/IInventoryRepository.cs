using InventoryTracker.CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);
        Task AddInventoryItemAsync(Inventory item);

        Task UpdateItemAsync(Inventory item);

        Task<Inventory> GetItemById(int id);
    }
}
