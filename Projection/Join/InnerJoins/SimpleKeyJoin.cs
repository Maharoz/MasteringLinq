using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join.InnerJoins
{
    public class SimpleKeyJoin
    {

        public void KeyJoin()
        {
            Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            Person terry = new("Terry", "Adams");
            Person charlotte = new("Charlotte", "Weiss");
            Person arlene = new("Arlene", "Huff");
            Person rui = new("Rui", "Raposo");

            List<Person> people = [magnus, terry, charlotte, arlene, rui];

            List<Pet> pets =
            [
                new(Name: "Barley", Owner: terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", rui),
                new("Daisy", magnus),
            ];

            var query = from person in people
                        join pet in pets on person equals pet.Owner
                        select new
                        {
                            OwnerName = person.FirstName,
                            PetName = pet.Name
                        };

            var result = "";
            foreach (var ownerAndPet in query)
            {
                result += $"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}\r\n";
            }
            Console.Write(result);

            /* Output:
                 "Daisy" is owned by Magnus
                 "Barley" is owned by Terry
                 "Boots" is owned by Terry
                 "Whiskers" is owned by Charlotte
                 "Blue Moon" is owned by Rui
            */



            //Simillar Results Using Method Syntax
            var methodQuery =
                people.Join(pets,
                     person => person,
                     pet => pet.Owner,
                     (person, pet) =>
                         new { OwnerName = person.FirstName, PetName = pet.Name });
        }
    }
}
