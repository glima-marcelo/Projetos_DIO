using System;

namespace RPG_POO.src.Entities
{
    public abstract class BasicMold
    {
        public BasicMold(string Name, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.LifePoints = LifePoints;
            this.MagicPoints = MagicPoints;
        }
        
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int LifePoints { get; set; }
        public int MagicPoints { get; set; }

        public override string ToString()
        {
            return  "My name is: "+ this.Name + "\n"
                +   "Level: " + this.Level + "\n"
                +   "Hero type: " + this.HeroType + "\n"
                +   "Life points: " + this.LifePoints + "\n"
                +   "Magic points: " + this.MagicPoints + "\n";
        }

        public virtual string Attack()
        {
            Random force = new Random();
            int atackForce = this.Level + force.Next(1, 20);
            return this.Name + " atacou com a espada e deu " + atackForce + " de dano";
        }
    }
}