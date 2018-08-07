using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacBMW {
    class Program {

        private static IContainer Container { get; set; }

        static void Main(string[] args) {

            //AutofacConfig.ConfigureContainer();
            AutoFacConfigWithXML.ConfigureContainer();

            GetCallFromAllAutoServices();
            
        }

        public static class AutofacConfig {
            public static void ConfigureContainer() {
                var builder = new ContainerBuilder();

                builder.RegisterType<BMWAutoService>().SingleInstance();
                builder.RegisterType<FordAutoService>().SingleInstance();
                builder.RegisterType<HondaAutoService>().SingleInstance();

                Container = builder.Build();
            }
        }

        public static class AutoFacConfigWithXML {
            public static void ConfigureContainer() {
                var config = new ConfigurationBuilder();
                config.AddXmlFile("autofac.xml");

                var module = new ConfigurationModule(config.Build());
                var builder = new ContainerBuilder();
                builder.RegisterModule(module);

                Container = builder.Build();
            }
        }



        public static void GetCallFromAllAutoServices() {

            using (var scope = Container.BeginLifetimeScope()) {

                var bmw = scope.Resolve<BMWAutoService>();
                var ford = scope.Resolve<FordAutoService>();
                var honda = scope.Resolve<HondaAutoService>();

                AutoServiceCallerImp serviceCaller = new AutoServiceCallerImp(bmw, ford, honda);
                serviceCaller.CallAutoService(); 
            }
        }

        public interface IAutoService {
            void GetService();
        }
        

        public interface IAutoServiceCaller {
            void CallAutoService();
        }

        public class AutoServiceCallerImp : IAutoServiceCaller {

            private IAutoService bmwAutoService;
            private IAutoService fordAutoService;
            private IAutoService hondaAutoService;

            public AutoServiceCallerImp(IAutoService bmwAutoService, IAutoService fordAutoService, IAutoService hondaAutoService) {
                this.bmwAutoService = bmwAutoService;
                this.fordAutoService = fordAutoService;
                this.hondaAutoService = hondaAutoService;
            }

            public void CallAutoService() {
                bmwAutoService.GetService();
                fordAutoService.GetService();
                hondaAutoService.GetService();
            }



        }




    }
}
