﻿using System;

namespace MonoGameClient
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Game1 game = new Game1();
                game.Run();
   //         System.Threading.Thread t2 = 
			//new System.Threading.Thread(() =>
   //            {
   //                Game1 game1 = new Game1();
   //                game1.Run();
   //            });
   //         t2.Start();
        }
    }
#endif
}
