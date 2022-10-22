using System;
 
class Min {
  static void Small(int a, int b, int c,int d) {
    int min = a;
    if (a <= b && a <= c && a<=d )
      min = a;
    if (b<= a && b <= c && b<=d)
      min = b;
    if (c <= a && c <= b && c<=d)
      min = d;
      if(d<=a &&  d<=b && d<=c)
      min = d;
    Console.WriteLine("Smallest number is:" + min);
  }  

 static void Main(string[] args) {
    Small(100, 50, 25,3);
    Small(50, 50, 25,5);
  }
}