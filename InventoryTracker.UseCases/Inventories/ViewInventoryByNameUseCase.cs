using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTracker.CoreBussiness;
using InventoryTracker.UseCases.Inventories.Interfaces;
using InventoryTracker.UseCases.PluginInterfaces;

namespace InventoryTracker.UseCases.Inventories
{
    public class ViewInventoryByNameUseCase : IViewInventoryByNameUseCase
    {
        public readonly IInventoryRepository InventoryRepository;
        public ViewInventoryByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.InventoryRepository = inventoryRepository;
        }


        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await InventoryRepository.GetInventoryByNameAsync(name);
        }

    }
}
