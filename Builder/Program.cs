namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director();

            HeroBuilder heroBuilder = new HeroBuilder();
            director.ConstructPaladin(heroBuilder);
            heroBuilder.AddGoodDeed("Врятував кошеня з драконової печери");
            Character myHero = heroBuilder.Build();

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Character myEnemy = enemyBuilder
                .SetName("Азгалор")
                .SetPhysical(180, "Згорблений")
                .SetLook("Лисий", "Жовті")
                .AddItem("Отруєний кинджал")
                .AddEvilDeed("Викрав усі цукерки у королівстві") 
                .Build();

            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            myHero.ShowInfo();
            myEnemy.ShowInfo();

            Console.ReadKey();
        }
    }
}
