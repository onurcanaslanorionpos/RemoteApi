using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteApi
{
    public class SappHub : Hub
    {
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }

        public override Task OnConnectedAsync()
        {
            System.Console.WriteLine("Yeni bir bağlantı: " + Context.ConnectionId);
            Clients.All.SendAsync("YeniBaglanti", "Yeni bir giriş algılandı.", Context.ConnectionId);
            ConnectedUser.connections.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }


        public override Task OnDisconnectedAsync(System.Exception exception)
        {
            System.Console.WriteLine("Kapatılan bağlantı: " + Context.ConnectionId);
            Clients.All.SendAsync("KapatilanBaglanti", "Bağlantı kapatıldı.", Context.ConnectionId);
            ConnectedUser.connections.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

        public void SendToWinForm(string eventName, object data)
        {
            Clients.All.SendAsync(eventName, data);
        }
    }
    public static class ConnectedUser
    {
        public static List<string> connections = new List<string>();
    }
}
