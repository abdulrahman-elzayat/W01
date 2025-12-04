namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of small carpets ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of large carpets ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price per small room 25$");
            Console.WriteLine("price per large room 35$");
            Console.WriteLine($"cost:{(a * 25) + (b * 35)}$");
            Console.WriteLine($"tax:{((a * 25) + (b * 35)) * (0.06)}$");
            Console.WriteLine($"total estimate:{((a * 25) + (b * 35)) * (0.06) + ((a * 25) + (b * 35))}$");
            Console.WriteLine("this estimate is valid 30 days");
        }
    }
}
