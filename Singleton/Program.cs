namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.Instance;
            auth1.ShowMessage();

            Authenticator auth2 = Authenticator.Instance;

            if (ReferenceEquals(auth1, auth2))
            {
                Console.WriteLine("Перевірка успішна: 2 об'єкти однаковий екземпляр");
            }
            else
            {
                Console.WriteLine("Помилка: різні екземпляри");
            }

            Console.WriteLine($"Auth1 Hash: {auth1.GetHashCode()}");
            Console.WriteLine($"Auth2 Hash: {auth2.GetHashCode()}");
        }
    }
}
