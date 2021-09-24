using CosmosWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmosWebApp
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<ClothesWebModel>> GetItemsAsync(string query);
        Task AddItemAsync(ClothesWebModel clothesModel);
    }
}