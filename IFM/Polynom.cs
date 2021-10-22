using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFM
{
    class Polynom
    {
        public double[] _input { get; set; }

        public double Discriminant()
        {
            double d = Math.Pow(_input[1], 2);
            double output = d - (4 * _input[0] * _input[2]);
            if (output is > 0)
            {
                return output;
            }
            else return -1;
        }

        public double X1(double D)
        {
            if (D is not -1)
            {
                double temp = _input[1] * (-1);
                double output = (temp + Math.Sqrt(D)) / (2 * _input[0]);
                return output;
            }
            else { return double.MaxValue; }
        }

        public double X2(double D)
        {
            if (D is not -1)
            {
                double temp = _input[1] * (-1);
                double output = (temp - Math.Sqrt(D)) / (2 * _input[0]);
                return output;
            }
            else { return double.MaxValue; }
        }

        public double[] Viet()
        {
            double[] output = new double[2];
            for (int i = 0; i < Math.Sqrt(_input[2]); i++)
            {
                double temp = _input[2] / i;
                double minusB = ((-1) * _input[1]);
                if ((temp + i) == minusB)
                {
                    output[0] = i;
                    output[1] = temp;
                }
                if ((temp + ((-1) * i)) == minusB)
                {
                    output[0] = ((-1) * i);
                    output[1] = temp;
                }
                if(((-1)* temp) + i == minusB)
                {
                    output[0] = i;
                    output[1] = (-1) * temp;
                }
                if(((-1)*temp) + ((-1)*i) == minusB)
                {
                    output[0] = (-1) * i;
                    output[1] = (-1) * temp;
                }
            }
            return output;
        }
        public void Solve()
        {
            var viet = Viet();

            if (_input[0] is 0)
            {
                Console.WriteLine("No solution!");
            }
            else
            {
                if (Discriminant() < 0)
                {
                    for (int i = 0; i < viet.Length; i++)
                    {
                        Console.WriteLine(viet[i]);
                    }
                }
                else { Console.WriteLine($"x1 = {X1(Discriminant())}"); Console.WriteLine($"x2 = {X2(Discriminant())}"); }
            }
        }
    }
}
