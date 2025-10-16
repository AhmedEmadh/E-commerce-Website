using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace E_commerce_Website.Models
{
    public interface IConfirmationEmailSender : IEmailSender
    {
        Task SendConfirmationEmailAsync(string email);
    }
}
