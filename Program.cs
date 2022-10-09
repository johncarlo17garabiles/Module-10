using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CircleForm
    {
        private double radius;
        public double Radius
        {
            get
            { 
                return radius; 
            }
            set
            { 
                radius = value; 
            }

        }
        
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        private double pi = Math.PI;
        public double Pi 
        {
            get 
            { 
                return pi; 
            }
            set 
            { 
                pi = value; 
            }
        }

        private double area;
        public double Area
        {
            get 
            { 
                return area; 
            }
            set 
            { 
                area = value; 
            }

        }

        private double perimeter;
        public double Perimeter
        {
            get 
            { 
                return perimeter; 
            }
            set 
            { 
                perimeter = value; 
            }
        }

        class circle 
        {
            static void Main(string[] args)
            {
                CircleForm circlecolor = new CircleForm();
                circlecolor.color = "Red";
                Console.WriteLine(circlecolor.Color);

                CircleForm circleradius = new CircleForm();
                circleradius.radius = 12;
                Console.WriteLine(circleradius.radius);

                CircleForm circlepi = new CircleForm();
                circlepi.pi = Math.PI;

                CircleForm circlearea = new CircleForm();
                circlearea.area = (circlepi.pi * (circleradius.radius * circleradius.radius));
                Console.WriteLine("Area: " + circlearea.area);

                CircleForm circleperi = new CircleForm();
                circleperi.perimeter = (2 * circlepi.pi * circleradius.radius);
                Console.WriteLine("Circumference: " + circleperi.perimeter);

                
            }
        }
    }
}
