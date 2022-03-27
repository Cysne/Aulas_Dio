namespace POO.Entities
{
  public class Ninja : Hero
  {
    public Ninja(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;

    }

    public override string Attack()
    {
      return this.Name + " Atacou com shuriken ";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " Lançou um ataque com shurikens e kunai " + Bonus;
      }
      else
      {
        return this.Name + " Lançou uma shuriken " + Bonus;
      }

    }

  }
}