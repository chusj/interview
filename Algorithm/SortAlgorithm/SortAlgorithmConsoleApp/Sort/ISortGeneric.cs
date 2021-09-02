using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmConsoleApp
{
    /// <summary>
    /// 排序(泛型)
    /// </summary>
    interface ISortGeneric
    {
        T[] Sort<T>(T[] array) where T : IComparable<T>;
    }
}
