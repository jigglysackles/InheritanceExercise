using System;

namespace Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        //originally wanted to make all parameters for the objects user assigned.
        //But I need to finish the assignment. So they will be manually assigned here.
        var swallow = new Bird();
        swallow.BoneType = "hollow";
        swallow.Bloodedness = "warm";
        swallow.Species = "Hirundo Rustica";
        swallow.PhylogenicClass = "Aves";
        swallow.CanFly = true;
        swallow.MigratoryDistanceKm = 10000;
        swallow.UnladenSpeedMpS = 11;
        swallow.Plummage = "Beautiful";
        swallow.Name = "European Swallow";

        var swampPuppy = new Reptile();
        swampPuppy.BoneType = "solid";
        swampPuppy.Species = "Alligator Mississippiensis";
        swampPuppy.Bloodedness = "Cold";
        swampPuppy.PhylogenicClass = "Reptilia";
        swampPuppy.Name = "Swamp Puppy";
        swampPuppy.Aquatic = true;
        swampPuppy.Legs = 4;
        swampPuppy.ScaleSizeSML = "Large";
        swampPuppy.HeartChambers = 4;

        Console.Clear();
        var loop = true;
        do
        {
            //Basic selection prompt

            Console.WriteLine($"\nYou have two options {swampPuppy.Species} or {swallow.Species}");
            Console.WriteLine(
                "Please select the number of the one you'd like to display information on \n1. reptilian subject \n2. avian subject");
            var displayWhich = Console.ReadKey();
            switch (displayWhich.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Reptile.DisplayReptileInfo(swampPuppy);
                    loop = false;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Bird.DisplayBirdInfo(swallow);
                    loop = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("You've chosen poorly. Try again.");
                    break;
            }
        } while (loop);
    }
}