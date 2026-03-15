using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder Reset();
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetPhysical(double height, string build);
        ICharacterBuilder SetLook(string hair, string eyes);
        ICharacterBuilder AddItem(string item);
        Character Build();
    }
}
