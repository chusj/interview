using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmConsoleApp
{

    public class Insertion : ISortGeneric
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        public T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                var temp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j].CompareTo(temp) > 0)
                    {
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
