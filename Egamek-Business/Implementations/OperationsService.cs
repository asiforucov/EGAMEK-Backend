using Egamek_Business.Interfaces;
using Egamek_Business.ViewModels.OperationViewModels;
using Egamek_Core;
using Egamek_Core.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Business.Implementations
{
    public class OperationsService : IOperationsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public OperationsService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public Task Create(OperationsCreateViewModel operationsCreateViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<Operations> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Operations>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, OperationsUpdateViewModel operationsUpdateViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
