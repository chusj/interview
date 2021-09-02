using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmConsoleApp
{
    /// <summary>
    /// 递归
    /// </summary>
    public class Recursion
    {
        /// <summary>
        /// （递归）获取总数
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static int GetSum(int[] array, int length)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            else
            {
                int n = length - 1;
                if (n == 0)
                {
                    return array[n];
                }
                else
                {
                    return array[n] + GetSum(array, length - 1);
                }
            }
        }
    }
}
