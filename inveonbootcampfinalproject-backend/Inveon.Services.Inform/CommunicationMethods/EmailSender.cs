using Inveon.Services.Inform.CommunicationMethods.Interfaces;
using Inveon.Models;
using Inveon.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Inveon.Services.Inform.CommunicationMethods
{
    public class EmailSender : ICommunicationMethod
    {
        private SmtpClient _mailClient;

        public EmailSender() 
        {
            // https://github.com/haravich/fake-smtp-server FAKE SMTP SERVER (does not support ssl)
            _mailClient = new SmtpClient("localhost")
            {
                Port = 1025,
                Credentials = new NetworkCredential("user", "pass"),
                EnableSsl = false
            };
        }

        public void SendMessage(CheckoutHeaderWithProducts checkoutHeader)
        {
            List<string> productStrings = new List<string>();

            foreach (var cartDetails in checkoutHeader.CartDetailsList)
            {
                Product product = checkoutHeader.Products.First(p => p.ProductId == cartDetails.ProductId);
                productStrings.Add($"{cartDetails.Count} x {product.Name} ({product.Price} {product.CurrencyType} each)\n");
            }

            _mailClient.Send(
                "cagla@inveon.com",
                checkoutHeader.Email,
                "Your Inveon Purchase Is Approved",

                $"Hi {checkoutHeader.FirstName} {checkoutHeader.LastName}! \n\n"
                + $"Your order summary:\n"
                + String.Join("", productStrings)
                + $"\nTotal price for the order: {checkoutHeader.OrderTotal} TL\n\n"
                + "Thank you for your purchase!\n"
                + "cagla @ Inveon"
                );
        }
    }
}
