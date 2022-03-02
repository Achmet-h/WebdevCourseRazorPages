using System;
using System.Text.Json.Serialization;
using Exercises.Pages.Lesson1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Exercises.Pages.Lesson1
{
    public class Assignment5 : PageModel
    {
        public class MoodCounter {
            public int Happy { get; set; }
            public int Disappointed { get; set; }
            public int Angry { get; set; }
        }
        

        public MoodCounter moodCounter = new MoodCounter();
        //public string json = JsonConvert.SerializeObject(moodCounter);
        

        public void OnPost(string action="")
        {
            if (HttpContext.Request.Cookies.ContainsKey("count"))
            {
                string value=HttpContext.Request.Cookies["count"];
                moodCounter = JsonConvert.DeserializeObject<MoodCounter>(value);
            }
            
            
            if (action=="btnHappy")
            {
                //moodCounter.Happy = Convert.ToInt16(Request.Query.ContainsKey("happyCount"));
                moodCounter.Happy++;
            }

            else if (action=="btnDisappointed")
            {
                moodCounter.Disappointed++;
            }
            else if(action=="btnAngry")
            {
                moodCounter.Angry++;
            }
            else if (action=="btnDeleteCookie")
            {
               //reset cookies here
            }

            string json= JsonConvert.SerializeObject(moodCounter);
            HttpContext.Response.Cookies.Append("count",json);
        }
    }
}
