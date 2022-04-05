using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using E_commerce_website.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_commerce_website.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<websiteUser> _userManager;
        private readonly SignInManager<websiteUser> _signInManager;

        public IndexModel(
            UserManager<websiteUser> userManager,
            SignInManager<websiteUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
           


            [Required]
            [StringLength(50)]
            [Display(Name = "Name")]
            public string UserFirstName { get; set; }


            [Display(Name = "Phone")]
            public string UserPhone { get; set; }
            [Required]
            [StringLength(10)]
            [Display(Name = "City")]
            public string UserCity { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Address")]
            public string UserAddress { get; set; }
            [Display(Name = "Profile Pic")]
            public byte[] Userimage { get; set; }
        }

        private async Task LoadAsync(websiteUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                UserFirstName = user.UserFirstName,
                UserCity = user.UserCity,
                UserAddress = user.UserAddress,
                UserPhone = user.UserPhone,
                Userimage = user.Userimage,
                //PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = user.UserPhone;
            var name = user.UserFirstName;
            var city = user.UserCity;
            var address = user.UserAddress;
            


            if (name != Input.UserFirstName)
            {
                user.UserFirstName = Input.UserFirstName;
                await _userManager.UpdateAsync(user);
            }
            if (city != Input.UserCity)
            {
                user.UserCity = Input.UserCity;
                await _userManager.UpdateAsync(user);
            }

            if (address != Input.UserAddress)
            {
                user.UserAddress = Input.UserAddress;
                await _userManager.UpdateAsync(user);
            }
            if (Input.UserPhone != phoneNumber)
            {
                user.UserPhone = Input.UserPhone;
                await _userManager.UpdateAsync(user);
                //var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                //if (!setPhoneResult.Succeeded)
                //{
                //    StatusMessage = "Unexpected error when trying to set phone number.";
                //    return RedirectToPage();
                //}
            }
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files.FirstOrDefault();
                using (var datastream = new MemoryStream())
                {
                    await file.CopyToAsync(datastream);
                    user.Userimage = datastream.ToArray();
                }
                await _userManager.UpdateAsync(user);
            }
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}



//var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
//            //if (Input.PhoneNumber != phoneNumber)
//            //{
//            //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
//            //    if (!setPhoneResult.Succeeded)
//            //    {
//            //        StatusMessage = "Unexpected error when trying to set phone number.";
//            //        return RedirectToPage();
//            //    }
//            //}

//            await _signInManager.RefreshSignInAsync(user);
//            StatusMessage = "Your profile has been updated";
//            return RedirectToPage();
//        }
//    }
//}
