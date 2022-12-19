using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;
using System;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginDto { ReturnUrl=returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user==null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }
                if (!await _userManager.IsEmailConfirmedAsync(user)) // mail onaylı olup olmadığına bakar
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Hesabınız onaylanmamış, lütfen mailinize gelen onay linkine tıklayarak hesabınızı onaylayınız.", "warning");
                    
                    return View(loginDto);
                    //ÖDEV: Eğer hesap onaylı değilse burada kullanıcıya "Onay linki gönder" şeklinde bir buton gözüksün.
                    //Ve bu butona basıldığında tekrar onay maili yollansın.
                }
                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı!");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        //[ValidateAntiForgeryToken]//İlgili cookienin sadece ait olduğu tarayıcı tarafından gönderilmesi halinde geçerli olmasını sağlar.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email
                };
                var result = await _userManager.CreateAsync(user, registerDto.Password);
                if (result.Succeeded)
                {
                    //Generate token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = tokenCode
                    });

                    //Mailin gönderilme, onaylanma vs
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                        $"<br>" +
                        $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p>" +
                        $"<a href='https://localhost:7215{url}'>Onay linki</a>");
                    TempData["Message"] = Jobs.CreateMessage("Bilgi","Lütfen mail hesabınızı kontrol edin. Gelen linki tıklayarak, hesabınızı onaylayın.","warning");
                    return RedirectToAction("Login","Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz");
            return View(registerDto);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId==null || token == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Geçersiz token ya da mail adresi.", "danger");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Mailiniz onaylandı.", "success");
                    return View();
                }
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "İşleminiz gerçekleşmedi! Lütfen mail hesabınızı kontrol edin. Gelen linki tıklayarak, hesabınızı onaylayın.", "danger");
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Lütfen mail adresinizi eksiksiz bir şekilde giriniz.", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle kayıtlı bir mail adresi bulunamadı. Lütfen kontrol ederek, yeniden deneyiniz.", "danger");
            }
            var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = tokenCode
            });
            await _emailSender.SendEmailAsync(
                email,
                "ShoppingApp Şifre Sıfırlama Linki",
                $"Lütfen parolanızı yenilemek için <a href='https://localhost:7215{url}'>tıklayınız</a>"
                );
            TempData["Message"] = Jobs.CreateMessage("Bilgi", "Şifre sıfırlama linkiniz mail adresinize gönderilmiştir. Lütfen mailiniz kontrol edin.", "info");
            return RedirectToAction("Login","Account");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId==null || token==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun oluştu! Lütfen daha sonra yeniden deneyiniz.", "danger");
                return RedirectToAction("Index", "Home");
            }
            var resetPasswordDto = new ResetPasswordDto
            {
                Token = token
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordDto);
            }
            var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
            if (user == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle bir kullanıcı bulunamadı", "danger");
                return View(resetPasswordDto);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = Jobs.CreateMessage("Başarılı", "Parolanız başarıyla değiştirilmiştir. Giriş yapabilirsiniz.", "success");
                return RedirectToAction("Login", "Account");
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir hata oluştu. Tekrar deneyi", "success");
            return Redirect("~/");
        }

        [HttpGet]
        public IActionResult SendConfirmEmail(){
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendConfirmEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Lütfen mail adresinizi eksiksiz bir şekilde giriniz.", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle kayıtlı bir mail adresi bulunamadı. Lütfen kontrol ederek, yeniden deneyiniz.", "danger");
                return View();
            }
            var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = tokenCode
                });
            await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                        $"<br>" +
                        $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p>" +
                        $"<a href='https://localhost:7215{url}'>Onay linki</a>");
            TempData["Message"] = Jobs.CreateMessage("Bilgi","Mailiniz gönderildi. Gelen linki tıklayarak, hesabınızı onaylayın.","warning");
            return RedirectToAction("Login","Account");
        }

    }
}