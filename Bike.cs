using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Bike : Vehicle, RoadRules
    {
        public string horn()
        {
            return("Bikers, don't horn unnecessarily");
        }

        public string speedDown()
        {
            return("Bikers, reduce your speed");
        }

        public string speedUp()
        {
            return("Bikers, you can speed up");
        }

        public string Color;
        public int Gears;
        
        public Bike()
        {
            this.model = "R15";
            this.make = 2020;
            Color = "Red";
            Gears = 5;
        }

        public Bike(string model, string color, int make, int gears) 
        {
            this.model = model;
            this.make = make;
            Color = color;
            Gears=gears;
        }

        public string getInfo()
        {
            return "The model of the bike is" + getModel();
        }
    }


}
