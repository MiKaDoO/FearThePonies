﻿using Microsoft.AspNetCore.SignalR;

namespace FearServer
{
    public class NotificationHub : Hub
    {
        public void Send(string message)
        {
            Clients.Others.broadcastMessage(message);
        }
    }
}