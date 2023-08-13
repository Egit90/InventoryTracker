using InventoryTracker.CoreBussiness;

namespace InventoryTracker.UseCases.Inventories.Interfaces
{
    public interface IUpdateInventoryItemUseCase
    {
        Task ExecuteAsync(Inventory item);
    }
}