namespace Orirentação_Objetos.src.Entities
{
    public class Kinight : Hero
    {
        public Kinight(string Name, int Level, string HeroType, string HP, string MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
    }
}