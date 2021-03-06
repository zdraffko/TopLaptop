﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TopLaptop.Data.Identity;
using TopLaptop.Web.ViewModels;

namespace TopLaptop.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var appUser = new ApplicationUser
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    UserName = viewModel.Username,
                    Email = viewModel.Email,
                };

                var identityResult = await userManager.CreateAsync(appUser, viewModel.Password);

                if (identityResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(appUser, viewModel.RegistrationType);
                    await signInManager.SignInAsync(appUser, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await signInManager.PasswordSignInAsync(
                        viewModel.Username,
                        viewModel.Password,
                        viewModel.IsRemembered,
                        false
                    );

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("failedLogInAttemt", "Invalid username or password");
            }

            return View(viewModel);
        }

        public async Task<IActionResult> LogOut()
        {
            if (HttpContext.Request.Method == HttpMethod.Post.Method)
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> CheckIfEmailIsInUse(string email)
        {
            var appUser = await userManager.FindByEmailAsync(email);
            return appUser == null ? Json(true) : Json($"The Email '{email}' is already in use");
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> CheckIfUsernameIsInUse(string username)
        {
            var appUser = await userManager.FindByNameAsync(username);
            return appUser == null ? Json(true) : Json($"The Username '{username}' is already in use");
        }
    }
}