using PathfinderModelling.Model;
using PathfinderModelling.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfinderModelling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ranger ranger = new Ranger();
            //Character character = new Character();

            //character.Classes.Add(ranger.Class);

            //var blightwarden = ranger.Class.Archetypes.Find(a => a.Name == "Blightwarden");

            ////character.AddArchetype(ranger.Class.Archetypes.Find(a => a.Name == "Battle Scout"));
            ////character.AddArchetype(ranger.Class.Archetypes.Find(a => a.Name == "Beast Master"));
            //character.Classes.First().AddArchetype(blightwarden);

            //PrintAbilities(character);

            ////character.RemoveArchetype(blightwarden);

            ////PrintAbilities(character);

            //Console.ReadLine();
        }

        static void PrintAbilities(Character character)
        {
            Console.Clear();
            for (int i = 1; i <= 20; i++)
                Console.WriteLine(string.Join(", ", character.Classes.First().ClassAbilities.Where(a => a.Level == i).Select(a => a.Name)));
        }
    }
}
