namespace relapse
{
    internal class Program
    {
        static int[] Maximum(int[] numbers) {
            int[] result= new int[2];

            for (int i = 0; i < numbers.Length; i++) 
            { 
                if(numbers[i] == result[0])
                {
                    result[0] = numbers[i];
                    result[1] = i;
                }           
            }
        return result;
        }
        static bool Finder(int x,int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int t = 0; t < matrix.GetLength(1); t++)
                {
                    if(matrix[i,t] == x)
                    {
                        return true;
                    }
                }

            }
            return false;

        }
        static string[] Inversion(string[] original)
        {
            int t = 0;
            string[] result = new string[original.Length];
            for(int i=original.Length-1; i>=0; i--)
            {
                result[t] = original[i];
                t++;    
            }
            return result;
        }
        static int[] Vector_sum(int[,] table)
        {
            int s = 0, sum = 0;
            int[] result = new int[table.GetLength(0)];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int t = 0; t < table.GetLength(1); t++)
                {
                    sum += table[i, t];
                }
                result[s] = sum;
                s++;
                sum = 0;
            }
            return result;
        }
        static double[] Inverse_diagonal_average(int[,] matrix)
        {
            double[] result = new double[matrix.GetLength(0)];
            double average = 0;
            int s = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int t = 0; t < matrix.GetLength(1); t++)
                {
                    average += matrix[i, t];
                }

            }
            average /= matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result[s] += average * matrix[i, i];
                s++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
