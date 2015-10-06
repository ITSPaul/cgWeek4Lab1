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
        List<Player> players = new List<Player>()
        { new Player {
            playerID = Guid.NewGuid(),
            FirstName ="First",
            SecondName ="Player",
            GamerTag = "player 1",
            UserName = "p1", XP = 400 },
            new Player {
            playerID = Guid.NewGuid(),
            FirstName ="Second",
            SecondName ="Player",
            GamerTag = "player 2",
            UserName = "p2", XP = 600 },
        };
        static List<Player> joined = new List<Player>();
        bool playing = false;

        public Player join(string username)
        {
            if (!playing)
            {
                Player p = players.FirstOrDefault(pl => pl.UserName == username);
                if (p != null && !joined.Contains(p)) // Valid player
                {
                    p.clientID = Context.ConnectionId;
                    joined.Add(p);
                    if (joined.Count() > 1)
                    {
                        Clients.All.play(joined); // Note clients must subscribe to this event
                        playing = true;
                    }
                    return p;
                }
                else return null;
            }
            else return null;
        }

        public void joinUp(string username)
        {
            if (!playing)
            {
                Player p = players.FirstOrDefault(pl => pl.UserName == username);
                if (p != null && joined.FirstOrDefault(pl => pl.UserName == username) == null) // Valid player
                {
                    p.clientID = Context.ConnectionId;
                    joined.Add(p);
                    Clients.Caller.joined(p);
                    if (joined.Count() > 1)
                    {
                        Clients.All.play(joined); // Note clients must subscribe to this event
                        playing = true;
                    }
                    
                }
                
            }
            
        }
    }
}