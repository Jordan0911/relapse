namespace relapse
{
    internal class Program
    {
           static bool Palindrome(string word)
   {
       int s = 0;
       char[] reversed_word = new char[word.Length];
       for(int i = word.Length; i>=0; i--)
       {
           reversed_word[s] = word[i];
           s++;
       }
       s = 0;
       for(int i = 0; i < word.Length; i++)
       {
           if (reversed_word[i] == word[i])
           {
               s++;
           }

       }
       if (s == word.Length)
       {
           return true;
       }
       return false;
   }
   static int Wowel_counter(string phrase)
   {
       int result = 0;
       char[] wovels ={'a','e','i','o','u'};
       for(int i=0; i <wovels.Length; i++)
       {
           for(int s = 0; s < phrase.Length; s++)
           {
               if (phrase[s] == wovels[i])
               {
                   result++;
               }

           }
       }
       return result;
   }
   static void Border(string s)
   {
       for(int i = 0; i < s.Length; i++)
       {
           Console.Write("*");
       }
       Console.WriteLine(s);
       Console.WriteLine();
       for (int i = 0; i < s.Length; i++)
       {
           Console.Write("*");
       }

   }
   static int Exercise_9()
   {
       bool found = false;
       int ntries = 0,number=0;

       while (found == true)
       {
           number = Convert.ToInt32(Console.ReadLine());   
           if( number < 0)
           {
               found=true;
           }
           else
           {
               ntries++;
           }                
       }
       return ntries;
   }
   static int Potential_man(int x, int n)
   {
       int number = x;
       for (int i = 0; i < n-1; i++) 
       {
           number= number * x;
       }            
       return number;
   }
   static bool EvenorOdd(int n)
   {
       if (n % 2 == 0)
       {
           return true;
       }
       return false;
   }
   static int Area( int x, int y)
   {
       int result = 0;
       result = x * y;
       return result;
   }
   static void Rectangle_printer()
   {
       int height = 0, width = 0;
       Console.WriteLine("insert desired height and width of the rectangle");
       height=Convert.ToInt32(Console.ReadLine);
       width=Convert.ToInt32(Console.ReadLine);
       for (int i = 0; i < height; i++)
       {
           Console.WriteLine();
           for (int l = 0; i < width; l++)
           {
               Console.Write("*");
           }
       }


   }
   static void Marks()
   {
       double votes_sum = 0, votes_average = 0;
     
       int nvotes = 0;
       Console.WriteLine("insert how many votes you want to insert");
       nvotes=Convert.ToInt32(Console.ReadLine());
       for (int i = 0; i < nvotes; i++) 
       {
           if (i == 0)
           {
               Console.WriteLine("start inserting the votes ");
              votes_sum +=Convert.ToInt32(Console.ReadLine());
           }
           else
           {
               votes_sum += Convert.ToInt32(Console.ReadLine());
           }
       
       }
   votes_average=votes_sum/nvotes;
       Console.WriteLine($"The average between the marks was {votes_average} and the sum of the votes was {votes_sum} ");
       
   }
   static List<int> Factorizer(int x,int y)
   {
       List<int> result = new List<int>();
       List<int> factorized_x = new List<int>();
       List<int> factorized_y = new List<int>();
       for (int i = 0; i < x; i++)
       {
           if (x % i == 0)
           {
             factorized_x.Add(i);
           }
           if (y % i == 0)
           {
               factorized_y.Add(i);
           }
       }
       for (int l=0;l<factorized_x.Count;l++)
       {
           for(int s = 0; s < factorized_y.Count; s++)
           {
               if (factorized_x[l] == factorized_y[s])
               {
                   result.Add(factorized_y[s]);
               }
           }
       }


       return result;
   }
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
                average += matrix[i, i];

            }
            average /= matrix.GetLength(0);
            for (int i = matrix.GetLength(0)-1; i>=0; i--)
            {
                result[s] += average * matrix[s, i];
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
