using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseDeleteArray.Services
{
   public interface IProductService
    {
        int[] Reverse(params int[] numbers);
        int[] DeletePart(int position, params int[] numbers);

    }
}
