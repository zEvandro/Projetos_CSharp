namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "fred", "juliana", "carol", "jose", "paulo", "rita", "adriano", "francisco" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);    
            }
            Console.WriteLine("-----------------------------------------------------");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}