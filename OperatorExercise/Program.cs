namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle is {AreaOfCircle(radius)}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} / {b} is {quotient}, remainder = {remainder}");
            
          PrintAreaOfCircle();  
            
        }
    }
}
