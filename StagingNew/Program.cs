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
            this.wall_height = wall_parameters["wall_height"];
            this.wall_width = wall_parameters["wall_width"];

        }

        public Dictionary<string,string> Proceed()
        {

            Staging staging = new Staging(wall_height, wall_width);

            var result = new Dictionary<string, string>()
            {
                ["Stands"] = staging.Stands_num.ToString(),
                ["Alongs"] = staging.Alongs_num.ToString(),
                ["Short Stands"] = staging.Short_stands_num.ToString(),
                ["Short Alongs"] = staging.Short_alongs_num.ToString(),
                ["Shields"] = staging.Shields_num.ToString(),
                ["Square Metres"] = staging.SquareMetres.ToString()

            };
           
            return result;
        }

    }
}
