namespace Inheritance;

public class Animal
{
    public Animal()
    {
    }

    public Animal(string name, string boneType, string species, string bloodedness, string phylogenicClass)
    {
        Name = name;
        BoneType = boneType;
        Species = species;
        Bloodedness = bloodedness;
        PhylogenicClass = phylogenicClass;
    }
    
    public string Name { get; set; }
    public string BoneType { get; set; }
    public string Species { get; set; }
    public string Bloodedness { get; set; }
    public string PhylogenicClass { get; set; }
}