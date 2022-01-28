using System;

public class Legend
{
    public string Name;
    public int Hp;
    public int Damage;
    public int Level;
    public Legend(string name, int hp, int damage, int level)
    {
        Console.WriteLine($"{name} has spawned!");

        this.Name = name;
        this.Hp = hp;
        this.Damage = damage;
        this.Level = level;
    }
    public Legend() { }

    public override string ToString()
    {
        return $"{this.Name} - HP: {this.Hp}";
    }

    public virtual void Attack(Legend target)
    {
        target.Hp -= this.Damage;

        Console.WriteLine($"{this.Name} attacked {target.Name}!");
    }
}