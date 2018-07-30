using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("開始"); Console.WriteLine();
        Console.WriteLine();

        //  fix #1  如何把 6 到15 共 拾 個整數, 判斷其是否為質數
        //    , 如果是質數, 把它印出來
        //  請寫在下面


        //x = 6;
        // 比如 x 為 6, 則用 2, 3, 4, 5  ( 即比 x 少 1 ) 當除數去除它
        //   , 若都無法整除
        //   , 則其為質數, 可惜2及3當除數去除它, 都可以整除

        //y = 7;
        // 比如 y 為 7, 則用 2, 3, 4, 5, 6 ( 即比 y 少 1 ) 當除數去除它
        //   , 若都無法整除
        //   , 則其為質數, 結果真的都無法整除
        int x = 6;
        int y = 2;
        int s = 0;
        while (x < 15)
            {          
            while (x > y)
            {
                s = x % y;
                if (s == 0)
                {
                    x++;
                    y = 2;
                }
                else
                {
                    y++;
                }
               
            }
            if (y == x)
            {
                if (x < 15)
                {
                    Console.WriteLine(x + " 為質數");
                    y = 2;
                    x++;
                }
            }
        }

       
       
        


        //Console.WriteLine(x + " 為質數");


        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
  /*if (x % y == 0)
            {
                Console.Write(" ");
            }
            else
            { 
                Console.Write(x + " 為質數");
            }*/
