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
        public DateTime Birthdate { get; set; }
    }

    public class Modelo2 {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    public class EjmAutomapper {
        static void Main(string[] args) {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Modelo1, Modelo2>()
            .ForMember(dest => dest.FullName, sou => sou.ResolveUsing(entity => entity.FirstName + " " + entity.LastName))
            .ForMember(dest => dest.Age, sou => sou.ResolveUsing(entity => DateTime.Today.AddTicks(-entity.Birthdate.Ticks).Year - 1)));
            IMapper iMapper = config.CreateMapper();

            var source = new Modelo1 {
                Id = 1,
                FirstName = "Carlos",
                LastName = "Lopez",
                Address = "Castelldefels",
                Birthdate = new DateTime(2000, 1, 25)
            };

            var destino = iMapper.Map<Modelo1, Modelo2>(source);


            Console.WriteLine(destino.GetType());
            Console.WriteLine("Author Name: " + destino.FullName + "\nEdad:" + destino.Age);
            Console.ReadLine();
        }
    }
}