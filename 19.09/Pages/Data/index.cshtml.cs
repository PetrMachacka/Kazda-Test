using _19._09.InputModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _19._09.Pages.Data
{
    public class indexModel : PageModel
    {
        public string Text { get; set; } = "Mlčím";
        [BindProperty]
        public RegistraceIM RegistraceData { get; set; } = new RegistraceIM();
        public void OnGet()
        {

        }
        public void OnGetText(string txt, int? kolik)
        {
            Text = txt + kolik.ToString();
        }

        //page handler = cisla
        public void OnGetCisla(int cislo)
        {
            Text = $"Číslo je {cislo}";
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine();
                return RedirectToPage("/");
            }
            return Page();
        }
    }
}
