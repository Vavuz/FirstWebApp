using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string Message { get; set; }

        public ListModel(IConfiguration config)
        {
            this.config = config;
        } 
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}
