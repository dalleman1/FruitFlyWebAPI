using FruitFly.Repository.Interfaces;
using FruitFly.Repository.Models;
using FruitFly.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Service.Services
{
    public class ReferencepointService : CrudService<Referencepoint>, IReferencepointService
    {
        private readonly IReferencepointRepository _ReferenceRepository;
        public ReferencepointService(IReferencepointRepository ReferencepointRepository) : base(ReferencepointRepository)
        {
            _ReferenceRepository = ReferencepointRepository;
        }

        public async Task<bool> DoesReferencepointExist(int referencepointId)
        {
            return await _ReferenceRepository.DoesReferencepointExist(referencepointId);
        }
    }
}
