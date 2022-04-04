using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Collections.Generic;

namespace E_commerce_website.Controllers
{
    public class StripeController : Controller
    {
        public IActionResult Index(decimal TotalPrice)
        {
            return View(TotalPrice);
        }


        public IActionResult Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = 500,
                Description = "Sample Charge",
                Currency = "usd",
                Customer = customer.Id
            });

            return View();
        }
        //Previous actions



    }
}
