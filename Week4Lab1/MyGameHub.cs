using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Week4lab1GameClassLib;

namespace Week4Lab1
{
    public class MyGameHub : Hub
    {
        List<Player> players = new 
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}