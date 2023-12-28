using Inveon.Models;
using Inveon.Models.DTOs;

namespace Inveon.Services.Inform.CommunicationMethods.Interfaces
{
    public interface ICommunicationMethod
    {
        void SendMessage(CheckoutHeaderWithProducts checkoutHeader);
    }
}
