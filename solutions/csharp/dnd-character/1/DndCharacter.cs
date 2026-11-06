using System;
using System.Linq;

public class DndCharacter
{
    private static readonly Random random = new Random();

    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public DndCharacter()
    {
        Strength = Ability();
        Dexterity = Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom = Ability();
        Charisma = Ability();
        Hitpoints = 10 + Modifier(Constitution);
    }

    public static int Modifier(int score)
    {
        return (int)Math.Floor((score - 10) / 2.0);
    }

    public static int Ability()
    {
        int[] rolls = new int[4];

        for (int i = 0; i < rolls.Length; i++)
            rolls[i] = random.Next(1, 7);

        return rolls.Sum() - rolls.Min();
    }

    public static DndCharacter Generate()
    {
        return new DndCharacter();
    }
}