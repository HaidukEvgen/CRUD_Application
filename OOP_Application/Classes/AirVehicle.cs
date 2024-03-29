﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Application
{
    public abstract class AirVehicle : Vehicle
    {
        [Name("Flying height")]
        public int flyingHeight;

        public AirVehicle() { }
        public AirVehicle(int _flyingHeight, string _brand, int _price, int _year, int _seatsAmount, Driver _driver, List<Passenger> _passengers) :
                      base(_brand, _price, _year, _seatsAmount, _driver, _passengers)
        {
            this.flyingHeight = _flyingHeight;
        }
    }
}
