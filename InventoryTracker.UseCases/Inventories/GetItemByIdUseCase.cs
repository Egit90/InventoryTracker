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
    public class GetItemByIdUseCase : IGetItemByIdUseCase
    {
        public readonly IInventoryRepository ir;

        public GetItemByIdUseCase(IInventoryRepository ir)
        {
            this.ir = ir;
        }
        public async Task<Inventory> ExecuteAsync(int id)
        {
            var item = await this.ir.GetItemById(id);

            if (item == null)
            {
                return null;

            }

            return item;

        }

    }
}
