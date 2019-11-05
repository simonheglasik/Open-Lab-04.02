using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        { 
            string a="";
            for(int i = 0;i<original.Length;i++)
            {
                for (int v = 0;v<2;v++)
                {
                    a = a + original[i];
                }
            }
            return a;
        }
    }
}
