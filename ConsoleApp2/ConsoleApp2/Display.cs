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
                int val = player.status[i]/5;
                string[] graph = new string[8];
                for (int j = 0; j < val; j++)
                {
                    graph[i] += "■";
                }
                for (int k = 0; k < 20-val; k++) 
                {
                    graph[i] += "  ";
                }
                    
                
                if (i == 6 || i == 7)
                {
                    Console.WriteLine(statusStringArray[i] + ":" + player.status[i]  + "%");
                    continue;
                }
                Console.WriteLine(statusStringArray[i] + ":" + graph[i]+"("+player.status[i]+")");
            }

        }

        public static bool LoopCreateCharacter(bool createdPlayerFlg)
        {
            String answer = null;
            bool macthedAnswer = false;
            while (!macthedAnswer)
            {
                
                Console.WriteLine("このキャラクターを作成しますか？");
                Console.Write("y/n :");
                answer = Console.ReadLine();
                if (answer.Equals("y") || answer.Equals("n"))
                {
                    break;
                }
            }
            if (answer.Equals("y"))
            {
                
                return true;
            }
            return false;
        }
    }
}
