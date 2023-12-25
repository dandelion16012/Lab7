using AnimalClasses.abstract_classes;

using AnimalClasses.enums;

namespace AnimalClasses.classes;

[Comment("Class for cow")]
class Cow : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Plants;
    }

    public override void SayHello()
    {
        Console.WriteLine("MUUU");
    }
}
