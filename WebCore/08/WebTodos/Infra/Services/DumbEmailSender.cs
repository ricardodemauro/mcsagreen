using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTodos.Infra.Services
{
    public class DumbEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //codigo de mandar email

            System.Diagnostics.Debug.WriteLine($"Mandando email para {email} com assunto {subject} com conteudo {htmlMessage}");

            return Task.CompletedTask;
        }
    }
}
