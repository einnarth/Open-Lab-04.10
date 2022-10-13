using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            List<int> list = nums.ToList();
          float j =  list.AsQueryable().Sum();
          float k = list.Count;
          float u = j / k;
          return u;
        } 
    }
}
