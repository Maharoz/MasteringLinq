using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection
{
    public class Zip
    {
        public void zipMethod()
        {
            // An int array with 7 elements.
            IEnumerable<int> numbers =
            [
                1,
                2,
                3,
                4,
                5,
                6,
                7
            ];
            // A char array with 6 elements.
            IEnumerable<char> letters =
            [
                'A',
                'B',
                'C',
                'D',
                'E',
                'F'
            ];
            IEnumerable<string> emoji =
            [
                "🤓",
                "🔥",
                "🎉",
                "👀",
                "⭐",
                "💜",
                "✔",
                "💯"
            ];
            foreach ((int number,char letter) in numbers.Zip(letters))
            {
                Console.WriteLine($"Number: {number} zipped with letter: '{letter}'");
            }

            foreach ((int number, char letter, string em) in numbers.Zip(letters, emoji))
            {
                Console.WriteLine(
                    $"Number: {number} is zipped with letter: '{letter}' and emoji: {em}");
            }
            // This code produces the following output:
            //     Number: 1 zipped with letter: 'A'
            //     Number: 2 zipped with letter: 'B'
            //     Number: 3 zipped with letter: 'C'
            //     Number: 4 zipped with letter: 'D'
            //     Number: 5 zipped with letter: 'E'
            //     Number: 6 zipped with letter: 'F'

            // This code produces the following output:
            //     Number: 1 is zipped with letter: 'A' and emoji: 🤓
            //     Number: 2 is zipped with letter: 'B' and emoji: 🔥
            //     Number: 3 is zipped with letter: 'C' and emoji: 🎉
            //     Number: 4 is zipped with letter: 'D' and emoji: 👀
            //     Number: 5 is zipped with letter: 'E' and emoji: ⭐
            //     Number: 6 is zipped with letter: 'F' and emoji: 💜
        }



    }
}
