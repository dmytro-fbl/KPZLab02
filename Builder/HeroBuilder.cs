using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero = new Character();

        public HeroBuilder Reset() { _hero = new Character(); return this; }
        public HeroBuilder SetName(string name) { _hero.Name = name; return this; }
        public HeroBuilder SetPhysical(double h, string b) { _hero.Height = h; _hero.Build = b; return this; }
        public HeroBuilder SetLook(string h, string e) { _hero.HairColor = h; _hero.EyeColor = e; return this; }
        public HeroBuilder AddItem(string i) { _hero.Inventory.Add(i); return this; }

        public HeroBuilder AddGoodDeed(string deed)
        {
            _hero.Deeds.Add($"[Добро] {deed}");
            return this;
        }

        public Character Build() => _hero;

        ICharacterBuilder ICharacterBuilder.Reset() => Reset();
        ICharacterBuilder ICharacterBuilder.SetName(string n) => SetName(n);
        ICharacterBuilder ICharacterBuilder.SetPhysical(double h, string b) => SetPhysical(h, b);
        ICharacterBuilder ICharacterBuilder.SetLook(string h, string e) => SetLook(h, e);
        ICharacterBuilder ICharacterBuilder.AddItem(string i) => AddItem(i);
    }
}
