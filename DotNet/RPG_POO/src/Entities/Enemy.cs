using System;

namespace RPG_POO.src.Entities
{
    public class Enemy : BasicMold
    {
        public Enemy(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.Level = 1;
            this.HeroType = HeroType;
            this.LifePoints = 80;
            this.MagicPoints = 0;
        }
        public override string Attack()
        {
            Random force = new Random();
            int atackForce = this.Level + force.Next(1, 20);
            return this.Name + " atacou e deu " + atackForce + " de dano";
        }
    }
}