namespace AlgorithmProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure and Algorithm Practise Problem");

            String str = "Best!";
            int n = str.Length;
            Console.Write("All possible strings of : ");
            PermutationofString.usingIterativeMethod(str, 0, n - 1);

        }
    }
}