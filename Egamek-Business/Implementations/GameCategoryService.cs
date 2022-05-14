using Egamek_Business.Interfaces;
using Egamek_Business.ViewModels.GameCategoryViewModels;
using Egamek_Core;
using Egamek_Core.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Business.Implementations
{
    public class GameCategoryService : IGameCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public GameCategoryService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public Task Create(GameCategoryCreateViewModel gameCategoryCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<GameCategory> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GameCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, GameCategoryUpdateViewModel gameCategoryUpdateViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
