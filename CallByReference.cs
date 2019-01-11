using System;
namespace CallByReference{
   class Solution {
      void ChangeValue(ref int [] arr)
      {
          arr=new int[]{6,7,8,9,10};
          Console.WriteLine("\nInside function");
          foreach(int num in arr)
          {
              Console.Write("{0} ",num);
          }
      }
      static void Main(string[] args) {
         int [] arr={1,2,3,4,5};
         Solution s=new Solution();
         Console.WriteLine("Before Calling function");
          foreach(int num in arr)
          {
              Console.Write("{0} ",num);
          }
         s.ChangeValue(ref arr);
         Console.WriteLine("\nAfter Calling function");
          foreach(int num in arr)
          {
              Console.Write("{0} ",num);
          }
         
      }
   }
}
