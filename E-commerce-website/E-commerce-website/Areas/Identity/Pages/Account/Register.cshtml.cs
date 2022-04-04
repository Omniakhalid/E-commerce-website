using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using E_commerce_website.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using E_commerce_website.Context;
using E_commerce_website.Models;

namespace E_commerce_website.Areas.Identity.Pages.Account
{
    
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<websiteUser> _signInManager;
        private readonly UserManager<websiteUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly OnlineshoppingContext _context;
        public RegisterModel(
            UserManager<websiteUser> userManager,
            SignInManager<websiteUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, OnlineshoppingContext context)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _logger = logger;
                _emailSender = emailSender;
                _context = context;

            }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        
        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [StringLength(50)]
            [Display(Name = "Name")]
            public string UserFirstName { get; set; }

            [Required]
            [StringLength(10)]
            [Display(Name = "City")]
            public string UserCity { get; set; }
            [Display(Name = "Phone")]
            public string UserPhone { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Address")]
            public string UserAddress { get; set; }

            public UserType type { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new websiteUser { UserName = Input.Email, Email = Input.Email };

                user.UserFirstName = Input.UserFirstName;
                user.UserCity = Input.UserCity;
                user.UserPhone = Input.UserPhone;
                user.UserAddress=Input.UserAddress;
                user.type = Input.type;
                
                
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        if (Input.type==UserType.Vendor)
                        {
                            _context.Add(new Vendor()
                            {
                                VendorName = Input.UserFirstName,
                                VendorAddress = Input.UserAddress,
                                VendorEmail = Input.Email,
                                VendorPhone = Input.UserPhone,
                                VendorCity = Input.UserCity,
                                VendorCountry = "EGYPT",
                                VendorPassword = Input.Password
                            }) ;
                            _context.SaveChanges();
                        }
                        else if (Input.type == UserType.User)
                        {
                            await _userManager.AddToRoleAsync(user, UserType.User.ToString());

                            var User = new User()
                            {
                                UserName = Input.UserFirstName,
                                UserEmail = Input.Email,
                                UserPhone = Input.UserPhone,
                                UserAddress = Input.UserAddress,
                                UserCity = Input.UserCity,
                                UserCountry = "EGYPT",
                                UserPassword = Input.Password
                            };
                            _context.Users.Add(User);
                            _context.SaveChanges();

                        }
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
