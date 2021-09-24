using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosWebApp.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;

namespace CosmosWebApp
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }


        public async Task<IEnumerable<ClothesWebModel>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<ClothesWebModel>(new QueryDefinition(queryString));
            List<ClothesWebModel> results = new List<ClothesWebModel>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task AddItemAsync(ClothesWebModel clothesModel)
        {
            await this._container.CreateItemAsync<ClothesWebModel>(clothesModel, new PartitionKey(clothesModel.Category));
        }
    }
}
