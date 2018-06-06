using System;
using System.Collections.Generic;

namespace HackathonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountFriend = int.Parse(Console.ReadLine());
            List<string> idFriendFriend = new List<string>();
            List<string[]> strFriend = new List<string[]>();
            for (int i = 0; i < amountFriend; i++)
                strFriend.Add(Console.ReadLine().Split());
            for(int i =0; i < amountFriend; i++)
                for (int j = 0; j < strFriend[i].Length; j++)
                {
                    if (j == 1) continue;
                    if (!idFriendFriend.Contains(strFriend[i][j]))
                        idFriendFriend.Add(strFriend[i][j]);
                }
            Console.WriteLine(idFriendFriend.Count - amountFriend);
            Console.ReadKey();
        }
    }
}
