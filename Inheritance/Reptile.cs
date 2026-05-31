using System;

namespace Inheritance;

public class Reptile : Animal
{
    
    
    public string ScaleSizeSML { get; set; }
    public bool Aquatic { get; set; }
    public int Legs { get; set; }
    public int HeartChambers { get; set; }

    public Reptile()
    {
    }
    
    public Reptile(string scaleSizeSml, bool aquatic, int legs, int heartChambers)
    {
        ScaleSizeSML = scaleSizeSml;
        Aquatic = aquatic;
        Legs = legs;
        HeartChambers = heartChambers;
    }

    private static Random randomNum = new Random();
    private static int _descriptorRandom = randomNum.Next(1, 4);

    public static string ReptileDescriptor()
    {
        switch (_descriptorRandom)
        {
            case 1:
                return "stupid";
            case 2:
                return "lovely";
            case 3:
                return "incredible";
            
        }
        return "interesting";
    } 
    
    
    public static void DisplayReptileInfo(Reptile reptile)
    {
       var description = ReptileDescriptor();
        Console.WriteLine($"The reptile {reptile.Name}, is a {description} animal!");
        Console.WriteLine($"This particular {reptile.Name} has {reptile.ScaleSizeSML} scales in relation to other reptiles.");
        
        if (reptile.HeartChambers == 3)
        {
         Console.WriteLine($"Like most reptiles, the {reptile.Name} has {reptile.HeartChambers} heart chambers.");   
        }
        else
        {
            Console.WriteLine($"Unlike other reptiles which usually have three heart chambers, the {reptile.Name} has {reptile.HeartChambers} heart chambers.");
        }

        if (!reptile.Aquatic)
        {
            Console.WriteLine($"This particular species of reptile is not inclined to spend time int he water.");
        }
        else
        {
            Console.WriteLine($"This reptile enjoys the water and will spend time in or around it frequently.");    
        }

        switch (reptile.Legs)
        {
            case 0:
                Console.WriteLine($"This is a slippy snake since it has no legs. If it should have had legs...it's now an honorary snake.");
                return;
            case 1:
                Console.WriteLine($"That little guy? I wouldn't worry about that little guy. Weird that he's there though...just...dangling...");
                return;
            case 2:
                Console.WriteLine($"This reptile has two legs and is therefore bipedal master species material.");
                return;
            case 3:
                Console.WriteLine($"I think one of the legs is missing...or maybe extra?");
                return;
            case 4:
                Console.WriteLine($"This reptile has four legs. Four on the floor was the manual gearbox arrangement for my second car.");
                return;
            
        }
        
    }
}