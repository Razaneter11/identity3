using identity3.Models.Registerview;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using identity3.Data;
using System.Threading.Tasks;
namespace identity3.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountsController(ApplicationDbContext context, UserManager<IdentityUser> userManager,SignInManager<IdentityUser>signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Register(Registerviewmodel model)
        {
            IdentityUser user = new IdentityUser()
            {
Email = model.Email,
UserName=model.Email,
PhoneNumber=model.Phone
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Login(Loginviewmodel model)

        {
            var result = await signInManager.PasswordSignInAsync(model.Password, model.Email, model.RememberMe,false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

    }
    }

