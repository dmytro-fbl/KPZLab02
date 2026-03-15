namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Створення BalaxyFactory");
            CreateDevice(new BalaxyFactory());
            Console.WriteLine();

            Console.WriteLine("Створення IProneFactory");
            CreateDevice(new IproneFactory());
            Console.WriteLine();

        }

        private static void CreateDevice(ICompanyFactory companyFactory)
        {
            var smartphone = companyFactory.CreateSmartphone();
            var netbook = companyFactory.CreateNetbook();
            var laptop = companyFactory.CreateLaptop();

            Console.WriteLine("Сворені Device");
            Console.WriteLine("-" + smartphone.Name);
            Console.WriteLine("-" + netbook.Name);
            Console.WriteLine("-" + laptop.Name);
        }
    }
}
