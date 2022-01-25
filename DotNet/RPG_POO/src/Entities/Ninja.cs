using System;

namespace RPG_POO.src.Entities
{
    public class Ninja : BasicMold
    {
        public Ninja(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.Level = 3;
            this.HeroType = HeroType;
            this.LifePoints = 70;
            this.MagicPoints = 30;
        } 
    }
}