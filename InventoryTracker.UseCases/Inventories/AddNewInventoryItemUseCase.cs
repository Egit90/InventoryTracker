using InventoryTracker.CoreBussiness;
using InventoryTracker.UseCases.PluginInterfaces;
using InventoryTracker.UseCases.Inventories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.UseCases.Inventories
{


    public class AddNewInventoryItemUseCase : IAddNewInventoryItemUseCase
    {
        public readonly IInventoryRepository inventoryRepository;

        public AddNewInventoryItemUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }


        public async Task ExecuteAsync(Inventory item)
        {
            await this.inventoryRepository.AddInventoryItemAsync(item);
        }
    }
}
