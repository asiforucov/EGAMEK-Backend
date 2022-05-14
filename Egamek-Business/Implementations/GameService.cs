using Egamek_Business.Interfaces;
using Egamek_Business.ViewModels.GameViewModels;
using Egamek_Core;
using Egamek_Core.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Business.Implementations
{
    public class GameService:IGameService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public GameService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }

        public Task Create(GameCreateViewModel gameViewModel)
        {
            throw new NotImplementedException();
        }


        public async Task<Game> Get(int id)
        {
            return await _unitOfWork.productRepository
                .Get(p => p.Id == id && p.IsDeleted == false, "ProductCategory", "GenderCategory", "ProductBrand", "ProductImages");
        }

        public Task<List<Game>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, GameUpdateViewModel gameViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
