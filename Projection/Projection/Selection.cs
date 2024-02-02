using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
    public  class Selection
    {
        public void Select()
        {
            List<string> words = ["an", "apple", "a", "day"];

            var query = from word in words
                        select word.Substring(0, 1);

            foreach ( string s in query )
            {
                Console.WriteLine(s);
            }
            /* This code produces the following output:

                a
                a
                a
                d
            */
        }

    }
}
