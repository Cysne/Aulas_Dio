namespace POO.Entities
{
  public class Villain : Hero
  {
    public Villain(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;

    }

    public override string Attack()
    {
      return this.Name + " Atacou com Magia de Fogo ";
    }
    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " Lançou um Poderoso ataque de Fogo " + Bonus;
      }
      else
      {
        return this.Name + " Lançou um ataque fraco de Raios " + Bonus;
      }

    }



  }
}