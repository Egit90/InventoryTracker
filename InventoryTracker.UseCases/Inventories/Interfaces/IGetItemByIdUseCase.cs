using InventoryTracker.CoreBussiness;

namespace InventoryTracker.UseCases.Inventories.Interfaces
{
    public interface IGetItemByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int id);
    }
}