using InventoryTracker.CoreBussiness;
using InventoryTracker.UseCases.Inventories.Interfaces;
using InventoryTracker.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.UseCases.Inventories
{
    public class UpdateInventoryItemUseCase : IUpdateInventoryItemUseCase
    {
        public readonly IInventoryRepository inventoryRepository;

        public UpdateInventoryItemUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory item)
        {
            await this.inventoryRepository.UpdateItemAsync(item);
        }

    }

}
