using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Virus[] Children { get; set; }

        public Virus(double weight, int age, string name, string type, int childrenCount = 0)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new Virus[childrenCount];
        }

        public object Clone()
        {
            Virus clone = new Virus(this.Weight, this.Age, this.Name, this.Type, this.Children.Length);

            for (int i = 0; i < this.Children.Length; i++)
            {
                if(this.Children[i] != null)
                {
                    clone.Children[i] = (Virus)this.Children[i].Clone();
                }
            }
            return clone;
        }
    }
}
