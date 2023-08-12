using InventoryTracker.CoreBussiness;

namespace InventoryTracker.UseCases.Inventories.Interfaces
{
    public interface IViewInventoryByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}