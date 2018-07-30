namespace ConsoleApp1
{
    using System;
    using TestUnity;
    using Unity;
    using Unity.Lifetime;
    using Unity.NLog;

    class Program
    {
        private static IUnityContainer _container;

        static void Main(string[] args)
        {
            var ext = new NLogExtension()
            {
                GetName = (t, n) => t.FullName
            };

            _container = new UnityContainer();
            _container.AddExtension(ext).
            RegisterType<ITestComponent, Baranina>("baranina").
            RegisterType<ITestComponent, Cielecina>("cielecina").
            RegisterType<ITestConstructorInjection, TestConstructorInjection>();


            var _instance = _container.Resolve<Class1>();

            _instance.GetName += GetName;
            _instance.GetName += GetName2;
            _instance.GetName += GetName3;
            _instance.GetName += GetName4;

            _instance.TestLogging();

            ITestComponent baranina = _container.Resolve<Baranina>();
            baranina.GetName();

            var bar2 = _container.Resolve<ITestComponent>("baranina");

            ITestComponent cielecina = _container.Resolve<Cielecina>();
            cielecina.GetName();

            Console.ReadLine();
        }

        static void GetName()
        {
            Console.WriteLine("this is main");
        }

        static void GetName2()
        {
            Console.WriteLine("this is main 2");
        }

        static void GetName3()
        {
            Console.WriteLine("this is main 3");
        }

        static void GetName4()
        {
            Console.WriteLine("this is main 4!!");
        }
    }
}
