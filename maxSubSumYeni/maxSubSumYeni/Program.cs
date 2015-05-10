using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSubSumYeni
{
    class Program
    {
     

        static void Main(string[] args)
        {

            Random rastgele = new Random();
            int maxSum = 0, thisSum = 0;

            int[] dizi=new int[5];
            

            Console.WriteLine("dizi;");

            for (int m = 0; m < 5; m++)
            {
                dizi[m] = rastgele.Next(-20, 50);
                Console.WriteLine("{0}. elemanı:{1}",m,dizi[m]);

            }


            for (int j = 0; j <5; j++)
            {
                thisSum += dizi[j];
               

                if (thisSum > maxSum)
                    maxSum = thisSum;
                else if (thisSum < 0)
                    thisSum = 0;
            }

            Console.WriteLine("maxSubSum;");
            Console.Write(maxSum);
            Console.ReadLine();

            
       
        
        }
    }
}
