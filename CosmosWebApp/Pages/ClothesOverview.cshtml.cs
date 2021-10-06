using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CosmosWebApp.Pages
{
    public class ClothesOverviewModel : PageModel
    {
        private readonly ICosmosDbService _cosmosDbService;
        private readonly ILogger<ClothesOverviewModel> _logger;
        public ClothesOverviewModel(ICosmosDbService cosmosDbService, ILogger<ClothesOverviewModel> logger)
        {
            _cosmosDbService = cosmosDbService;
            _logger = logger;
        }

        [BindProperty]
        public List<ClothesWebModel> ClothesList { get; set; } = new List<ClothesWebModel>();
        [BindProperty]
        public ClothesWebModel Clothes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var result = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");
            if (result == null)
            {
                _logger.LogWarning("No items has been found!");
            }
            else
            {
                foreach (var clothItem in result)
                {
                    ClothesList.Add(clothItem);
                }
                _logger.LogInformation("Items has been added");
            }
            return Page();
        }
    }
}
