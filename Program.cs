using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static string[] Ranks => new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        static void Main(string[] args)
        {
            Console.WriteLine(Test("D3C3C10D10S3"));
            Console.WriteLine(Test("DASAD10CAHA"));
            Console.WriteLine(Test("S10HJDJCJSJ"));
            Console.WriteLine(Test("S10HAD10DAC10"));
            Console.WriteLine(Test("HJDJC3SJS3"));
            Console.WriteLine(Test("S3S4H3D3DA"));
            Console.WriteLine(Test("S2HADKCKSK"));
            Console.WriteLine(Test("SASJDACJS10"));
            Console.WriteLine(Test("S2S10H10HKD2"));
            Console.WriteLine(Test("CKH10D10H3HJ"));
            Console.WriteLine(Test("C3D3S10SKS2"));
            Console.WriteLine(Test("S3SJDAC10SQ"));
            Console.WriteLine(Test("C3C9SAS10D2"));
            Console.ReadLine();
        }

        static string Test(string target)
        {
            // [手札:判定結果]の形式で返却
            // * 見やすいように手札は左詰め
            return $"{target.PadRight(2*5+5)}:{Judge(target)}";
        }

        // 判定
        static string Judge(string target)
        {
            var rankNums = Ranks.Select(rank => Regex.Matches(target, rank).Count).ToArray();

            if (rankNums.Any(i => i == 4))
                return "4K";
            else if (rankNums.Any(i => i == 3) && rankNums.Any(i => i == 2))
                return "FH";
            else if (rankNums.Any(i => i == 3))
                return "3K";
            else if (rankNums.Count(i => i == 2) == 2)
                return "2P";
            else if (rankNums.Any(i => i == 2))
                return "1P";
            else
                return "--";
        }
    }
}
