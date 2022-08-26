using Microsoft.AspNetCore.Mvc;
using ProductsApi.Interfaces;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelInfoController : ControllerBase
    {
        private readonly IModelInfoRepository _repo;

        public ModelInfoController(IModelInfoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelInfo>>> GettAllAsync()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<ModelInfo>> GetById(int id)
        {
            var modelInfo = await _repo.GetByIdAsync(id);
            return Ok(modelInfo);
        }

        [HttpPost]
        public async Task<ActionResult<ModelInfo>> Post(ModelInfo modelInfo)
        {
            var CreatedmodelInfo = await _repo.Create(modelInfo);
            return CreatedAtAction(nameof(GetById), new { id = CreatedmodelInfo.ModelInfoId }, CreatedmodelInfo);
        }
    }
}