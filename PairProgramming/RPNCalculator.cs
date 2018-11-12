using System;
using System.Collections;
using System.Globalization;
using Xunit;

namespace PairProgramming
{
    public class RPNCalculator : IRPNCalculator
    {
        
        double[] stack = new double[0];
        
        public void Push(double add)
        {
            double[] newstack = new double[stack.Length+1];
            for (int i = 0; i < stack.Length; i++)
            {
                newstack[i] = stack[i];
            }
            newstack[newstack.Length - 1] = add;

            stack = newstack;
        }

        public void Pop()
        {
            double[] newstack = new double[stack.Length - 1];
            for (int i = 0; i < newstack.Length; i++)
            {
                newstack[i] = stack[i];
            }

            stack = newstack;
        }

        public double Top()
        {
            return stack[stack.Length - 1];
        }

        public void Clear()
        {
            stack = new double[0];
        }

        public int Size()
        {
            return stack.Length;
        }

        public void Add()
        {
            double res = stack[stack.Length - 1] + stack[stack.Length - 2];
            double[] newstack = new double[stack.Length-1];
            for (int i = 0; i < newstack.Length-1; i++)
            {
                newstack[i] = stack[i];
            }

            newstack[newstack.Length - 1] = res;
            stack = newstack;
        }

        public void Subtract()
        {
            double res = stack[stack.Length - 1] - stack[stack.Length - 2];
            double[] newstack = new double[stack.Length-1];
            for (int i = 0; i < newstack.Length; i++)
            {
                newstack[i] = stack[i];
            }
            newstack[newstack.Length - 1] = res;
            stack = newstack;
        }

        public void Multiply()
        {
            double res = stack[stack.Length - 1] * stack[stack.Length - 2];
            double[] newstack = new double[stack.Length-1];
            for (var i = 0; i < newstack.Length; i++)
            {
                newstack[i] = stack[i];
            }
            newstack[newstack.Length - 1] = res;
            stack = newstack;
        }

        public void Divide()
        {
            if (stack[stack.Length - 2] == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                double res = stack[stack.Length - 1] / stack[stack.Length - 2];
                double[] newstack = new double[stack.Length - 1];
                for (var i = 0; i < newstack.Length; i++)
                {
                    newstack[i] = stack[i];
                }
                newstack[newstack.Length - 1] = res;
                stack = newstack;
            }
        }
    }
}