using System;
using System.Collections.Generic;
using blockbuster.Controllers;
using blockbuster.Models;

namespace blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
    ____  __    ____  ________ __ ____  __  _______________________ 
   / __ )/ /   / __ \/ ____/ //_// __ )/ / / / ___/_  __/ ____/ __ \
  / __  / /   / / / / /   / ,<  / __  / / / /\__ \ / / / __/ / /_/ /
 / /_/ / /___/ /_/ / /___/ /| |/ /_/ / /_/ /___/ // / / /___/ _, _/ 
/_____/_____/\____/\____/_/ |_/_____/\____//____//_/ /_____/_/ |_|  
                                                                    
            ");

            StoreController sc = new StoreController();
            sc.Run();
        }
    }
}
