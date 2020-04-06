using FruitFly.Repository.Configurations;
using FruitFly.Repository.Interfaces;
using FruitFly.Repository.Models;
using System.Threading.Tasks;

namespace FruitFly.Repository.Repositories
{
    public class ReferencepointRepository : CrudRepository<Referencepoint>, IReferencepointRepository
    {
        private readonly FruitFlyContext _fruitFlyContext;
        public ReferencepointRepository(FruitFlyContext fruitFlyContext) : base(fruitFlyContext)
        {
            _fruitFlyContext = fruitFlyContext;
        }
        /// <summary>
        /// Checks if referencepoint exist by checking ID
        /// </summary>
        /// <param name="referencepointId">ID of the referencepoint</param>
        /// <returns>Returns true if object exists</returns>
        public async Task<bool> DoesReferencepointExist(int referencepointId)
        {
            return (await base.GetByIdAsync(referencepointId) != null);
        }
    }
}
