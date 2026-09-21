namespace relapse
{
    internal class Program
    {
        static double[] Inverse_diagonal_average(int[,] matrix) 
        {
            double[]result=new double[matrix.GetLength(0)];






            return result;
        
        
        
        
        
        }
        static int[] Vector_sum(int[,] table)
        {
            int s = 0,sum=0;
            int[] result = new int[table.GetLength(0)]; 
                for(int i = 0; i < table.GetLength(0); i++)
                {
                    for (int t = 0; t < table.GetLength(1); t++)
                    {
                        sum += table[i,t];
                    }
                    result[s] = sum;
                    s++;
                    sum = 0;
                }       
            return result;
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
