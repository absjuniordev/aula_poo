namespace Orirentação_Objetos.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, string HP, string MP )
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;

        }

        public Hero(){

        }

        public string Name; 
        public int Level;
        public string HeroType;
        public string HP;
        public string MP;

        public override string ToString()
        {
            return ($"{this.Name} {this.Level} {this.HeroType}");
        }

        public virtual string Attack(){
            return ($"{this.Name} Atacou com sua espada");
            }
        public virtual string Attack(int Bonus){
            if(Bonus >5)
            {
                return ($"{this.Name} Lançou magia super de {Bonus}");
            }else{
                return ($"{this.Name} Lançou magia fraca {Bonus}");
            }
            
        }    
    }
}