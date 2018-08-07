using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRedis {
    class Program {
        static void Main(string[] args) {
            var program = new Program();

            User u1 = new User(1, "Carlos", "Lopez");

            Console.WriteLine("Saving random data in cache");
            program.SaveBigData(u1);

            Console.WriteLine("Reading data from cache");
            program.ReadData();

            Console.ReadLine();
        }

        public void ReadData() {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            var devicesCount = 10000;
            for (int i = 0; i < devicesCount; i++) {
                var value = cache.StringGet($"Device_Status:{i}");
                Console.WriteLine($"Valor={value}");
            }
        }

        public void SaveBigData(User user) {
            using(RedisClient client = new RedisClient("localhost", 6379)){
                IRedisTypedClient<User> userRedis = client.As<User>();
                User u1 = userRedis.(user);
                    }

                cache.StringSet($"Device_Status:{0}", user);

                    cache.StringSet($"Device_Status:{i}", value);
            }
        }
    }
}

