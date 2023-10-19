using Microsoft.AspNetCore.Mvc;

namespace Batinas_Iulia_Lab1.Controllers
{
    public class DemoLabController : Controller
    {
        //
        // GET: /welcome/
        public string Index()
        {
            return "Welcome!";
        }

        //
        // GET: /greetingsOfTheUser/
        public string greetingsOfTheUser()
        {
            return "Greetings, user!";
        }


     
        private string anotherGreeting(string u, int nr)
        {
            return u + ", you are here for the " + nr.ToString() + "st time!";
        }

        public string callAnotherGreeting() 
        {
            return anotherGreeting("User", 1);
        }
    }
}
