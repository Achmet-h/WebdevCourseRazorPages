using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public double num1 { get; set; }

        public double num2 { get; set; }

        //[BindProperty(SupportsGet = true, Name = "result")]
        public double Result { get; set; }
        [BindProperty(SupportsGet = true)] public string Action { get; set; }

        public void OnGet([FromQuery] double result)
        {
            Result = result;
        }

        public void OnPostAddBtn([FromForm] double input, [FromForm] double hiddenInput)
        {
            num1 = input;
            num2 = hiddenInput;
            Result = input + hiddenInput;
        }

        public void OnPostSubBtn([FromForm] double input, [FromForm] double hiddenInput)
        {
            num1 = input;
            num2 = hiddenInput;
            Result = input - hiddenInput;
        }
        public void OnPostMulBtn([FromForm] double input, [FromForm] double hiddenInput)
        {
            num1 = input;
            num2 = hiddenInput;
            Result = input * hiddenInput;
        }
        public void OnPostDivBtn([FromForm] double input, [FromForm] double hiddenInput)
        {
            num1 = input;
            num2 = hiddenInput;
            Result = input / hiddenInput;
        }

    }
}

/*
          public IActionResult OnPostAddBtn([FromForm] int input, [FromForm] int hiddenInput)
          {
              num1 = input;
              num2 = hiddenInput;
              Result = num1 + num2;
              return Page();
          }
  
          public IActionResult OnPostSubBtn(int input, int hiddenInput)
          {
              num1 = input;
              num2 = hiddenInput;
              Result = num1 - num2;   
              return Page();
          }
          */
     
    
    

