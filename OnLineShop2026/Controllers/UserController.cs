using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;


namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRep)
        {
            this.userRepository = userRep;
        }

        public IActionResult Index()
        {
            var users = userRepository.GetAll();
            return View(users);
        }

        public IActionResult Details(Guid id)
        {
            var user = userRepository.TryGetById(id);
            if (user == null) return NotFound();
            return View(user);
        }
    }
}
