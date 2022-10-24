using Microsoft.AspNetCore.Mvc;

namespace ProjetoAllAccess.Controllers
{
    public class VestibularController : Controller
    {
        public IActionResult IndexVestibular()
        {
            return View();
        }
        public IActionResult ExerciciosVestibular()
        {
            return View();
        }

    }
}
