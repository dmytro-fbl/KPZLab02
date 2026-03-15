namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Virus v3 = new Virus(0.1, 1, "альфа", "Грип");

            Virus v2 = new Virus(0.5, 3, "бета", "Грип", 1);
            v2.Children[0] = v3;
            Virus v1 = new Virus(1.0, 10, "гама", "Грип", 1);
            v1.Children[0] = v2;

            Virus cloneOfParent = (Virus)v1.Clone();

            Console.WriteLine($"Оригінальний батько: {v1.Name}");
            Console.WriteLine($"Клонований батько: {cloneOfParent.Name}");

            v1.Children[0].Children[0].Name = "Супер-Мутант";

            Console.WriteLine("\nПісля мутації оригіналу:");
            Console.WriteLine($"альфа в оригіналі: {v1.Children[0].Children[0].Name}");
            Console.WriteLine($"альфа у клоні: {cloneOfParent.Children[0].Children[0].Name}");
        }
    }
}
