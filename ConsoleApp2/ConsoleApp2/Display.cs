using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Display
    {
        public static void ShowStatus(string[] statusStringArray ,Player player)
        {
            
            for (int i = 0; i < statusStringArray.Length; i++)
            {
                if (i == 6 || i == 7)
                {
                    Console.WriteLine(statusStringArray[i] + ":" + player.status[i] / 5 + "%");
                    continue;
                }
                Console.WriteLine(statusStringArray[i] + ":" + player.status[i]);
            }
            Console.ReadLine();

        }
    }
}
