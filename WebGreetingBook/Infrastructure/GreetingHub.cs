using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGreetingBook.Infrastructure
{
    public class GreetingHub : Hub
    {
        public async Task SendMessage(string user, string message, string to)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SayHello(string myId, string displayName)
        {

            await Clients.All.SendAsync("SayHello", myId);
        }
    }
}
