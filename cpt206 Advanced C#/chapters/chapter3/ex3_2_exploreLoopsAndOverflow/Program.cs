namespace ex3_2_exploreLoopsAndOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
