using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAnd_Algorithms
{
    public class Cloud
    {
        //Based on a problem found on hackerRank
        private bool IsThunder(int input)
        {
            return input == 1;
        }

        public List<int> Pairs(int[] input)
        {
            var pairs = new List<int>();
            var lastWas0 = false;
            for (int i = 1; i < input.Length; i++)
            {
                if (!IsThunder(input[i]))
                {
                    if (!lastWas0)
                    {
                        pairs.Add(input[i]);
                        lastWas0 = true;
                    }
                    else
                    {
                        if (i + 1 < input.Length)
                        {
                            if (IsThunder(input[i+1]))
                            {
                                pairs.Add(input[i]);
                            }
                        }
                        lastWas0 = false;
                    }
                }
                else
                {
                    lastWas0 = false;
                }
            }
            return pairs;
        }
    }
}
