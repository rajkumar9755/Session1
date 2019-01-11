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
       /*Overriding of getArea() method is example for Runtime polmorphism*/
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
         Shape shap=new Rectangle();
         Console.WriteLine("Rectangle1 Area: {0}",  shap.getArea());
         shap=new Rectangle(4,5);
         Console.WriteLine("Rectangle2 Area: {0}",  shap.getArea());
         shap=new Square(4);
         Console.WriteLine("Square Area: {0}",  shap.getArea());
         shap=new Circle(5);
         Console.WriteLine("Circle Area: {0}",  shap.getArea());
      }
   }
}
