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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
            _logger.LogDebug(1, "NLog injected into ClothesOverviewModel");
>>>>>>> 182fb193b8b924df1e233daf32963c43a39edd29
>>>>>>> b78c9acfaba09e110a98544cd56a6599859d6b84
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
<<<<<<< HEAD
            }
            else
            {
                foreach (var clothItem in result)
                {
                    ClothesList.Add(clothItem);
                }
                _logger.LogInformation("Items has been added");
            }
=======
            }
            else
            {
                foreach (var clothItem in result)
                {
                    ClothesList.Add(clothItem);
                }
                _logger.LogInformation("Items has been added");
            }
<<<<<<< HEAD
=======
            _logger.LogInformation("Added to the list!");
>>>>>>> 182fb193b8b924df1e233daf32963c43a39edd29
>>>>>>> b78c9acfaba09e110a98544cd56a6599859d6b84
            return Page();
        }
    }
}
