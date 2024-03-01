namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store bigMamma = new Store("Big Mammas","Roskildevej 12","82712922");
            

            Console.WriteLine(bigMamma);

            

            bigMamma.start();

            Console.WriteLine(bigMamma.OrderInfo());

            Console.ReadKey();
        }
    }
}
