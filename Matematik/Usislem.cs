using System;

namespace Matematik
{
    public class Usislem
    {
       public static int Ussu(int a, int b)
        {
            int y = a;
            for (int i = 1; i< b; i++)
            {
                y = a * y;
               
            }return y;
        }
    }
}
