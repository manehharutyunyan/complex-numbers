using System;


namespace ComplexNumbers
{
    public class ComplexNum
    {
        private double real;
        private double im;

        public ComplexNum(double real, double im)
        {
            this.real = real;
            this.im = im;
        }

        public static ComplexNum operator +(ComplexNum a1, ComplexNum a2)
        {
            return new ComplexNum(a1.real + a2.real, a1.im + a2.im);
        }

        public static ComplexNum operator -(ComplexNum a1, ComplexNum a2)
        {
            return new ComplexNum(a1.real - a2.real, a1.im - a2.im);
        }

        public static ComplexNum operator *(ComplexNum a1, ComplexNum a2)
        {
            return new ComplexNum(a1.real * a2.real - a1.im * a2.im, a1.im * a2.real + a1.real * a2.im);
        }

        public static ComplexNum operator /(ComplexNum a1, ComplexNum a2)
        {
            double z = a2.real * a2.real + a2.im * a2.im;
            if (z == 0)
                return new ComplexNum(0, 0);
            return new ComplexNum((a1.real * a2.real + a1.im * a2.im) / z, (a1.im * a2.real - a1.real * a2.im) / z);
        }

        public override string ToString()
        {
            if (im > 0)
                return (String.Format("{0} + {1}i", real, im));

            return (String.Format("{0} - {1}i", real, im));
        }

        public double AbsoluteValue()
        {
            return (Math.Sqrt(real * real + im * im));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum a1 = new ComplexNum(3, 3);
            ComplexNum a2 = new ComplexNum(4, -1);

            //Console.WriteLine(a1 + a2);
            //Console.WriteLine(a1 - a2);
            //Console.WriteLine(a1 * a2);
            //Console.WriteLine(a1 / a2);
            //Console.WriteLine(a1.AbsoluteValue());
            //Console.WriteLine(a2.AbsoluteValue());
            
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
