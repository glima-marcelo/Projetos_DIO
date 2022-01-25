using System;

namespace RPG_POO.src.Entities
{
    public class Wizard : BasicMold
    {
        public Wizard(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.Level = 10;
            this.HeroType = HeroType;
            this.LifePoints = 80;
            this.MagicPoints = 80;
        }

        public override string Attack()
        {
            Random force = new Random();
            int atackForce = this.Level + force.Next(1, 15);
            return this.Name + " atacou com seu cajado e deu " + atackForce + " de dano";
        }

        public string Attack(int bonus)
        {
            Random force = new Random();
            int atackForce = this.Level + force.Next(1, 15) + bonus;
            
            return this.Name + " atacou com bônus e seu cajado e deu " + atackForce + " de dano";
            
            // if (Bonus > 6)
            // {
            //     return this.Name + " lançou magia super efetiva com bonus de " + Bonus;
            // }
            // else
            // {
            //     return this.Name + " lançou magia com força fraca com bonus de " + Bonus;
            // }
        }
    }
}