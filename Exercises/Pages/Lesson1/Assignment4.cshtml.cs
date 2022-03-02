using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment4 : PageModel
    {
        public void OnGet([FromRoute]string action)
        {
            if (action == "")
            {
                Count = 0;
            }
            else if (action == "increment")
            {
                Count++;
            }
            else if (action == "decrement")
            {
                Count--;
            }
        }


        [BindProperty(SupportsGet = true)] public int Count { get; set; }
    }
}
