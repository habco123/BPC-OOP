using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    internal class Extremy
    {
        public static List<T> Nejvetsi<T>(T[] pole) where T : IComparable<T>
        {
            if (pole.Length == 0)
            {
                throw new Exception("input array is empty");
            }
            List<T> max = new List<T>();
            foreach (var value in pole)
            {
                if (max.Any())
                {
                    int compareValue = value.CompareTo(max[0]);
                    if (compareValue > 0)
                    {
                        max.Clear();
                        max.Add(value);
                    }
                    else if (compareValue == 0)
                    {
                        max.Add(value);
                    }
                }
                else
                {
                    max.Add(value);
                }
            }
            return max;
        }

        public static List<T> Nejmensi<T>(T[] pole) where T : IComparable<T>
        {
            if (pole.Length == 0)
            {
                throw new Exception("input array is empty");
            }
            List<T> min = new List<T>();
            foreach (var value in pole)
            {
                if (min.Any())
                {
                    int compareValue = value.CompareTo(min[0]);
                    if (compareValue < 0)
                    {
                        min.Clear();
                        min.Add(value);
                    }
                    else if (compareValue == 0)
                    {
                        min.Add(value);
                    }
                }
                else
                {
                    min.Add(value);
                }
            }
            return min;
        }
    }
}
