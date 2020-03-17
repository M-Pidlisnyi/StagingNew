using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StagingNew;

namespace StagingNew
{
    class Program
    {
        private double wall_height;
        private double wall_width;

        public Program(Dictionary<string, double> wall_parameters)
        {
            this.wall_height = wall_parameters["wall_heigth"];
            this.wall_width = wall_parameters["wall_width"];

        }

        public Staging Calculate()
        {
            Staging result = new Staging();
            return result;
        }
    }
}
