using System;
using System.Collections.Generic;

namespace INECVotersRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = {"Ade", "Bisi", "Bisi", "Kate", "Tayo", "Peter", "Pius"};
            SortedList<string, int> multipleVoters = new SortedList<string, int>();
            List<int> Voters = new List <int>();
            foreach (string i in name)
            {
                int count = 0;
                if ( multipleVoters.ContainsKey(i))
                {
                    continue;
                }
                foreach (var j in name)
                {
                    if (j == i) 
                    {
                        count++;
                    }

                }

                multipleVoters.Add(i, count);
            }
            foreach (var i in multipleVoters)
            {
                Console.WriteLine(i.Key+","+ i.Value);
            }

        }
    }
}
