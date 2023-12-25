
using AnimalClasses.enums;

namespace AnimalClasses.abstract_classes;

[Comment("Abstract class for creating animals")]
abstract class Animal
{
    public string? Country { get; set; }
    public bool HideFromOtherAnimals { get; set; }
    public string? Name { get; set; }
    private eClassificationAnimal Classification { get; set; }

    // constructors
    protected Animal(string country, bool hideFromOtherAnimals, string name, eClassificationAnimal classification)
    {
        Country = country;
        HideFromOtherAnimals = hideFromOtherAnimals;
        Name = name;
        Classification = classification;

    }

    protected Animal()
    {
        Country = "";
        HideFromOtherAnimals = false;
        Name = "";
        Classification = eClassificationAnimal.Omnivores;
    }

    // deconstructor
    public void Deconstruct(out string country, out bool hideFromOtherAnimals, out string name,
        out eClassificationAnimal classification)
    {
        country = Country;
        hideFromOtherAnimals = HideFromOtherAnimals;
        name = Name;
        classification = Classification;
    }

    public eClassificationAnimal GetClassificationAnimal
    {
        get { return Classification; }
    }

    // abstract methods
    public abstract eFavoriteFood GetFavoriteFood();
    public abstract void SayHello();

}
