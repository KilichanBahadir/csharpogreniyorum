using System;

namespace works11


{
    struct Coordinate
       
    {
        //değişkenler
        public int x ;
        public int y;
        // constructer
        public Coordinate(int x,int y)
        {
            this.x = x;
            this.y = y;


        }
        //method
        public void SetOrigin()

        {
            this.x = 5;
            this.y = 5;
        }

    }
    class Program

    {
        static void Main(string[] args)
        {
            Coordinate point = new Coordinate();
            point.x = 10;
            point.y = 5;

          Console.WriteLine(point.x);
          Console.WriteLine(point.y);

            Coordinate point2 = new Coordinate(3, 7);
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);

            point2.SetOrigin();
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);
        }

    }


}
