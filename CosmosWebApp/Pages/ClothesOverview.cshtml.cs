using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmosWebApp.Pages
{
    public class ClothesOverviewModel : PageModel
    {
        private readonly ICosmosDbService _cosmosDbService;
        public ClothesOverviewModel(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [BindProperty]
        public List<ClothesWebModel> ClothesList { get; set; } = new List<ClothesWebModel>();
        [BindProperty]
        public ClothesWebModel Clothes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var result = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");

            foreach (var clothItem in result)
            {
                ClothesList.Add(clothItem);
            }

            return Page();
        }
    }
}
