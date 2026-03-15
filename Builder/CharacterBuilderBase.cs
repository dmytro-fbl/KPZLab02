using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CharacterBuilderBase<T> : ICharacterBuilder where T : CharacterBuilderBase<T>
    {
        protected Character _character = new Character();

        public T Reset() { _character = new Character(); return (T)this; }
        public T SetName(string name) { _character.Name = name; return (T)this; }
        public T SetPhysical(double h, string b) { _character.Height = h; _character.Build = b; return (T)this; }
        public T SetLook(string h, string e) { _character.HairColor = h; _character.EyeColor = e; return (T)this; }
        public T AddItem(string i) { _character.Inventory.Add(i); return (T)this; }

        ICharacterBuilder ICharacterBuilder.Reset() => Reset();
        ICharacterBuilder ICharacterBuilder.SetName(string n) => SetName(n);
        ICharacterBuilder ICharacterBuilder.SetPhysical(double h, string b) => SetPhysical(h, b);
        ICharacterBuilder ICharacterBuilder.SetLook(string h, string e) => SetLook(h, e);
        ICharacterBuilder ICharacterBuilder.AddItem(string i) => AddItem(i);

        public Character Build() => _character;
    }
}
