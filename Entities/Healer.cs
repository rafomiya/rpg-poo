using System;

public class Healer : Legend
{
    public int HealingPower;
    public Healer(string name, int hp, int damage, int level, int healingPower) : base(name, hp, damage, level)
    {
        this.HealingPower = healingPower;
    }

    public void Heal(Legend target)
    {
        target.Hp += this.HealingPower;

        Console.WriteLine($"{this.Name} healed {target.Name}!");
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Healing: {this.HealingPower}";
    }
}