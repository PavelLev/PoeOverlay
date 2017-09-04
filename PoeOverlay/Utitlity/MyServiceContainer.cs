using LightInject;

namespace PoeOverlay.Utitlity
{
    public static class MyServiceContainer
    {
        public static ServiceContainer Instance { get; }

        static MyServiceContainer()
        {
            Instance = new ServiceContainer();


        }

        public static TService GetInstance<TService>()
        {
            return Instance.GetInstance<TService>();
        }
    }
}