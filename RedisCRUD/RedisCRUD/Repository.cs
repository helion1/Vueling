using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCRUD {
    public class Repository {


        public bool Post(AlumnoModel alumno) {
            using (RedisClient redisClient = new RedisClient("localhost:6379")) {
                if (redisClient.Get<string>(alumno.Id.ToString()) == null) {
                    redisClient.Set(alumno.Id.ToString(), alumno);
                    return true;
                }
            }

            return false;
        }
    }
}
