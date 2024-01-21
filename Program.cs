namespace lab0task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowNumber, highNumber;

            // Looping and Input Validation
            do
            {
                Console.WriteLine("Enter a positive low number");
            } while (!int.TryParse(Console.ReadLine(), out lowNumber) || lowNumber <= 0);

            do
            {
                Console.WriteLine("Enter a high number");
            } while (!int.TryParse(Console.ReadLine(), out highNumber) || highNumber <= 0);
        }
    }
}
