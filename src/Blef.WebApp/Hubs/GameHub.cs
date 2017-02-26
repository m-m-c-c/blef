using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Blef.WebApp.Hubs
{
    public class GameHub : Hub
    {
        public void Register(string name)
        {
            Clients.All.newClientConnected(name);
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }
}