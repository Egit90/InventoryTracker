using InventoryTracker.CoreBussiness;

namespace InventoryTracker.UseCases.Inventories.Interfaces
{
    public interface IAddNewInventoryItemUseCase
    {
        Task ExecuteAsync(Inventory item);
    }
}