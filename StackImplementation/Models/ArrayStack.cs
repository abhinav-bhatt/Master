using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackImplementation.Models
{
    public class StackArray
    {
        public static int aa;
        public StackArray(int size)
        {
            aa = size;
        }
        
        public static int?[] ar = new int?[aa];
        //public static int[] SetStackSize(int stackSize)
        //{
        //    //int[] ArrayStack = new int[] { 1, 2, 3, 4, 5 };
        //    int[] ArrayStack = new int[stackSize];
        //    return ArrayStack;
        //}
    }
}
