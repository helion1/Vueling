﻿using Facade.Vehicle.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Vehycle.SubClases {
    class Minivan : IVehicle {
        public int doors;
        public int seating;
        public int cc;

        public Minivan(int doors, int seating, int cc) {
            this.doors = doors;
            this.seating = seating;
            this.cc = cc;
        }

        public string Description() {
            return String.Concat(
                        String.Concat(
                            String.Concat(
                                String.Concat("Monovolumen\nPuertas:", this.doors),
                                String.Concat("\nAsientos: ", this.seating)),
                                String.Concat("\nCilindrada: ", this.cc), "\n\n\n"));
        }
    }
}