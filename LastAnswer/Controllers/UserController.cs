using Microsoft.AspNetCore.Mvc;

namespace LastAnswer.Controllers
{
    public class UserController : Controller
    {
        private readonly ApiService _apiService;

        public UserController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _apiService.GetDatas();
            return View(users);
        }
    }
}
