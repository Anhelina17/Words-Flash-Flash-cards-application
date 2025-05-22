using Fiszki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace Fiszki.Pages
{
    public class ListsModel : PageModel
    {
        public void OnGet()
        {
            var lista = new List();
            var slowka = lista.Words;

            foreach (var word in slowka)
            {
                
            }
        }
    }
}
