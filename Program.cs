using System;
using System.Globalization;
namespace solonnhat{
    class Program{
        static void Main(string[] Args){
            int[,] nums;
            Console.WriteLine("nhap vao dong: ");
            int dong = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao cot: ");
            int cot = Int32.Parse(Console.ReadLine());
                
            nums = new int[dong,cot];
            for(int a = 0; a < dong; a ++){
                for(int b = 0; b < cot;  b ++){
                    nums[a,b] = Int32.Parse(Console.ReadLine());
                }
            }
            int max = 0;
            for(int i = 0;i < nums.GetLength(0); i ++){
                for(int j =0; j < nums.GetLength(1); j ++){
                    
                    max = nums[i,j];
                  if(nums[i,j] > max){
                    max = nums[i,j];
                    
                  }
                  
                }
            }Console.WriteLine(max);
    }
    }
}
