using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        [BindProperty(SupportsGet = true, Name = "scoreHome")] 
        public int ScoreHome { get; set; } = 0;
        [BindProperty(SupportsGet = true, Name = "scoreAway")] 
        public int ScoreAway { get; set; } = 0;
         
        public void OnGet()
        {
            if (Request.Query.ContainsKey("incrementHome"))
            {
                ScoreHome = Convert.ToInt32(Request.Query["incrementHome"].First());
                ScoreHome++;
            }

            if (Request.Query.ContainsKey("decrementHome"))
            {
                ScoreHome = Convert.ToInt32(Request.Query["decrementHome"].First());
                if (ScoreHome==0)
                {
                    ScoreHome = 0;
                }
                else
                {
                    ScoreHome--;
                }
            
            }
            if (Request.Query.ContainsKey("incrementAway"))
            {
                ScoreAway = Convert.ToInt32(Request.Query["incrementAway"].First());
                ScoreAway++;
            } 
            if (Request.Query.ContainsKey("decrementAway"))
            {
                ScoreAway = Convert.ToInt32(Request.Query["decrementAway"].First());
                if (ScoreAway==0)
                {
                    ScoreHome = 0;
                }
                else
                {
                    ScoreAway--;
                }
            }

            if (Request.Query.ContainsKey("Reset"))
            {
                ScoreAway = 0;
                ScoreHome = 0;
            }
        

        }
    }
}
