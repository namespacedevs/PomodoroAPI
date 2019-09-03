//using System.Web.Http;
//using AutoMapper;
//using SimpleInjector;
//using SimpleInjector.Integration.WebApi;
//using SimpleInjector.Lifestyles;
//
//namespace PomodoroCommon
//{
//    public class SimpleInjectorInitializer
//    {
//        public static void Initialize(HttpConfiguration config)
//        {
//            var container = new Container();
//            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
//            InitializeContainer(container);
//            container.RegisterWebApiControllers(config);
//            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
//            container.Verify();
//        }
//
//        private static void InitializeContainer(Container container)
//        {
//            container.Register<IMapper>();
//            container.Register<IScheduleRepository, ScheduleRepository>(Lifestyle.Scoped);
//            container.Register<ITimeAmountRepository, TimesRepository>(Lifestyle.Scoped);
//        }
//    }
//}

