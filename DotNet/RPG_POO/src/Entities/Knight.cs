using System;

namespace RPG_POO.src.Entities
{
    public class Knight : BasicMold
    {
        public Knight(string Name, string HeroType) : base(Name, HeroType)
        {
            this.Name = Name;
            this.Level = 2;
            this.HeroType = HeroType;
            this.LifePoints = 50;
            this.MagicPoints = 10;
        }
    }
}