using ProductsApi.Models;

namespace ProductsApi.Interfaces
{
    public interface IModelInfoRepository
    {
        Task<IEnumerable<ModelInfo>> GetAllAsync();
        Task<ModelInfo> GetByIdAsync(int id);
        Task<ModelInfo> Create(ModelInfo modelInfo);
        Task<ModelInfo> Delete(int id);
    }
}