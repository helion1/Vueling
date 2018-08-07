using Autofac;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByZero {


    class Program {
        
        private static Autofac.IContainer Container { get; set; }

        static void Main(string[] args) {

            AutofacConfig.ConfigureContainer();

            DividirNumeros(4000, 0);
        }

        public static class AutofacConfig {
            public static void ConfigureContainer() {
                var builder = new ContainerBuilder();

                builder.RegisterModule(new LogginModule());
                builder.RegisterType<CalculadoraController>().SingleInstance();
                builder.RegisterType<CalculadoraController>().As<IDivision>();
                
                Container = builder.Build();
            }
        }

        public static void DividirNumeros(int num1, int num2) {

            using (var scope = Container.BeginLifetimeScope()) {
                var res = scope.Resolve<CalculadoraController>().Dividir(num1, num2);
                Console.WriteLine(res);
            }
        }

        public interface IDivision {
            int Dividir(int num1, int num2);
        }


        public class CalculadoraController : IDivision {

            private readonly log4net.ILog _logger;

            public CalculadoraController(ILog logger) {
                _logger = logger;
            }

            public int Dividir(int num1, int num2) {

                int res = 0;
                try {
                    return  num1 / num2;

                }catch (DivideByZeroException) {

                    _logger.Error("No se puede dividir entre 0, MONGOOOOO {0}");
                    //throw e;
                }
                return res;
            }
        }

        
    }


    
}
