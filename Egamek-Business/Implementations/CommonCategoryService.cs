using Egamek_Business.Interfaces;
using Egamek_Business.ViewModels.CommonCategoryViewModels;
using Egamek_Core;
using Egamek_Core.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Business.Implementations
{
    public class CommonCategoryService : ICommonCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public CommonCategoryService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public Task Create(CommonCategoryCreateViewModel commonCategoryCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<CommonCategory> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommonCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CommonCategoryUpdateViewModel commonCategoryUpdateViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
