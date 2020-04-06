using FruitFly.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Service.Interfaces
{
    public interface IReferencepointService : ICrudService<Referencepoint>
    {
        Task<bool> DoesReferencepointExist(int referencepoint);
    }
}
