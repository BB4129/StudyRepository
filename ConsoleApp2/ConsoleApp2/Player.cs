using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Player
    {
        //H,A,B,C,D,S,Block,Acc
        private int[] stat = new int[8];
        //ステータスの初期値を決めるハッシュ値
        private string hashString;


        public int[] status
        {
            set { stat = value; }
            get { return stat; }
        }

        public string hash
        {
            set { this.hashString = value; }
            get { return hashString; }
        }
    }
}
