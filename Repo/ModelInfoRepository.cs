using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;
using ProductsApi.Interfaces;
using ProductsApi.Models;

namespace ProductsApi.Repo
{
    public class ModelInfoRepository : IModelInfoRepository
    {

        private readonly AppDbContext _dbContext;

        public ModelInfoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ModelInfo> Create(ModelInfo modelInfo)
        {
            _dbContext.ModelInfos.Add(modelInfo);
            await _dbContext.SaveChangesAsync();
            return modelInfo;
        }

        public Task<ModelInfo> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ModelInfo>> GetAllAsync()
        {
            return await _dbContext.ModelInfos.ToListAsync();
        }

        public async Task<ModelInfo> GetByIdAsync(int id)
        {
            var modelInfo = await _dbContext.ModelInfos.FindAsync(id);
            if (modelInfo == null) return new ModelInfo();
            return modelInfo;
        }
    }
}