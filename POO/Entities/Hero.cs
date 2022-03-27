namespace POO.Entities
{
  public class Hero
  {

    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }
    public Hero()
    {
      Name = string.Empty;
      HeroType = string.Empty;
    }

    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }


    public override string ToString()
    {
      return this.Name + "" + this.Level + "" + this.HeroType;
    }

    public virtual string Attack()
    {
      return this.Name + "Atacou com a sua espada";
    }



  }
}