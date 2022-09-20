namespace NumbersEndingin7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
