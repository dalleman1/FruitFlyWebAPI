using FruitFly.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Repository.Interfaces
{
    public interface IReferencepointRepository : ICrudRepository<Referencepoint>
    {
        Task<bool> DoesReferencepointExist(int referencepointId);
    }
}
