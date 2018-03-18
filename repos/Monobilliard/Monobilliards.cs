using System;
using System.Collections.Generic;

namespace Monobilliards
{
    public class Monobilliards : IMonobilliards
    {
        public bool IsCheater(IList<int> inspectedBalls)
        {
            if (inspectedBalls.Count == 0)
                return false;
            var stack = new Stack<int>();
            int expected1 = 0, expected2 = 100;
            for (int i = 0; i < inspectedBalls.Count; i++)
            {
                stack.Push(inspectedBalls[i]);
                if (stack.Peek() > expected1)
                    expected1 = stack.Peek();
                else if (stack.Peek() < expected1)
                {
                    if (stack.Peek() > expected2)
                        return true;
                    expected2 = stack.Peek();
                }
                else
                    return true;
            }
            return false;
        }
    }
}