using System;
using System.Globalization;
namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[] values = new float[6];
            for (int i = 0; i < 6; i++)
            {
                values[i] = Convert.ToSingle(args[i],CultureInfo.InvariantCulture);
            }
            float[,] A = { { values[0], values[1] }, { values[2], values[3] } };
            float[] b = { values[4], values[5] };
            float[] result = new float[2];
            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            foreach (float num in result)
            {
                Console.WriteLine($"| {num,7:F2} |");
            }
        }


    }
}
