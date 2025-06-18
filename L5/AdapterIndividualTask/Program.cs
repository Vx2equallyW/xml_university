using ClassesLib;
namespace AdaptedIndividualTask
{
    class Program
    {
        public static void Main()
        {
            AdapterClassPendulum pendulum = new AdapterClassPendulum(2.0, 1.0, 1);
            Console.WriteLine(pendulum.CalculateT());
            Console.WriteLine(pendulum.CalculateW());
            Console.WriteLine(pendulum.X(5));
            Console.WriteLine(pendulum.GetData());
            pendulum.ModifMass(3);
            Console.WriteLine(pendulum.GetData());
        }
    }
}