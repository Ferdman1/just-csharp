using System;

namespace initfive
{
    
    class Program
    {
        
        static void Main()
        {
            cools(10);

        }
        public static void cools(int size)
        {
            int[] kools = new int[size];
            System.Console.WriteLine("Enter a size {0} of numbers",size);
            
            for(int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Enter an element of array : ");
                kools[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int u = 0; u < kools.Length; u++)
            {
                System.Console.Write(kools[u] + ", ");
            }
            int min =kools[0] ;
            for(int o = 0; o < kools.Length; o++)
            {
                if(kools[o] < min) 
                    min = kools[o];
            }
            System.Console.WriteLine("\nMin value is  : "+ min);
        }



    }

}
