using System;

public class Sourcerer : Legend
{
    public Sourcerer(string name, int hp, int damage, int level) : base(name, hp, damage, level)
    { }
    public override void Attack(Legend target)
    {
        target.Hp -= this.Damage;

        Console.WriteLine($"{this.Name} attacked {target.Name} with sourcery!");
    }
}