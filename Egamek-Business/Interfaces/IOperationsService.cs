using Egamek_Business.ViewModels.OperationViewModels;
using Egamek_Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Business.Interfaces
{
    public interface IOperationsService
    {
        Task<List<Operations>> GetAllAsync();
        Task<Operations> Get(int id);
        Task Create(OperationsCreateViewModel operationsCreateViewModel);
        Task Update(int id, OperationsUpdateViewModel operationsUpdateViewModel);
        Task Remove(int id);
    }
}
