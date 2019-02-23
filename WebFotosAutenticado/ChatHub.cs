using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebFotosAutenticado
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void AddMessage(string userId, string message)
        {
            Clients.All.onMessage(userId, message);
        }
    }
}