using System;
using System.Collections.Generic;

namespace debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Kacper", "Arek", "Staszek", "Ala", "Joe", "Carol" };
            var partyFriends = GetPartyFriends(friends, -1);

            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
            foreach (var name in friends)
            {
                Console.WriteLine("-{0}-", name);
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if(list == null)
                throw new ArgumentNullException("list","List was null");

            var copyList = new List<string>(list);
            var partyFriends = new List<string>();


            if(count > copyList.Count)
               count = copyList.Count;

            if(count < 1)
                throw new ArgumentOutOfRangeException("count", "Count too little");

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(copyList);
                partyFriends.Add(currentFriend);
                copyList.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            var shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
