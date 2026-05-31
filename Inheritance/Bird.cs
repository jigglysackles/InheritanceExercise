namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
    }

    public Bird(bool canFly, int wingspanInches, double unladenSpeed, int migratoryDistance)
    {
        CanFly = canFly;
        WingspanInches = wingspanInches;
        UnladenSpeedMpS = unladenSpeed;
        MigratoryDistanceKm = migratoryDistance;
    }
    
    public bool CanFly { get; set; }
    public int WingspanInches { get; set; }
    public double UnladenSpeedMpS { get; set; } //11 m/s
    public int MigratoryDistanceKm { get; set; }
}