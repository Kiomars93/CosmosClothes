using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmosWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ICosmosDbService _cosmosDbService;
        public CreateModel(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [BindProperty]
        public ClothesWebModel Clothes { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            Clothes.Id = Guid.NewGuid().ToString();
            await _cosmosDbService.AddItemAsync(Clothes);

            return Redirect("/Index");
        }
    }
}
