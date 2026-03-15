using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy = new Character();

        public EnemyBuilder Reset() { _enemy = new Character(); return this; }
        public EnemyBuilder SetName(string name) { _enemy.Name = name; return this; }
        public EnemyBuilder SetPhysical(double h, string b) { _enemy.Height = h; _enemy.Build = b; return this; }
        public EnemyBuilder SetLook(string h, string e) { _enemy.HairColor = h; _enemy.EyeColor = e; return this; }
        public EnemyBuilder AddItem(string i) { _enemy.Inventory.Add(i); return this; }

        public EnemyBuilder AddEvilDeed(string deed)
        {
            _enemy.Deeds.Add($"[Зло] {deed}");
            return this;
        }

        public Character Build() => _enemy;

        // Явна реалізація для інтерфейсу
        ICharacterBuilder ICharacterBuilder.Reset() => Reset();
        ICharacterBuilder ICharacterBuilder.SetName(string n) => SetName(n);
        ICharacterBuilder ICharacterBuilder.SetPhysical(double h, string b) => SetPhysical(h, b);
        ICharacterBuilder ICharacterBuilder.SetLook(string h, string e) => SetLook(h, e);
        ICharacterBuilder ICharacterBuilder.AddItem(string i) => AddItem(i);
    }
}
