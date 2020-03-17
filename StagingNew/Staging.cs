using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagingNew
{
    class Staging
    {

        private double long_height = 0;
        private double long_width  = 0;
        private double short_height = 0;
        private double short_width = 0;


        public int Stands_num { get; private set; } = 2;
        public int Alongs_num { get; private set; } = 0;
        public int Short_stands_num { get; private set; } = 2;
        public int Short_alongs_num { get; private set; } = 0;
        public int Shields_num { get; private set; } = 0;


        public Staging(double wall_height, double wall_width)
        {
            CalculateHeight(wall_height);
            CalculateWidth(wall_width);

            CalculateElements();
        }
        

        private void CalculateHeight(double wall_height)
        {
            while(wall_height >= 2.75)
            {
                long_height += 2.75;
                wall_height -= 2.75;   
            }
            while(wall_height >= 1.2)
            {
                short_height += 1.2;
                wall_height -= 1.2;
            }
        }

        private void CalculateWidth(double wall_width)
        {
            while(wall_width >= 3)
            {
                Stands_num += 2;
                Short_stands_num += 2;
                Alongs_num += 2;
                long_width += 3;
                wall_width -= 3;
            }
            while(wall_width >= 1.2)
            {
                Stands_num += 2;
                Short_stands_num += 2;
                Short_alongs_num += 2;
                short_width += 1.2;
                wall_width -= 1.2;
            }
        }

        private void CalculateElements()
        {
            CalculateStands();
            CalculateAlongs();
        }

        private void CalculateStands()
        {
            int long_floors  = (int)(long_height / 2.75);
            int short_floors = (int)(short_height / 1.20);


            Stands_num *= long_floors;
            Short_stands_num *= short_floors;

        }

        private void CalculateAlongs()
        {
            int floors = (int)(long_height / 2.75) + (int)(short_height / 1.20);

            int one_floor_alongs = Alongs_num;
            int one_floor_short_alongs = Short_alongs_num;

            for(int i = 1; i <= floors; i++)
            {
                Alongs_num += one_floor_alongs;
                Short_alongs_num += one_floor_short_alongs;
            }

            Short_alongs_num += Stands_num;
            Short_alongs_num += Short_stands_num;
        }
 
    }
}
