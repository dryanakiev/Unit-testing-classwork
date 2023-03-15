namespace Classwork_UnitTest
{
    internal class Program
    {
        // Main method used for user testing. Do not alter!
        static void Main(string[] args)
        {
            Console.WriteLine("Result of addition between 2 and 2 is: " + Calculator.Addition(2,2));

            Console.WriteLine("Result of subtraction between 6 and 2 is: " + Calculator.Subtraction(6,2));

            Console.WriteLine("Result of multiplication between 8 and 11 is: " + Calculator.Multiplication(8,11));

            Console.WriteLine("Result of division between 55 and 10 is: " + Calculator.Division(55,10));

            Console.WriteLine();

            Console.WriteLine("The encrypted password qwerty is: " + UserValidation.EncryptPassword("qwerty"));

            Console.WriteLine();

            Car car= new Car();

            Console.WriteLine("Calling method driving on a car returns: " + car.Driving());
            Console.WriteLine("Calling method stopping on a car returns: " + car.Stopping());
            Console.WriteLine("Calling method refueling on a car returns: " + car.Refueling());

            Console.WriteLine();

            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Calling method driving on a bicycle returns: " + car.Driving());
            Console.WriteLine("Calling method stopping on a bicycle returns: " + car.Stopping());
            Console.WriteLine("Calling method refueling on a bicycle returns: " + car.Refueling());
        }
    }
}