using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Automapper {
    public class Modelo1 {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    public class Modelo2 {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    public class EjmAutomapper {
        static void Main(string[] args) {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Modelo1, Modelo2>());
            IMapper iMapper = config.CreateMapper();

            var source = new Modelo1();

            source.Id = 1;
            source.FirstName = "Carlos";
            source.LastName = "Lopez";
            source.Address = "Castelldefels";

            var destino = iMapper.Map<Modelo1, Modelo2>(source);

            Console.WriteLine(destino.GetType());
            Console.WriteLine("Author Name: " + destino.FirstName + " " + destino.LastName);
            Console.ReadLine();
        }
    }
}