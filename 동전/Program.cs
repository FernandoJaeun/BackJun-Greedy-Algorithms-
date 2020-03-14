using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 동전
{
    class Program
    {
        static int[] Coins(int N)
        {
            int[] coins = new int[N];
            coins[0] = 1;
            for (int i = 1; i < N; i++)
            {
                if (i % 2 == 1)
                    coins[i] = coins[i - 1] * 5;

                if (i % 2 == 0)
                    coins[i] = coins[i - 1] * 2;

                WriteLine(coins[i]);
            }
            return coins;
        }
        static void Calculator(int[] vs, int K)
        {
            int count = 0;
            for (int i = vs.Length-1; i > 0 ; i--)
            {
                if (K >= vs[i])
                {
                    K -= vs[i];
                    count++;
                    i++;
                }
                if (K == 0)
                    break;
            }
            WriteLine($"깍은 횟수 : {count}");
        }
        static void Main(string[] args)
        {
            int N, K;
            Write("N : ");
            N = Convert.ToInt32(ReadLine());
            Write("K  : ");
            K = Convert.ToInt32(ReadLine());

            int[] GetCoins = Coins(N);
            Calculator(GetCoins, K);

        }
    }
}
