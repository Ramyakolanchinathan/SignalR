using Microsoft.AspNetCore.SignalR;

namespace SignalRHubs.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string connectionId, string user,  string message)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveMessage",user,message);
        }
    }
}
