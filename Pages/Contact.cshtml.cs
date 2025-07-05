using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net;

namespace PortfolioSite.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] public string? Name { get; set; }
        [BindProperty] public string? Email { get; set; }
        [BindProperty] public string? Message { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            try
            {
                //var smtpClient = new SmtpClient("smtp.gmail.com")
                //{
                //    Port = 587,
                //    Credentials = new NetworkCredential("ryandemboski7@gmail.com", "SOnic12!!"),
                //    EnableSsl = true,
                //};

                //var mailMessage = new MailMessage
                //{
                //    From = new MailAddress("ryandemboski7@gmail.com"),
                //    Subject = "New Contact Form Message",
                //    Body = $"Name: {Name}\nEmail: {Email}\nMessage:\n{Message}",
                //    IsBodyHtml = false,
                //};

                //if (!string.IsNullOrEmpty(Email))
                //{
                //    mailMessage.ReplyToList.Add(Email);
                //}

                //mailMessage.To.Add("ryan@demboski.com");

                //smtpClient.Send(mailMessage);

                return RedirectToPage("Contact");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while sending the message.");
                return Page();
            }

            return RedirectToPage("ContactConfirmation");
        }
    }
}