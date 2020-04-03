using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Web.Models;
using Web.Models.Configuration;

/*
For the controller to send off an email, it requires sending a POST request with a body that has
    {
        EmailAddress: emailAddressToSendTo,
        Subject: subject,
        Message: message
    }
In order to use the gmail smtp service, the account that is sending off the email needs to have allowed 
less secure app access. The email account details associated with the controller can be found in the 
appsettings.json file. To allow less secure app access on the account, log in to the gmail email account, 
click the account button from the top right menu, select the security tab, scroll down, and click the 
"Turn on access (not recommended)" button under the "Less secure app access" section.
*/

namespace Web.Controllers.Api
{
    [Microsoft.AspNetCore.Cors.EnableCors("PlanVotePolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IOptions<EmailConfiguration> emailConfiguration;

        public EmailController(IOptions<EmailConfiguration> emailConfiguration)
        {
            this.emailConfiguration = emailConfiguration;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Email email)
        {
            bool success = SendEmail(email.EmailAddress, email.Subject, email.Message);

            if (success)
            {
                return Ok();
            }

            return BadRequest("Failed to send email");
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public bool SendEmail(string emailAddress, string subject, string message)
        {
            MailMessage mm = new MailMessage
            {
                From = new MailAddress("test@gmail.com", emailConfiguration.Value.NetworkCredName),
                Subject = subject,
                Body = message,
                IsBodyHtml = false
            };

            mm.To.Add(new MailAddress(emailAddress));
            
            NetworkCredential networkCred = new NetworkCredential
            {
                UserName = emailConfiguration.Value.NetworkCredUserName,
                Password = emailConfiguration.Value.NetworkCredPassword,
            };

            SmtpClient smtp = new SmtpClient
            {
                Host = emailConfiguration.Value.SmtpHost,
                EnableSsl = emailConfiguration.Value.SmtpEnableSSL,
                UseDefaultCredentials = emailConfiguration.Value.SmptUseDefaultCredentials,
                Credentials = networkCred,
                Port = emailConfiguration.Value.SmtpPort
            };

            try
            {
                smtp.Send(mm);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}