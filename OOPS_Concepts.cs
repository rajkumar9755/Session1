using System;

namespace OOPS_Concepts{
   
   abstract class Shape{
      public abstract int getArea();
   }
   class Rectangle:Shape {
       
       protected int height,width;/* These data members can't be accessable in Solution class*/
       
       /*Line No 16-25 is example for Compile time polymorphism*/
       public Rectangle()
       {
           width=1;
           height=1;
       }
       public Rectangle(int h,int w)
       {
           width=w;
           height=h;
       }
       /*Calling of Overriden method getArea() during runtime is example for Runtime polmorphism*/
       public override int getArea()
        {
           return width*height;
        }
   }
   class Square:Rectangle{
       public Square()
       {
           width=1;
           height=1;
       }
       public Square(int side)
       {
           width=side;
           height=side;
       }
       
   }
   class Circle:Shape{
       private int radius;
       public Circle()
       {
           radius=1;
       }
       public Circle(int rad)
       {
           radius=rad;
       }
       /*Below method is example for Runtime Polymorphism*/
       public override int getArea()
        {
           return (22/7)*radius*radius;
        }
   }
   class Solution {
      static void Main(string[] args) {
         Shape rect1=new Rectangle();
         Shape rect2= new Rectangle(4,5);
         Shape sqr=new Square(4);
         Shape cir=new Circle(5);
         Console.WriteLine("Rectangle1 Area: {0}",  rect1.getArea());
         Console.WriteLine("Rectangle2 Area: {0}",  rect2.getArea());
         Console.WriteLine("Square Area: {0}",  sqr.getArea());
         Console.WriteLine("Circle Area: {0}",  cir.getArea());
         Console.ReadKey();
      }
   }
}
