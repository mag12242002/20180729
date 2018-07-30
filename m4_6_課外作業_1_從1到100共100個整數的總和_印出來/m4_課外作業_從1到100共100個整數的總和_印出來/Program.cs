using System;
class Program {
    static void Main(string[] args) {
        //1 + 2
        //      +  3
        //            + 4
        //                + 5
        //
        //                     + 98
        //                         +   99
        //                                + 100
        // fix #1  從1到100共100個整數的總和算出來後  印出來
        //          煩請用 while 做出來

        /* Console.WriteLine("????????????????????????????????");
         //1 + 2
         //  3    +  3
         //       6     + 4
         //             10   + 5
         //                  bla bla bla
         //                     4851  +   99
         //                           4950     + 100
         // 從1到100共100個整數的總和算出來後  印出來
         Console.WriteLine(1 + 2  );
         Console.WriteLine(1 + 2                 +  3 );
         Console.WriteLine(1 + 2 + 3             +  4 );
         Console.WriteLine(1 + 2 + 3 + 4         +  5 );
         Console.WriteLine(1 + 2 + 3 + 4 + 5     +  6 );
         Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
         int 上底 = 1;
         int 下底 = 100;
         int 等差 = 1;
         int 高 = ((下底 - 上底) / 等差) + 1;
         int 面積 = (上底 + 下底) * 高;
         int 答案 = 面積 / 2;
         Console.WriteLine(答案);        
         Console.WriteLine("################################");*/

        int i=1;
        int x;
        int sum=1;
        while(i<100)
        {
            i++;
            x = sum;
            sum = x+i;
        }

        Console.WriteLine(sum); 
        Console.WriteLine();
    }
}

