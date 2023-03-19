using Microsoft.AspNetCore.Mvc;

namespace Variables.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Параметр x та y ініціалізуватимуться автоматично.
        // Докладніше про роботу даного механізму ви дізнаєтеся в уроці, присвяченому прив'язці моделі. 
       
       
    }
}