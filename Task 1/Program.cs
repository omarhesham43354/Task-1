namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam`s Carpet Cleaning Service");
            Console.WriteLine("$25 Carpet smail");
            Console.WriteLine("$35 Carpet large");
            Console.WriteLine("Sales tax rate is 6%");

            // -----------------------------------------------------------------------------

            Console.WriteLine("numper_of_smail_carpets");
            int numper_of_smail_carpets = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("numper_of_larg_carpets");
            int numper_of_larg_carpets = Convert.ToInt32((Console.ReadLine()));

            int Price_Per_smail_carpet = 25;
            int Price_Per_large_carpet = 35;
            double Tax = .06;

            int Cost = (numper_of_smail_carpets * Price_Per_smail_carpet) + (numper_of_larg_carpets * Price_Per_large_carpet);
            Console.WriteLine($"Cost: {Cost}");


            double tax = Cost * Tax;
            Console.WriteLine($"tax: {tax}");

            double TotalPrice = tax + Cost;
            Console.WriteLine($"TotalPrice: {TotalPrice}");
        }
    }
}
