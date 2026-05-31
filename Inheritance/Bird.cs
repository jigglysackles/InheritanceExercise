using System;

namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
    }

    public Bird(bool canFly, string plummage, double unladenSpeed, int migratoryDistance)
    {
        CanFly = canFly;
        Plummage = plummage;
        UnladenSpeedMpS = unladenSpeed;
        MigratoryDistanceKm = migratoryDistance;
    }

    public bool CanFly { get; set; }
    public string Plummage { get; set; }
    public double UnladenSpeedMpS { get; set; } //11 m/s
    public int MigratoryDistanceKm { get; set; }

    public static void DisplayBirdInfo(Bird bird)
    {
        Console.WriteLine($"Good morning! This here is a fine specimen of a bird. It is in fact a {bird.Name}.");

        if (bird.CanFly)
            Console.WriteLine("This particular one can indeed fly.");
        else
            Console.WriteLine("This one would fly if it wasn't nailed to it's perch.");

        Console.WriteLine($"Lovely bird eh? {bird.Plummage} plummage!");

        Console.WriteLine(
            $"Did you know that they have a migratory distance of {bird.MigratoryDistanceKm} kilometers? \nSounds impressive to me. But then anything sounds impressive since it's further than I can fly.");

        Console.WriteLine(
            $"Now for the biggest secret. The speed of an unladen {bird.Name} is {bird.UnladenSpeedMpS} m/s.\nJust uh...don't ask me for the speed of an unladen african swallow, I haven't looked that one up yet.");
    }
}