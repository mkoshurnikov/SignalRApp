using Microsoft.AspNetCore.SignalR;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SignalRApp
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.Others.SendAsync("Send", message, userName);
            await Clients.Caller.SendAsync("Notify", "You: " + message);
        }
        public async Task Login(string userName)
        {
            await Clients.Others.SendAsync("Login", "User - " + "<<" + userName + ">>" + " here!");
            await Clients.Caller.SendAsync("Notify", "Chat starts");
        }
    }
}