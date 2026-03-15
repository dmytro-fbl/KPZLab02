using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"--- Персонаж: {Name} ---");
            Console.WriteLine($"Зріст: {Height} см, Статура: {Build}");
            Console.WriteLine($"Волосся: {HairColor}, Очі: {EyeColor}");
            Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");
            Console.WriteLine($"Справи: {string.Join(", ", Deeds)}");
            Console.WriteLine();
        }
    }
}
