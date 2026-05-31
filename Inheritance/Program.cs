using System;

namespace Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO Be sure to follow best practice when creating your classes

        //// Create a class Animal
        //// give this class 4 members that all Animals have in common
        ////
        ////
        //// Create a class Bird
        //// give this class 4 members that are specific to Bird
        //// Set this class to inherit from your Animal Class
        ////
        //// Create a class Reptile
        //// give this class 4 members that are specific to Reptile
        //// Set this class to inherit from your Animal Class


        
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
        swallow.WingspanInches = 13;
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

        
        Console.WriteLine($"You have two options {swampPuppy.Species} or {swallow.Species}");
        Console.WriteLine("Please select whether you'd like to display information on the \n1. reptilian subject \nor the \n2. avian subject.");
        var displayWhich = Console.ReadKey();
        switch (displayWhich.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                Reptile.DisplayReptileInfo(swampPuppy);
                break;
            
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                
                break;
                
            default:
                Console.WriteLine("You've chosen poorly. Try again.");
                break;
                
        }
        
    }
}