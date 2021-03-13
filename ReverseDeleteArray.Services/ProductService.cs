using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseDeleteArray.Services
{
    public class ProductService : IProductService
    {
        public int[] Reverse(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = tmp;
            }

            return numbers;
        }

        public int[] DeletePart(int position, params int[] numbers)
        {
            int[] result = new int[numbers.Length - 1];
            int z=0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (position - 1 != i)
                {
                    result[z] = numbers[i];
                    z++;
                }
            }
            return result;
        }
    }
}
