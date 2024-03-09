using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make both arrays
            float[,] array1 = new float[2, 2];
            float[,] array2 = new float[2, 1];

            //Separate each argument in the array
            array1[0,0] = float.Parse(args[0]);
            array1[0,1] = float.Parse(args[1]);
            array1[1,0] = float.Parse(args[2]);
            array1[1,1] = float.Parse(args[3]);
            array2[0,0] = float.Parse(args[4]);
            array2[1,0] = float.Parse(args[5]);

            //Multiplication of the arguments
            for(int i = 0; i < 2; i++)
            {
                float result = 0F;
                for(int j = 0; j < 2; j++)
                {
                    result += array1[i, j] * array2[j, 0];
                }
                Console.WriteLine(result);
            }
        }
    }
}
