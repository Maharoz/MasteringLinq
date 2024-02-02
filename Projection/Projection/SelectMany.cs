using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
    public class SelectMany
    {
        public void ManySelection()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];

            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;
            foreach(string s  in query)
            {
                Console.WriteLine(s);
            }
        }

        /* This code produces the following output:

            an
            apple
            a
            day
            the
            quick
            brown
            fox
        */ 
    }
}
