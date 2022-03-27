
using POO.Entities;

namespace POO.Entities
{
  public class Wizard : Hero
  {

    public Wizard(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;

    }



    public override string Attack()
    {
      return this.Name + " Atacou com com magia ";
    }
    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " Lançou magia com bonus de ataque" + Bonus;
      }
      else
      {
        return this.Name + " Lançou uma Magia com força fraca" + Bonus;
      }

    }
  }
}