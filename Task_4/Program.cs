namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper m= new MathHelper();

            int num1 = m.PrintValue(10 , 20);
            Console.WriteLine(num1);

            bool b1 = m.PrintValue(false);
            Console.WriteLine(b1);

            string s = m.PrintValue("Hello", " World");
            Console.WriteLine(s);

            int mul = m.PrintValue(10, 20, 30);
            Console.WriteLine(mul);

        }

        
    }
}