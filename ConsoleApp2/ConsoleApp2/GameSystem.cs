using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    public class GameSystem 
    {

        //ハッシュ値をステータスに変換する
        public int[] ConvertHashToStatus(string[] hashChar)
        {
            int[] status = new int[8];
            //ハッシュ値をステータスに変換
            for (int i = 1; i <= status.Length; i++)
            {
                for (int j = 1; j <= status.Length; j++)
                {
                    //ハッシュ値を10進数に変換
                    int hashCharNum = Convert.ToInt32(hashChar[i * j - 1],16);

                    //防御率と命中率の調整
                    if (i == 7 || i == 8) 
                    {
                        status[i-1] += (hashCharNum / 5) +1;
                        continue;
                    }

                    status[i - 1] += hashCharNum;
                    
                }
            }
            //命中率調整(90~100程度にする)
            status[6] = 105 - status[6];
            if (status[6] > 100)
            {
                status[6] = 100;
            }
            return status;
        }

        //ハッシュ値を生成する
        public  String HashGanerator(string inputString)
        {
            string hashValue = GetHashedTextString(inputString);
            return hashValue;
        }

        // 文字列のハッシュ値（SHA256）を計算・取得する
        static string GetHashedTextString(string inputString)
        {
            // パスワードをUTF-8エンコードでバイト配列として取り出す
            byte[] byteValues = Encoding.UTF8.GetBytes(inputString);


            // SHA256のハッシュ値を計算する
            SHA256 crypto256 = new SHA256CryptoServiceProvider();
            byte[] hash256Value = crypto256.ComputeHash(byteValues);

            // SHA256の計算結果をUTF8で文字列として取り出す
            StringBuilder hashedText = new StringBuilder();
            for (int i = 0; i < hash256Value.Length; i++)
            {
                // 16進の数値を文字列として取り出す
                hashedText.AppendFormat("{0:X2}", hash256Value[i]);
            }
            return hashedText.ToString();
        }

        

    }
}
