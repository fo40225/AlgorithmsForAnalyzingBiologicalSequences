namespace AlgorithmsForAnalyzingBiologicalSequences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Program
    {
        /// <summary>
        /// calculate longest increasing subsequence
        /// </summary>
        /// <param name="source">input sequence</param>
        /// <param name="output">output sequence</param>
        /// <returns>sequence length</returns>
        public static int CalcLIS(int[] source, out int[] output)
        {
            int[] lenght = new int[source.Length];
            int[] positions = new int[source.Length];

            var smallestEnd = new List<int>();
            var lastPositions = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (smallestEnd.Count == 0)
                {
                    smallestEnd.Add(source[i]);
                    lenght[i] = smallestEnd.Count;
                    positions[i] = -1;
                    lastPositions.Add(i);
                    continue;
                }

                if (smallestEnd.Last() < source[i])
                {
                    smallestEnd.Add(source[i]);
                    lenght[i] = smallestEnd.Count;
                    positions[i] = lastPositions.Last();
                    lastPositions.Add(i);
                }
                else
                {
                    var posReplace = ~smallestEnd.BinarySearch(source[i]);
                    smallestEnd[posReplace] = source[i];

                    lenght[i] = posReplace + 1;

                    if (posReplace == 0)
                    {
                        positions[i] = -1;
                    }
                    else
                    {
                        positions[i] = lastPositions[posReplace - 1];
                    }

                    lastPositions[posReplace] = i;
                }
            }

            var lisLength = smallestEnd.Count;
            var lastPos = lastPositions.Last();
            var rtn = new List<int>();

            for (int i = 0; i < lisLength; i++)
            {
                rtn.Add(source[lastPos]);
                lastPos = positions[lastPos];
            }

            output = rtn.AsEnumerable().Reverse().ToArray();
            return lisLength;
        }
    }
}
