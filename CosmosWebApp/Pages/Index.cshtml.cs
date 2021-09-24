using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CosmosWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        //public IActionResult OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    var client = new RestClient($"https://localhost:44393/api/SendEmail/SendEmail/?{Mail.FromEmail}{Mail.ToEmail}");
        //    client.Timeout = -1;
        //    var request = new RestRequest(Method.POST);
        //    request.AddHeader("ApiKey", "secret1234");
        //    IRestResponse response = client.Execute(request);

        //    if (response.StatusCode.ToString() == "OK")
        //    {
        //        return RedirectToPage("/Index");
        //    }
        //    return Page();
        //}
    }
}
