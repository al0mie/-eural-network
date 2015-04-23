using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNet
{
    class Program
    {
        public static double[,] InputVectorOne = new double[20, 2];
        public static double[,] InputVectorTwo = new double[20, 2];
        public static Double[,] W = new Double[2, 2];

        public static double Teach() { 
             for (int z = 0; z < 20; z++) {

                 double scalar1 = InputVectorOne[z, 0] * W[0, 0] + InputVectorOne[z, 1] * W[0, 1];
                 double scalar2 = InputVectorTwo[z, 0] * W[1, 0] + InputVectorTwo[z, 1] * W[1, 1];

                 if (scalar1 > scalar2)
                 {
                     W[0, 0] = W[0, 0] + (50 - z) / 100 * (InputVectorOne[z, 0] - W[0, 0]);
                     W[0, 1] = W[0, 1] + (50 - z) / 100 * (InputVectorOne[z, 1] - W[0, 1]);
                 }
                 else
                 {
                     W[1, 0] = W[1, 0] + (50 - z) / 100 * (InputVectorTwo[z, 0] - W[1, 0]);
                     W[1, 1] = W[1, 1] + (50 - z) / 100 * (InputVectorTwo[z, 1] - W[1, 1]);
                 }   
             
             }
           return 0;
        }

        static string ask(double x, double y) {

            if (x * W[0, 0] + y * W[0, 1] > W[1, 0] + y * W[1, 1])
            {
                return "right";

            }
            else return "left";
      }

  
        static void Main(string[] args)
        {
          Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    InputVectorOne[i, 0] = rand.Next(5, 15);
                    InputVectorTwo[i ,0] = rand.Next(-15, -5);
                    InputVectorOne[i, 1] = rand.Next(0, 10);
                    InputVectorTwo[i , 1] = rand.Next(0, 10);

                }
            }


            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    W[i,j] = rand.NextDouble();
                }
            }

               for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Number" + InputVectorOne[i, 1]);

                }
               Teach();
                    Console.WriteLine(W[0,0]+" :"+ W[0,1]);
                    Console.WriteLine(W[1, 0] + " :" + W[1, 1]);

                    for (int i = 0; i < 20; i++) {

                        Console.WriteLine(ask(-i, 10));
                    
                    }
                    
       Console.Read();
        }
    }
}
