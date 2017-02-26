using System;
using Microsoft.AspNet.SignalR.Client;

namespace Blef.ConsoleClient
{
    public class ServerConnector
    {
        readonly HubConnection _connection;
        readonly IHubProxy _proxy;

        public ServerConnector()
        {
            _connection = new HubConnection("http://localhost:2196/" + "signalr");

            _proxy = _connection.CreateHubProxy("GameHub");

            _proxy.On<string>("newClientConnected", name =>
            {
                Console.WriteLine("Client connected: " + name);
            }
            );

            var t = _connection.Start();
            t.Wait();
        }

        public void Register()
        {
            _proxy.Invoke("Register", "Janusz").Wait();
        }
    }
}