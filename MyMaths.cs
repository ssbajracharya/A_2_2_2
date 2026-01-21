using System;
using System.Collections.Generic;
using System.Text;

namespace A_2_2_2
{
    internal class MyMaths
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2; 
        }
        public static double Add(double num1, double num2, double num3) => num1 + num2 + num3;
        

        public static float Multiply(float num1, float num2) 
        {  
            return num1 * num2; 
        }
        public static float Multiply(float num1, float num2, float num3) => num1 * num2 * num3;
    }
}
