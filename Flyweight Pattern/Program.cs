using Flyweight_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        CharacterFactory factory = new CharacterFactory();
        var character = factory.GetCharacter("Krosh", Types.Warrior, "images\\warrior.jpg");
        character.Experience = 10;
        character.Level = 10;
        character.Display();
        var character2 = factory.GetCharacter("Gol", Types.Druid, "images\\druid.jpg");
        character2.Experience = 10;
        character2.Level = 10;
        character2.Display();
        var character3 = factory.GetCharacter("Krosh", Types.Warrior, "images\\warrior.jpg");
        character3.Experience = 15;
        character3.Level = 15;
        character3.Display();
        Console.WriteLine(ReferenceEquals(character,character3));
    }
}