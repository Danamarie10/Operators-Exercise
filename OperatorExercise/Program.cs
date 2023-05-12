using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {

        static void Main()
        {
            //Exercise 1 
            var a = 17;
            var b = 4;

            var quotient = a / b;
            var remainder = a % b;

            if (a == 17 && b == 4) ;
            Console.WriteLine($"{a} / {b} is 4 with a remainder of {remainder}");

            Console.WriteLine("--------------------------------------------");

            //Exercise 2

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);
            Console.WriteLine($"The Area of the circle is: {area}");

        }


        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
